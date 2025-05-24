USE QLKhachSan
--Câu 1: Tạo thủ tục có đầu vào là mã khách hàng, năm, đầu ra là số lượng hóa đơn
--của mã mã khách hàng trong năm đó (năm được tính dựa trên ngày thanh toán).
create or alter procedure TH5_cau1 
(	@makh nvarchar(10) , @nam int , @slghd int output )
as 
begin 
	select @slghd = count(MaHDTT)
	from KHACHHANG kh join PHIEUDAT pd on kh.MaKH = pd.MaKH
	left join HOADONTT hdtt on pd.MaBooking = hdtt.MaBooking
	where @makh = kh.MaKH and @nam= year(hdtt.NgayTT)
end;

declare @slghd int 
exec TH5_cau1 N'KH0001', 2022, @slghd output
print N'Số lượng hoá đơn trong năm: '+  CAST(@slghd AS nvarchar(10));

--Câu 2: Tạo hàm có đầu vào là mã loại phòng, đầu ra là danh sách các thông tin chi
--tiết các phòng của mã loại phòng đó
create or alter function TH5_cau2 (@maLP nvarchar(10))
returns table
as return
	select LOAIPHONG.MaLP , Kieuphong, Dientich, Dongiaphong, Maphong
	from LOAIPHONG join PHONG on LOAIPHONG.MaLP = PHONG.MaLP
	where @maLP = LOAIPHONG.MaLP

select * from TH5_cau2 (N'Standard01')

--Câu 3: Thêm trường Số lượng phòng đặt vào bảng Phiếu đặt. Tạo Trigger cập nhật
--tự động cho trường này mỗi khi thêm, sửa, xóa một bản ghi ở bảng Chi tiết phòng đặt.
--Cau 3
alter table	PHIEUDAT
add SoLuongPhongDat int null
create or alter trigger TH5_cau3
on ChiTietPhongDat 
for insert, update, delete
as begin
	declare @ma1 [nvarchar](10), @ma2 [nvarchar](10), @sl int
	select @ma1 = inserted.MaBooking from inserted
	select @ma2 = deleted.MaBooking from deleted
	select @sl = sum(CHITIETPHONGDAT.SLPhong) 
	from CHITIETPHONGDAT
	where MaBooking = isnull(@ma1, @ma2)
	update PHIEUDAT set SoLuongPhongDat = @sl 
	where MaBooking = isnull(@ma1, @ma2)
end

select * from CHITIETPHONGDAT where MaBooking = N'PD0013'
select * from PHIEUDAT where MaBooking = N'PD0013'

INSERT [dbo].[CHITIETPHONGDAT] ([MaBooking], [SLPhong], [MaLP]) VALUES (N'PD0013', 2, N'Deluxe01')

delete from CHITIETPHONGDAT where MaBooking = N'PD0013'
select * from PHIEUDAT where MaBooking = N'PD0013'

--Câu 4: Tạo View gồm các thông tin mã nhân viên, tên nhân viên, mã HDTT, Ngày
--lập HD, Ngày thanh toán, phương thức thanh toán, mã booking, ngày đến dự kiến,
--ngày đi dự kiến có ngày đến dự kiến từ ngày 12/12/2022 đến ngày 19/12/2022
create or alter view TH5_cau4
as
	select NHANVIEN.MaNV, TenNV, MaHDTT, NgayLapHD, NgayTT, PhuongthucTT,
	HOADONTT.MaBooking, PHIEUDAT.NgayDenDukien,PHIEUDAT.NgayDiDuKien
	from NHANVIEN join HOADONTT on NHANVIEN.MaNV = HOADONTT.MaNV
	join PHIEUDAT on HOADONTT.MaBooking = PHIEUDAT.MaBooking
	where PHIEUDAT.NgayDenDukien between '2022-12-12' AND '2022-12-19'

select * from TH5_cau4

--Câu 5: Tạo login NguyenDucThuan, tạo user NguyenDucThuan cho login NguyenDucThuan trên CSDL đã cho.
CREATE LOGIN NguyenDucThuan WITH PASSWORD = '123'
CREATE USER NguyenDucThuan FOR LOGIN TranHuyHiep
--Phân quyền Select, Insert, update trên Bảng phiếu đặt cho NguyenDucThuan, và NguyenDucThuan được phép phân quyền cho người khác
GRANT SELECT, UPDATE, INSERT ON PHIEUDAT TO NguyenDucThuan  with grant option 
--Tạo login NguyenTienTai, tạo user NguyenTienTai cho login NguyenTienTai trên CSDL trên.
CREATE LOGIN NguyenTienTai WITH PASSWORD = '123'
CREATE USER NguyenTienTai FOR LOGIN NguyenTienTai
--Từ login NguyenDucThuan, phân quyền Select, update trên Bảng phiếu đặt cho NguyenTienTai.
GRANT SELECT, UPDATE ON PHIEUDAT TO NguyenTienTai

--Câu 6: Tạo thủ tục có đầu vào là năm bắt đầu, năm kết thúc, đầu ra là ba tháng trong
--năm có tổng doanh thu cao nhất (ví dụ từ năm 2020 đến năm 2022 thì tháng 6, 7, 8 là
--những tháng có doanh thu cao nhất, tháng lấy theo ngày thanh toán).
Create or alter procedure TH5_cau6
(	@namBD date , @namKT date , @thang int output	)
as
begin 
	select top 3 --MONTH(NgayTT) as Thang,
	MONTH (NgayTT) as Thang,
	SUM(
	(case 
	when datediff(day,Thoigiancheckin,Thoigiancheckout) = 0 then 1
	else datediff(day,Thoigiancheckin, Thoigiancheckout) end) 
	* SLPhong * (1 - KMPhong) *Dongiaphong) as TongDoanhThu
	from HOADONTT join PHIEUDAT on HOADONTT.MaBooking = PHIEUDAT.MaBooking
	join PHIEUTHUE on PHIEUDAT.MaBooking = PHIEUTHUE.MaBooking
	join CHITIETPHONGDAT on PHIEUDAT.MaBooking = CHITIETPHONGDAT.MaBooking
	join LOAIPHONG on CHITIETPHONGDAT.MaLP = LOAIPHONG.MaLP
	WHERE NgayTT BETWEEN @namBD AND @namKT
	GROUP BY MONTH(NgayTT)
    ORDER BY TongDoanhThu desc
end

declare @thang int 
exec TH5_cau6 '2020-01-01',  '2022-12-31', @thang output
print @thang

