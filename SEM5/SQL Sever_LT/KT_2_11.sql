USE [BT1CSDL]

--Cau 1
Create or alter view sachGD
as 
	select tSach.MaSach , tSach.TenSach , TenTheLoai, SLNhap, SLBan ,  ( SLNhap - SLBan) as SLTon  
	from tSach join tTheLoai on tSach.MaTheLoai = tTheLoai.MaTheLoai
	left join tChiTietHDB on tSach.MaSach = tChiTietHDB.MaSach
	left join tChiTietHDN on tSach.MaSach = tChiTietHDN.MaSach
	join tNhaXuatBan on tSach.MaNXB = tNhaXuatBan.MaNXB
	where tNhaXuatBan.TenNXB = N'NXB Giáo Dục'

select *from sachGD 

-- Cau 2 
alter table tNhanVien
add SLSachBan int 

create or alter trigger trig_Test_c2
on tChiTietHDB
after insert, update, delete 
as begin 
	update tNhanVien
	set SLSachBan =  ( select sum(SLBan) from tChiTietHDB ) 
	where tNhanVien.MaNV in ( select MaNV from inserted);

	update tNhanVien
	set SLSachBan = ( select sum( SLBan )  from tChiTietHDB ) 
	where tNhanVien.MaNV in ( select MaNV from deleted)
end

INSERT [dbo].[tChiTietHDB] ([SoHDB], [MaSach], [SLBan], [KhuyenMai]) VALUES (N'HDB01', N'S01', 10, NULL)

select * from tNhanVien where MaNV = N'NV01' or MaNV =  N'NV02'


-- Cau 3
create procedure pro_test_c3
(	@maNXB nvarchar(10) , @slton int output )
as 
begin
	select @slton = Sum ( SLNhap -SLBan)
	from tSach join tChiTietHDB  on tSach.MaSach = tChiTietHDB.MaSach
	join tChiTietHDN on tSach.MaSach = tChiTietHDN.MaSach
	where @maNXB = tSach.MaNXB
end

declare @slton int
exec pro_test_c3 N'NXB01', @slton output
print 'So luong ton cua nha xuat ban do la : ' + convert ( nvarchar, @slton)