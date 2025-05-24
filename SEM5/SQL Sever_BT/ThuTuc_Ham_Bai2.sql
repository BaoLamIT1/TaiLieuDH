USE QLNhanVien

--1. Tạo hàm với đầu vào là năm, đầu ra là danh sách nhân viên sinh vào năm đó
create function f_cau1( @nam int)
returns table
as
return 
(
	select *
	from tNhanVien
	where YEAR( tNhanVien.NTNS) = @nam
)
Select *from f_cau1(1970)

--2. Tạo hàm với đầu vào là số thâm niên (số năm làm việc) đầu ra là danh sách nhân viên có thâm niên đó
create function f_cau2(@thamnien int )
returns table
as
return 
(
select *
	from tNhanVien 
	where datediff( year, NgayBD, getdate()) >= @thamnien
)
select *from f_cau2(35)

--3. Tạo hàm đầu vào là chức vụ, đầu ra là những nhân viên cùng chức vụ đó
create function f_cau3(@chucvu nvarchar(20))
returns table
as
return 
(	
	select *
	from tNhanVien 
	where MaNV in
	(
		select MaNV
		from tChiTietNhanVien
		where ChucVu= @chucvu
	)
)
select *from f_cau3('PP')
--4. Tạo hàm đưa ra thông tin về nhân viên được tăng lương của ngày hôm nay (giả sử 3 năm lên lương 1 lần)

create function f_cau4()
returns table 
as
return
(	

	select *
	from tNhanVien
	where DATEDIFF( YEAR, NgayBD, GETDATE()) %3 =0
)
SELECT * FROM f_cau4()

--5. Tạo Hàm xây dựng bảng lương của nhân viên gồm các thông tin sau:
--- Lương = lương cơ bản * HSLuong + Phụ cấp (Giả sử lương cơ bản=1490000vnd (1.49tr))
--- BHXH: 8%*lương (bảo hiểm xã hội)
--- BHYT: 1,5% * lương (bảo hiểm y tế)
--- BHTN: 1%* lương (Bảo hiểm thất nghiệp)
--- Thuế TNCN (Thuế thu nhập cá nhân) được tính như sau:
--Bậc Thu nhập tháng Số thuế phải nộp
--1. TN<=5tr TN*5%
--2. 5tr<TN<=10tr TN*10%-0.25tr
--3. 10tr<TN<=18tr TN*15%-0.75tr
--4. 18tr<TN<=32tr TN*20%-1.65tr
--5. 32tr<TN<=52tr TN*25%-3.25tr
--6. 52tr<TN<=80tr TN*30%-5.85tr
--7. TN>80tr TN*35%-9.85tr
--Trong đó: TN= Lương - BHXH - BHYT - BHTN - 11tr (mức chịu thuế) - GTGC*4.4tr (Giảm
--trừ gia cảnh)
--- Phụ cấp: Mức độ công việc là A thì phụ cấp 10tr, mức độ B là 8tr, mức độ C là 5tr
--- Thực lĩnh: Lương – (BHXH+BHYT+BHTN + Thuế TNCN)
create function f_cau5(@MaNV nvarchar(20))
returns decimal(18,2)
as
begin 
	declare @Luong int, @HsLuong tinyint, @Phucap int, @BHXH int, 
			@BHYT int,	@BHTN int, @ThuNhap int, @MucdoCV nvarchar(20)
	-- Lấy thông tin từ tChiTietNhanVien
	select @HSLuong = HSLuong, @MucDoCV= MucDoCV
	from tChiTietNhanVien
	where MaNV = @MaNV
	-- Tính lương
    SET @Luong = 1490000 * @HSLuong
    -- Tính phụ cấp dựa trên MucDoCV
    IF @MucDoCV = 'A'
        SET @PhuCap = 10000000
    ELSE IF @MucDoCV = 'B'
        SET @PhuCap = 8000000
    ELSE IF @MucDoCV = 'C'
        SET @PhuCap = 5000000
    ELSE
        SET @PhuCap = 0

    -- Tính BHXH, BHYT, BHTN, Thuế TNCN
    SET @BHXH = 0.08 * @Luong
    SET @BHYT = 0.015 * @Luong
    SET @BHTN = 0.01 * @Luong
    SET @ThuNhap = @Luong - @BHXH - @BHYT - @BHTN - 11000000 -- Mức chịu thuế và GTGC

    -- Tính thuế TNCN dựa trên thuế suất
    IF @ThuNhap <= 5000000
        SET @ThuNhap = @ThuNhap * 0.05
    ELSE IF @ThuNhap <= 10000000
        SET @ThuNhap = @ThuNhap * 0.1 - 250000
    ELSE IF @ThuNhap <= 18000000
        SET @ThuNhap = @ThuNhap * 0.15 - 750000
    ELSE IF @ThuNhap <= 32000000
        SET @ThuNhap = @ThuNhap * 0.2 - 1650000
    ELSE IF @ThuNhap <= 52000000
        SET @ThuNhap = @ThuNhap * 0.25 - 3250000
    ELSE IF @ThuNhap <= 80000000
        SET @ThuNhap = @ThuNhap * 0.3 - 5850000
    ELSE
        SET @ThuNhap = @ThuNhap * 0.35 - 9850000

    -- Tổng cộng lương thực lĩnh
    RETURN @Luong - (@BHXH + @BHYT + @BHTN + @ThuNhap)
END

select dbo.f_cau5('001') as LuongThucLinh

--6. Tạo thủ tục có đầu vào là mã phòng, đầu ra là số nhân viên của phòng đó và tên trưởng phòng

create procedure p_cau6 
(
	@maphong nvarchar(20),
	@soNV int output,
	@tenTP nvarchar(20) output
)
as 
begin 
	--Lay so nhan vien cua phong
	select @soNV = COUNT(MaNV)
	from tNhanVien
	where MaPB= @maphong
	--Lay ten truong phong
	select @tenTP = HO + ' '+ TEN
	from tNhanVien join tChiTietNhanVien on tChiTietNhanVien.MaNV = tNhanVien.MaNV
	where MaPB = @maphong and ChucVu = 'TP'
end

----------------
declare @soNV int, @tenTP nvarchar(20)
exec p_cau6 @maphong = 'KH', @soNV = @soNV output , @tenTP= @tenTP output
print 'so nhan vien trong phong ban la: ' + convert(nvarchar(10),@soNV )
print 'ten truong phong la: ' + @tenTP
------------------
--7. Tạo thủ tục có đầu vào là mã phòng, tháng, năm, đầu ra là số tiền lương của phòng đó
CREATE PROCEDURE p_cau7

    @maphong nvarchar(2),
	@thang int,
	@nam int,
	@tongluong money output

AS
BEGIN
    -- Lấy danh sách nhân viên của phòng
    SELECT @tongluong = SUM(1490000 * HSLuong + iif(MucDoCV LIKE 'A%', 10000000, (iif(MucDoCV LIKE 'B%', 8000000, 5000000))))
    FROM tNhanVien join tChiTietNhanVien on tNhanVien.MaNV = tChiTietNhanVien.MaNV
    WHERE MaPB = @maphong
    AND (MONTH(NgayBD) < @thang and YEAR(NgayBD) = @nam)
    OR YEAR(NgayBD) < @nam
END
-------------
declare @tongluong money 
exec p_cau7 N'KH' ,5, 1995, @tongluong output 
print 'so tien luong cua phong do: '+ convert(nvarchar(20), @tongluong)
