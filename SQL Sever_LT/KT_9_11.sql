USE BT1CSDL

--Cau 1 : Tạo hàm với đầu vào là MaNV, đâu ra là thông tin các hoá đơn và trị giá của hoá đơn mà NV đó xử lí
Create or alter function Test5_cau1 
(	@maNV nvarchar(10))
returns table
as 
return
	select tNhanVien.MaNV ,tNhanVien.TenNV, tHoaDonBan.SoHDB, sum( SlBan * DonGiaBan) as Tong
	from tNhanVien join tHoaDonBan on tNhanVien.MaNV = tHoaDonBan.MaNV
	join tChiTietHDB on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
	join tSach on tSach.MaSach = tChiTietHDB.MaSach
	where tNhanVien.MaNV = @maNV
	group by tNhanVien.MaNV, tNhanVien.TenNV, tHoaDonBan.SoHDB

select * from Test5_cau1(N'NV01')

--Cau 2: thêm trường số lượng sách Giáo Dục và Tổng tiền tiêu dùng sách GD vào bảng khách hàng, cập nhật dữ liệu 
-- cho trường này mỗi khi thêm sửa xoá chi tiết bán mà KH mua sách của NXB Giáo Dục

alter table tKhachHang
add SLSGiaoDuc int null;

alter table tKhachHang
add TongTienTieuDungSachGD	 money 

drop trigger Test05_Cau2

create or alter trigger Test05_Cau2
on tChiTietHDB
for insert, update,delete 
as begin
	update tKhachHang
	set SLSGiaoDuc = (
        SELECT SUM(inserted.SLBan)
        FROM inserted
        INNER JOIN tHoaDonBan ON inserted.SoHDB = tHoaDonBan.SoHDB
        INNER JOIN tSach ON inserted.MaSach = tSach.MaSach
        INNER JOIN tNhaXuatBan ON tSach.MaNXB = tNhaXuatBan.MaNXB
        WHERE tKhachHang.MaKH = tHoaDonBan.MaKH AND tNhaXuatBan.TenNXB = N'NXB Giáo Dục'
    ),
	TongTienTieuDungSachGD = (
        SELECT SUM(inserted.SLBan * tSach.DonGiaBan)
        FROM inserted
        INNER JOIN tHoaDonBan ON inserted.SoHDB = tHoaDonBan.SoHDB
        INNER JOIN tSach ON inserted.MaSach = tSach.MaSach
        INNER JOIN tNhaXuatBan ON tSach.MaNXB = tNhaXuatBan.MaNXB
        WHERE tKhachHang.MaKH = tHoaDonBan.MaKH AND tNhaXuatBan.TenNXB = N'NXB Giáo Dục'
    )
    FROM tKhachHang
    WHERE EXISTS (
        SELECT 1
        FROM inserted join tHoaDonBan on inserted.SoHDB = tHoaDonBan.SoHDB
		join tKhachHang on tHoaDonBan.MaKH =tKhachHang.MaKH
    
    ) OR EXISTS (
        SELECT 1
        FROM deleted join tHoaDonBan on deleted.SoHDB = tHoaDonBan.SoHDB
		join tKhachHang on tHoaDonBan.MaKH =tKhachHang.MaKH
    )
END

select * from tKhachHang	
update tChiTietHDB set SLBan = 3 where SoHDB = N'HDB01'
delete tChiTietHDB where SoHDB = N'HDB01'
INSERT [dbo].[tChiTietHDB] ([SoHDB], [MaSach], [SLBan], [KhuyenMai]) VALUES (N'HDB01', N'S01', 7, NULL)
INSERT [dbo].[tChiTietHDB] ([SoHDB], [MaSach], [SLBan], [KhuyenMai]) VALUES (N'HDB01', N'S02', 10, NULL)
INSERT [dbo].[tChiTietHDB] ([SoHDB], [MaSach], [SLBan], [KhuyenMai]) VALUES (N'HDB01', N'S04', 10, NULL)
select * from tChiTietHDB where SoHDB = N'HDB01'
--Cau 3 : Tạo thủ tục có đầu vào là tác giả, đầu ra là SL sách Nhập , SL sách bán của tác giả đó
create or alter procedure Test5_cau3
(	@tentacgia nvarchar(150), @slnhap int output, @slban int output)
as begin 
	select @slban = sum (SLBan)  
	from tSach join tChiTietHDB on tSach.MaSach = tChiTietHDB.MaSach
	where @tentacgia = TacGia  

	select @slnhap = sum (SLNhap)
	from tSach join   tChiTietHDN on tSach.MaSach = tChiTietHDN.MaSach
	where @tentacgia = TacGia  
end

declare @slnhap int , @slban int
exec Test5_cau3 N'Trần Đăng Khoa' , @slnhap = @slnhap output, @slban = @slban output
print @slnhap
print @slban
