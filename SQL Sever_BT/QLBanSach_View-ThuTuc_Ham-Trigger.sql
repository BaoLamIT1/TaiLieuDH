--1 Tạo thủ tục có đầu vào là mã sách, đầu ra là số lượng sách đó được bán trong năm 2014

USE [BT1CSDL]
CREATE PROCEDURE SoLuongSach @masach nvarchar(5) , @soluong int output
as 
begin 
select @soluong = sum(SLBan)
from tSach join tChiTietHDB on tSach.MaSach= tChiTietHDB.MaSach
join tHoaDonBan on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
where tSach.MaSach = @masach  and YEAR(tHoaDonBan.NgayBan) = 2014
end 
-- goi thu tuc
declare @slg int 
exec SoLuongSach 'S03' , @slg output
print @slg 

--2 Tạo thủ tục có đầu vào là ngày, đầu ra là số lượng hoá đơn và số lượng tiền bán của sách trong ngày đó
--CREATE PROCEDURE SoLuongHD @ngay datetime , @solghd int , @slgtien money 
--output
--as
--begin 
--select @solghd = sum(tHoaDonBan.SoHDB) , @slgtien = sum( tChiTietHDB.SLBan * tSach.DonGiaBan)
--from 
--tSach join tChiTietHDB  on tSach.MaSach = tChiTietHDB.MaSach
--	  join tHoaDonBan on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
--9. Tạo thủ tục có đầu vào là mã sách, năm, đầu ra số lượng sách nhập, số lượng sách bán
--trong năm đó
create procedure pro_Cau9
( @masach nvarchar(20), @nam int, @Slnhap int output, @slban int output)
as begin
select 
	@Slnhap = sum(SLNhap) 
	from tHoaDonNhap join tChiTietHDN on tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN
	where @masach = MaSach and @nam = year(tHoaDonNhap.NgayNhap);
select 
	@slban = sum(SLBan)
	from tHoaDonBan join tChiTietHDB on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
	where @masach = MaSach and @nam=year(tHoaDonBan.NgayBan)
end

declare @Slnhap int, @slban int
exec pro_Cau9 @masach = N'S05', @nam = 2014, @Slnhap= @Slnhap output, @slban = @slban output
print 'So luong nhap sach:' + convert(nvarchar(20),@SlNhap)
print 'So luong ban sach: ' + convert(nvarchar(20),@slban)
	
--10. Tạo thủ tục có đầu vào là mã khách hàng, năm, đầu ra là số lượng sách đã mua và số
--lượng tiền tiêu dùng của khách hàng đó trong năm nhập vào.
alter procedure pro_Cau10
(	@maKH nvarchar(20), @nam int, @slmua int output , @tongtien money output)
as begin 
select 
	@slmua = count(SoHDB)
	from tHoaDonBan
	where @maKH = MaKH and year(NgayBan) = @nam;
select 
	@tongtien = sum(SLBan*DonGiaBan)
	from tChiTietHDB join tSach on tChiTietHDB.MaSach = tSach.MaSach
	join tHoaDonBan on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
	where @maKH = MaKH and year(NgayBan) =@nam
end

declare @slmua int , @tongtien money
exec pro_Cau10 @maKH = N'KH01', @nam = 2014, @slmua = @slmua output, @tongtien = @tongtien output
print 'Tong sach da mua la: ' + convert(nvarchar(10), @slmua)
print 'Tong tien da mua la: ' + convert(nvarchar(10), @tongtien)
--11.Tạo thủ tục có đầu vào là mã khách hàng, năm, đầu ra là số lượng hóa đơn đã mua và số
--lượng tiền tiêu dùng của khách hàng đó trong năm đó.

-----------------------------HÀM---------------------------------------------
--1. Tạo hàm đưa ra tổng số tiền đã nhập sách trong một năm với tham số đầu vào là năm
CREATE FUNCTION f_TongTienNhapSachTrongNam (@nam INT)
RETURNS MONEY
AS
BEGIN
    DECLARE @tongTien MONEY
    SELECT @tongTien = SUM(tChiTietHDN.SLNhap * tSach.DonGiaNhap)
    FROM tChiTietHDN
	JOIN tSach ON  tSach.MaSach = tChiTietHDN.MaSach
    JOIN tHoaDonNhap  ON tChiTietHDN.SoHDN = tHoaDonNhap.SoHDN
    WHERE YEAR(tHoaDonNhap.NgayNhap) = @nam
    RETURN @tongTien
END
SELECT dbo.f_TongTienNhapSachTrongNam('2014')
--2. Tạo hàm đưa ra danh sách 5 đầu sách bán chạy nhất trong tháng nào đó (tháng là tham số đầu vào)
CREATE FUNCTION f_DanhSachSachBanChayTrongThang (@thang INT)
RETURNS @sachBanChay TABLE (
    MaSach NVARCHAR(10),
    TenSach NVARCHAR(200),
    SoLuongBan INT
)
AS
BEGIN
    INSERT INTO @sachBanChay
    SELECT TOP 5 cthdb.MaSach, s.TenSach, SUM(cthdb.SLBan) AS SoLuongBan
    FROM tChiTietHDB cthdb
    JOIN tHoaDonBan hdb ON cthdb.SoHDB = hdb.SoHDB
    JOIN tSach s ON cthdb.MaSach = s.MaSach
    WHERE MONTH(hdb.NgayBan) = @thang
    GROUP BY cthdb.MaSach, s.TenSach
    ORDER BY SoLuongBan DESC
    RETURN
END

select 
--3. Tạo hàm đưa ra danh sách n nhân viên có doanh thu cao nhất trong một năm với n và năm là tham số đầu vào
CREATE FUNCTION f_DanhSachNhanVienDoanhThuCaoTrongNam (@nam INT, @n INT)
RETURNS @nhanVienDoanhThuCao TABLE (
    MaNV NVARCHAR(10),
    TenNV NVARCHAR(50),
    DoanhThu MONEY
)
AS
BEGIN
    INSERT INTO @nhanVienDoanhThuCao
    SELECT TOP (@n) nv.MaNV, nv.TenNV, SUM(cthdb.SLBan * cthdb.DonGiaBan) AS DoanhThu
    FROM tChiTietHDB cthdb
    JOIN tHoaDonBan hdb ON cthdb.SoHDB = hdb.SoHDB
    JOIN tNhanVien nv ON hdb.MaNV = nv.MaNV
    WHERE YEAR(hdb.NgayBan) = @nam
    GROUP BY nv.MaNV, nv.TenNV
    ORDER BY DoanhThu DESC
    RETURN
END

--4. Tạo hàm đưa ra thông tin Nhân viên sinh nhật trong ngày là tham số nhập vào
CREATE FUNCTION f_ThongTinNhanVienSinhNhatTrongNgay (@ngay DATETIME)
RETURNS @nhanVienSinhNhat TABLE (
    MaNV NVARCHAR(10),
    TenNV NVARCHAR(50),
    NgaySinh DATETIME,
    DiaChi NVARCHAR(150),
    DienThoai NVARCHAR(15),
    GioiTinh NVARCHAR(5)
)
AS
BEGIN
    INSERT INTO @nhanVienSinhNhat
    SELECT MaNV, TenNV, NgaySinh, DiaChi, DienThoai, GioiTinh
    FROM tNhanVien
    WHERE DAY(NgaySinh) = DAY(@ngay) AND MONTH(NgaySinh) = MONTH(@ngay)
    RETURN
END
SELECT * FROM f_ThongTinNhanVienSinhNhatTrongNgay('1990-09-11')
--5. Tạo hàm đưa ra danh sách tồn trong kho quá 2 năm (nhập nhưng không bán hết trong hai năm)
CREATE FUNCTION f_DanhSachSachTonTrongKhoQua2Nam ()
RETURNS @sachTon TABLE (
    MaSach NVARCHAR(10),
    TenSach NVARCHAR(200),
    SoLuongNhap INT,
    SoLuongBan INT,
    SoLuongTon INT
)
AS
BEGIN
    INSERT INTO @sachTon
    SELECT s.MaSach, s.TenSach, SUM(cthdn.SLNhap) AS SoLuongNhap, SUM(cthdb.SLBan) AS SoLuongBan, SUM(cthdn.SLNhap) - SUM(cthdb.SLBan) AS SoLuongTon
    FROM tSach s
    LEFT JOIN tChiTietHDN cthdn ON s.MaSach = cthdn.MaSach
    LEFT JOIN tChiTietHDB cthdb ON s.MaSach = cthdb.MaSach
	LEFT JOIN tHoaDonNhap on cthdn.SoHDN = tHoaDonNhap.SoHDN
    WHERE YEAR(tHoaDonNhap.NgayNhap) <= YEAR(GETDATE()) - 2 OR tHoaDonNhap.NgayNhap IS NULL
    GROUP BY s.MaSach, s.TenSach
    HAVING SUM(cthdn.SLNhap) - SUM(cthdb.SLBan) > 0
    RETURN
END

select *from f_DanhSachSachTonTrongKhoQua2Nam()
--6. Tạo hàm với đầu vào là ngày, đầu ra là thông tin các hóa đơn và trị giá của hóa đơn trong ngày đó

--7. Tạo hàm có đầu vào là năm đầu ra là thống kê doanh thu theo từng tháng và cả năm (dùng roll up)
--create function cau7(@nam int) returns table as return
--(select year(ngayban) nam,month(ngayban) thang, sum(slban*dongiaban) as doanhthu from tHoaDonBan join tChiTietHDB on tChiTietHDB.SoHDB=tHoaDonBan.SoHDB join tsach on tSach.MaSach=tChiTietHDB.MaSach 
--where YEAR(ngayban)=@nam group by YEAR(ngayban),
-- rollup( month(ngayban)))
-- drop function cau7
--select * from cau7('2019')
CREATE FUNCTION f_ThongKeDoanhThuTheoThangVaNam (@nam INT)
RETURNS @thongKeDoanhThu TABLE (
Thang INT,
DoanhThu MONEY
)
AS
BEGIN
INSERT INTO @thongKeDoanhThu
SELECT MONTH(NgayBan) AS Thang, SUM(SLBan * DonGiaBan) AS DoanhThu
FROM tChiTietHDB cthdb
JOIN tHoaDonBan hdb ON cthdb.SoHDB = hdb.SoHDB
JOIN tSach  on cthdb.MaSach = tSach.MaSach
WHERE YEAR(NgayBan) = @nam
GROUP BY MONTH(NgayBan) WITH ROLLUP
RETURN
END
SELECT *FROM f_ThongKeDoanhThuTheoThangVaNam('2014')
--8. Tạo hàm có đầu vào là sách, đầu ra là số lượng tồn của sách
create FUNCTION f_SoLuongTonCua(@maSach NVARCHAR(10))
RETURNS int
AS
BEGIN
DECLARE @soLuongNhap INT
DECLARE @soLuongBan INT

SELECT @soLuongNhap = SUM(SLNhap) , @soLuongBan = SUM(SLBan) FROM tChiTietHDB join tSach on tChiTietHDB.MaSach = tSach.MaSach 
join tChiTietHDN on tSach.MaSach = tChiTietHDN.MaSach
WHERE tSach.MaSach = @maSach 
RETURN @soLuongNhap - @soLuongBan
END
drop function f_SoLuongTonCua
SELECT   dbo.f_SoLuongTonCua(N'S01')

--9. Tạo hàm có đầu vào là mã loại, đầu ra là thông tin sách, số lượng sách nhập, số lượng sách bán của mỗi sách thuộc mã  đó

CREATE FUNCTION f_ThongTinSachNhapBanTheoMaLoai (@maLoai NVARCHAR(10))
RETURNS @thongTinSachNhapBan TABLE (
MaSach NVARCHAR(10),
TenSach NVARCHAR(200),
SoLuongNhap INT,
SoLuongBan INT
)
AS
BEGIN
INSERT INTO @thongTinSachNhapBan
SELECT s.MaSach, s.TenSach, SUM(cthdn.SLNhap) AS SoLuongNhap, SUM(cthdb.SLBan) AS SoLuongBan
FROM tSach s
LEFT JOIN tChiTietHDN cthdn ON s.MaSach = cthdn.MaSach
LEFT JOIN tChiTietHDB cthdb ON s.MaSach = cthdb.MaSach
WHERE s.MaSach = @maLoai
GROUP BY s.MaSach, s.TenSach
RETURN
END

SELECT * FROM f_ThongTinSachNhapBanTheoMaLoai('S01')
SELECT * FROM f_ThongTinSachNhapBanTheoMaLoai('S02')

------------------------------TRIGGER-------------------------------------
--1. Tạo trường thành tiền (ThanhTien) cho bảng tChitietHDB, tạo trigger cập nhật tự động
--cho trường này biết ThanhTien=SLBan*DonGiaBan

alter table [dbo].[tChiTietHDB]
add ThanhTien money null 
drop trigger ThanhTien
Create trigger ThanhTien on [dbo].[tChiTietHDB]
for insert, update as
begin 
declare @sohdb nvarchar(10), @dongia money, @thanhtien
money, @masach nvarchar(10)
select @sohdb = sohdb , @masach = masach from inserted
select @dongia = dongiaban from tsach where MaSach = @masach
update tChiTietHDB set ThanhTien= SLBan * @dongia where
sohdb=@sohdb and Masach = @masach
end
insert into tChiTietHDB(SoHDB, MaSach, SLBan) values
('HDB01', 'S03', 10)
insert into tChiTietHDB(SoHDB, MaSach, SLBan) values
('HDB01', 'SO5', 10)
--2. Thêm trường đơn giá (DonGia) cho bảng chi tiết hóa đơn bán, cập nhật dữ liệu cho trường
--này mỗi khi thêm, sửa bản ghi vào bảng chi tiết hóa đơn bán.
alter table tChiTietHDB 
add DonGia Money;

create trigger updateDonGia
on tChiTietHDB for insert, update
as
begin
	update tChiTietHDB
	set tChiTietHDB.DonGia = sach.DonGiaBan
	from tChiTietHDB cthdb join tSach sach on cthdb.MaSach = sach.MaSach
	join inserted i on cthdb.MaSach = i.MaSach 
	where cthdb.SoHDB = i.SoHDB
end
----------------------------------------------------------------------
alter table tChiTietHDB
add TongTien money;

create trigger TongTien on tChiTietHDB
for insert as 
begin 
	declare @sohdb nvarchar(10), @masach nvarchar(10), @dongia money , @slban int
	select @sohdb = SoHDB, @masach = Masach , @slban = SLBan from inserted
	select @dongia = dongiaban from tSach where MaSach = @masach

	update tChiTietHDB set TongTien = ISNULL(TongTien,0) + @slban*@dongia where SoHDB = @sohdb
end
insert into tHoaDonBan values('HDB14','NV01','2021-10-11','KH01',NULL)
insert into tChiTietHDB values('HDB14','S01',2,NULL,NULL)
insert into tChiTietHDB values('HDB14','S02',1,NULL,NULL)
--3. Thêm trường số lượng hóa đơn vào bảng khách hàng và cập nhật tự động cho trường này mỗi khi thêm hóa đơn
alter table tKhachHang
add SLHD int;
create trigger updateHoaDon
on tKhachHang for insert, update
as
begin 
	UPDATE tKhachHang
SET SLHD = (
		SELECT COUNT(SLBan)
		FROM tChiTietHDB
		INNER JOIN inserted ON tChiTietHDB.SoHDB = inserted.SoHDB
		WHERE tKhachHang.MaKH = inserted.MaKH
	)
	FROM tKhachHang
	INNER JOIN inserted ON tKhachHang.MaKH = inserted.MaKH
END

--4. Thêm trường số sản phẩm vào bảng hóa đơn bán, cập nhật tự động cho trường này mỗi khi thêm chi tiết hóa đơn
alter table tHoaDonBan
add SoSanPham int ;

create trigger trig_cau4
on tHoaDonBan for insert , update
as begin
	declare @sohd nvarchar(50), @slg int
	select @sohd= SoHDB from inserted
	select @slg = count(MaSach)
	from tChiTietHDB where @sohd = SoHDB

	update tHoaDonBan 
	set SoSanPham= @slg where SoHDB = @sohd
end

INSERT [dbo].[tChiTietHDB] ([SoHDB], [MaSach], [SLBan], [KhuyenMai]) VALUES (N'HDB01', N'S05', 9, NULL)
select distinct *from tChiTietHDB where SoHDB = N'HDB01'
select * from tHoaDonBan where SoHDB = N'HDB01'
--5.Thêm trường số sản phẩm vào bảng hóa đơn bán, cập nhật tự động cho trường này mỗi khi xóa chi tiết hóa đơn


--6.Thêm trường số sản phẩm vào bảng hóa đơn bán, cập nhật tự động cho trường này mỗi khi thêm, sửa, xóa chi tiết hóa đơn


--7. Thêm trường tổng tiền cho hóa đơn bán, cập nhật tự động cho trường này mỗi khi thêm chi tiết hóa đơn

--8. Thêm trường số lượng hóa đơn vào bảng khách hàng và cập nhật tự động cho trường này mỗi khi thêm, sửa, xóa hóa đơn
alter table tKhachHang
add SoLuongHoaDon int 
Update tKhachHang set SoLuongHoaDon = 0 

create or alter trigger trig_cau8 on tHoaDonBan
after insert, update, delete 
as begin 
	update tKhachHang
	set SoLuongHoaDon = SoLuongHoaDon + 1
	where tKhachHang.MaKH in (Select MaKH from inserted)

	update tKhachHang
	set SoLuongHoaDon = SoLuongHoaDon - 1
	where tKhachHang.MaKH in (Select MaKH from deleted)
	end

select *from tKhachHang where MaKH='KH04' or MaKH = 'KH01'

--9. Thêm trường số sản phẩm vào bảng hóa đơn bán, cập nhật tự động cho trường này mỗi khi thêm, xóa, sửa chi tiết hóa đơn

--10. Thêm trường tổng tiền cho hóa đơn bán, cập nhật tự động cho trường này mỗi khi thêm, xóa, sửa chi tiết hóa đơn

--11. Số lượng trong bảng Sách là số lượng tồn kho, cập nhật tự động dữ liệu cho trường này mỗi khi nhập hay bán sách
create or alter trigger CapnhatSLN on tChiTietHDN
for insert, update as
begin	
	declare @Sln int , @SlNCu int, @Masach1 nvarchar(10),@Masach2 nvarchar(10)
	select @Sln = SLNhap , @MaSach1 = MaSach from inserted
	select @SlNCu = SLNhap, @MaSach2 = MaSach from deleted
	update tSach set SoLuong = SoLuong + ( ISNULL(@Sln,0) + isnull(@SlNCu,0))
	where MaSach = isnull( @MaSach1, @MaSach2)
end
create or alter trigger CapnhatSLB on tChiTietHDB
for insert, update as
begin
	declare @Slb int , @SlBCu int , @Masach1 nvarchar(10), @Masach2 nvarchar(10)
	select @Slb = SLBan , @Masach1 = MaSach from inserted
	select @SlBCu = SLBan , @Masach2 = MaSach from deleted
	update tSach set SoLuong = SoLuong - (isnull(@Slb,0) - ISNULL(@SlBCu,0))
	where MaSach = ISNULL(@Masach1, @Masach2)
end

select *from tChiTietHDN
select *from tSach where MaSach='S05'
insert into tChiTietHDN values('HDN01','S05',10,NULL)
insert into tChiTietHDB values('HDB09','S05',5,null,null)
--12. Thêm trường Tổng tiền tiêu dùng cho bảng khách hàng, cập nhật thông tin cho trường này.
alter table tKhachHang
add TongTien money
create trigger updateTongtien
on tChiTietHDB for insert, update 
as begin 
	update tKhachHang
	set TongTien = (
	select sum(tChiTietHDB.SLBan * tSach.DonGiaBan)
	from tChiTietHDB
	inner join tHoaDonBan on tChiTietHDB.SoHDB= tChiTietHDB.SoHDB
	join tSach on tChiTietHDB.MaSach = tSach.MaSach
	where tKhachHang.MaKH = tHoaDonBan.MaKH
	)
	from tKhachHang
	inner join inserted ON tKhachHang.MaKH = inserted.MaKH
END

--13. Thêm trường Số đầu sách cho bảng nhà cung cấp, cập nhật tự động số đầu sách nhà cung cấp cung cấp cho cửa hàng
alter table tNhaCungCap
add SoDauSach int
create trigger updateDauSach
on tNhaCungCap for insert, update
as begin
	update tNhaCungCap
	set SoDauSach = (
	select sum(SLNhap-SLBan)
	from tChiTietHDN
	join tSach on tChiTietHDN.MaSach = tSach.MaSach
	join tChiTietHDB on tChiTietHDB.MaSach= tSach.MaSach
	)
	from tNhaCungCap
	join inserted on tNhaCungCap.MaNCC = inserted.MaNCC
end

--14. Thêm trường Số lượng sách và Tổng tiền hàng vào bảng nhà cung cấp, cập nhật dữ liệu
--cho trường này mỗi khi nhập hàng.
alter table tNhaCungCap
add slgsach int,
	tongtienhang money;
create trigger updateCau14
on tNhaCungCap for insert, update
as begin
	update tNhaCungCap
	set slgsach = (
	select sum(SLNhap)
	from tChiTietHDN
	),
	tongtienhang = (
	select sum(tSach.DonGiaNhap * tChiTietHDN.SLNhap)
	from tSach
	join tChiTietHDN on tSach.MaSach = tChiTietHDN.MaSach
	)
	from tNhaCungCap
	join inserted on inserted.MaNCC = tNhaCungCap.MaNCC
end

--15.Tạo trigger trên bảng thoadonban thực hiện xóa các chi tiết hóa đơn mỗi khi xóa hóa đơn

