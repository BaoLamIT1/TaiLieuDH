USE QLKhachSan_BTTuan

--1. Viết truy vấn tạo bảng doanh thu (tDoanhThu) gồm các trường
go
CREATE TABLE [dbo].[tDoanhThu](
	[MaDK] [nvarchar](3) NOT NULL,
	[LoaiPhong] [nvarchar](2) NULL,
	[SoNgayO] [int] NULL,
	[ThucThu] [bigint] NULL,
PRIMARY KEY CLUSTERED ([MaDK] ASC)) 
--2. Tạo Trigger tính tiền và điền tự động vào bảng tDoanhThu như sau:
--Các trường lấy thông tin từ các bảng và các thông tin sau:
--Trong đó:
--(a) Số Ngày Ở= Ngày Ra – Ngày Vào
--(b) ThucThu: Tính theo yêu cầu sau:
--Nếu Số Ngày ở <10 Thành tiền = Đơn Giá * Số ngày ở
--Nếu 10 <=Số Ngày ở <30 Thành Tiền = Đơn Giá* Số Ngày ở * 0.95 (Giảm5%)
--Nếu Số ngày ở >= 30 Thành Tiền = Đơn Giá* Số Ngày ở * 0.9 (Giảm10%)
CREATE OR ALTER TRIGGER trig_cau2
ON tDangKy
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @MaDK nvarchar(3), @NgayVao datetime, @NgayRa datetime , @SoNgayO int, 
	@DonGia int , @ThucThu bigint;

    SELECT @MaDK = i.MaDK, @NgayVao = i.NgayVao, @NgayRa = i.NgayRa, @DonGia = lp.DonGia
    FROM inserted i
    INNER JOIN tLoaiPhong lp ON i.LoaiPhong = lp.LoaiPhong;
    SET @SoNgayO = DATEDIFF(DAY, @NgayVao, @NgayRa);
    IF @SoNgayO < 10
        SET @ThucThu = @DonGia * @SoNgayO;
    ELSE IF @SoNgayO >= 10 AND @SoNgayO < 30
        SET @ThucThu = ROUND(@DonGia * @SoNgayO * 0.95, 0);
    ELSE
        SET @ThucThu = ROUND(@DonGia * @SoNgayO * 0.9, 0);
    IF EXISTS (SELECT 1 FROM tDoanhThu WHERE MaDK = @MaDK)
        UPDATE tDoanhThu SET ThucThu = @ThucThu WHERE MaDK = @MaDK;
    ELSE
        INSERT INTO tDoanhThu (MaDK, ThucThu) VALUES (@MaDK, @ThucThu);
END;
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) 
VALUES (N'016', N'601', N'A', CAST(N'2023-04-03T00:00:00.000' AS DateTime), CAST(N'2023-04-05T00:00:00.000' AS DateTime))
update tDangKy set NgayRa='2023-04-08' where MaDK='016' 
select * from tDoanhThu where MaDK='016' 

select * from tDoanhThu 
--3. Thêm trường DonGia vào bảng tDangKy, tạo trigger cập nhật tự động cho trường này.
alter table tDangKy
add  DonGia money null

create or alter trigger trig_cau3
on tLoaiPhong for insert, update, delete as 
begin 
update  tDangKy set tDangKy.DonGia = isnull(inserted.DonGia,0)
from tDangKy join inserted on inserted.LoaiPhong = tDangKy.LoaiPhong
where tDangKy.LoaiPhong = inserted.LoaiPhong
end

select * from tDangKy
select * from tLoaiPhong where LoaiPhong='C'
update tLoaiPhong set DonGia= 3000000 where LoaiPhong='C'
go
select * from tDangKy


	
--4. Thêm trường tổng tiêu dùng (TongTieuDung) và bảng khách hàng và tính tự động tổng
--tiền khách hàng đã trả cho khách sạn mỗi khi thêm, sửa, xóa bản tDangKy
alter table tKhachHang 
add TongTieuDung bigint null
create or alter trigger trig_cau4
on tDangKy
after insert, update, delete
as begin

	update tKhachHang set tKhachHang.TongTieuDung= A.tien
	from (select tChiTietKH.LoaiKH, sum(isnull(ThucThu,0)) as tien
	from inserted right join tDoanhThu 
	on tDoanhThu.MaDK = inserted.MaDK
	join tChiTietKH on tChiTietKH.MaDK = inserted.MaDK
	group by tChiTietKH.LoaiKH
	)A
	where tKhachHang.LoaiKH = A.LoaiKH
end
select * from tKhachHang
update tDangKy set NgayVao = '1998-04-20' where MaDK ='001'
select * from tKhachHang
