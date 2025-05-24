USE ThucHanh_03
--V. Tạo TRIGGER
--1. Kiểm soát giới tính của nhân viên chỉ được nhập giá trị là ‘Nam’ hoặc ‘Nữ’
Create trigger trig_cau1
on NHANVIEN
for insert,update 
as begin
	if exists ( select * from inserted 
				where [Gioi Tinh] not in (N'Nam',N'Nữ'))
	begin
		raiserror ('Giới tính của nhân viên chỉ đc nhập Nam hoặc Nữ',16,1)
		rollback transaction
	end
end

EXEC sp_helptrigger 'NHANVIEN'

--2. Kiểm soát ngày vào làm (NgayLV) của nhân viên phải sau ngày sinh và đảm bảo nhân viên trên 18 tuổi
create trigger trig_cau2
on NHANVIEN
for insert,update
as begin
	if exists (
	select *from inserted where  datediff(year, [NgaySinh], [NgayLV]) < 18)
	begin
		raiserror('Ngày vào làm phải sau ngày sinh và nhân viên phải từ 18 tuổi trở lên',16,1)
		rollback transaction
	end
end

EXEC sp_helptrigger 'NHANVIEN'
--3. Thêm trường Đơn vị tính vào bảng Hàng hóa. Kiểm soát đơn vị tính khi nhập
--hàng hóa chỉ được chứa từ “Cái”, “Hộp”, “Thùng”, “Kg”, “Chiếc”
alter table [dbo].[HANGHOA]
add DonViTinh nvarchar(20);

create trigger trig_cau3
on HANGHOA
after insert, update
as begin
	if exists (
		select * from inserted i 
		where i.DonViTinh not in (N'Cái', N'Hộp', N'Thùng', 'Kg', N'Chiếc')
		)
		begin 
			raiserror('Đơn vị tính của hàng hóa chỉ được chứa từ "Cái", "Hộp", "Thùng", "Kg", "Chiếc".', 16, 1)
			rollback transaction
		end
end

EXEC sp_helptrigger 'HANGHOA'

--4. Tạo trigger cập nhật tự động giá của bảng hàng hóa sang bảng chi tiết hóa đơn
--mỗi khi thêm mới bản ghi
alter table CT_HOADON
add GiaBan money;
create trigger trig_cau4
on CT_HOADON
after insert
as begin
	declare @mahdb nvarchar(50), @mahh nvarchar(50), @giaban float
	select @mahdb = inserted.MaHD, @mahh= MaHH from inserted
	select @giaban = GiaBan from HANGHOA
	where HANGHOA.MaHH= @mahh
	update CT_HOADON 
	set GiaBan = @giaban
	where MaHD = @mahdb and MaHH = @mahh
end;
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'0001', N'0002', 7)
select * from CT_HoaDon


--5. Thêm trường ChietKhau vào bảng CT_Hoadon và cập nhật tự động trường này
--bằng 15% giá bán
alter table [dbo].[CT_HOADON]
add ChietKhau float;

create or alter trigger trig_cau5
on CT_HOADON
after insert
as begin
	update CT_HOADON
	set ChietKhau = 0.15 * h.GiaBan
	from CT_HOADON cthd
	inner join HANGHOA h on cthd.MaHH = h.MaHH
	inner join inserted i on cthd.MaHD = i.MaHD
	where i.MaHH = h.MaHH and cthd.MaHD = i.MaHD
end
--delete from CT_HOADON where MaHD = '0001' and MaHH='0002' AND SL = 7 
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'0001', N'0002', 7)

select MaHD,CT_HOADON.MaHH,HangHoa.GiaBan,ChietKhau
from CT_HOADON join HangHoa on CT_HOADON.MaHH = HANGHOA.MaHH 
where MaHD= '0001'

--6. Thêm Trường ThanhTien và cập nhật tự động cho trường này
alter table CT_HOADON
add ThanhTien money;

create or alter trigger trig_cau6
on CT_HOADON 
for insert, update
as begin
	update CT_HOADON
	set ThanhTien = i.SL * h.GiaBan - isnull(i.ChietKhau,0)
	FROM CT_HOADON
    INNER JOIN HANGHOA h ON CT_HOADON.MaHH = H.MaHH
    INNER JOIN inserted i  ON CT_HOADON.MaHD = I.MaHD
	where h.MaHH = i.MaHH and i.MaHD = CT_HOADON.MaHD
end;
INSERT [dbo].[CT_HOADON] ([MaHD], [MaHH], [SL]) VALUES (N'0001', N'0001', 3)
select * from CT_HOADON 

--7. Cập nhật lại giá của bảng hàng hóa sang bảng chi tiết hóa đơn


--VI. Tạo FUNCTION
--1. Tạo hàm lấy danh sách nhân viên theo quê quán
create or alter function f_cau1( @quequan nvarchar(50))
returns table
as
return (
	select * from NHANVIEN
	where lower(trim(right(QueQuan, CHARINDEX('-', REVERSE(QueQuan))-1))) = @quequan
);


select * from f_cau1(N'Hà Nội')
--2. Tạo hàm lấy danh sách hóa đơn theo nhân viên và ngày (ngày/tháng/năm)
create function f_cau2
(	@maNV nvarchar(20), @ngay date)
returns table
as
return (
	select *from HOADON
	where MaNV=@maNV and convert(date,NgayLap) = @ngay
);

select *from f_cau2 (N'0004',N'2015-04-02')
--3. Tạo hàm tính tổng tiền của từng hóa đơn với mã hóa đơn là tham số đầu vào
create function f_cau3 (@maHD nvarchar(50))
returns @tongtien table
(	SL int , GiaBan float, doanhthu money )
as
begin
	insert into @tongtien
	select cthd.SL, hh.GiaBan, sum(cthd.SL*hh.GiaBan) as doanhthu
	from CT_HOADON cthd join HANGHOA hh
	on cthd.MaHH = hh.MaHH
	where cthd.MaHD = @maHD
	group by SL,GiaBan 
	return 
end

select *from f_cau3(N'0001')

create function f_cau3_C2 (@maHD nvarchar(50))
returns @tongtien table
( doanhthu money )
as
begin
	insert into @tongtien
	select sum(cthd.SL*hh.GiaBan) as doanhthu
	from CT_HOADON cthd join HANGHOA hh
	on cthd.MaHH = hh.MaHH
	where cthd.MaHD = @maHD
	return 
end
select *from f_cau3_C2(N'0001')
--4. Tạo hàm lấy danh sách nhà cung cấp theo mã hàng
create function f_cau4(@maHH nvarchar(20))
returns table
as return (
	select ncc.* from NHACUNGCAP ncc 
	join PHIEUNHAP pn on ncc.MaNCC = pn.MaNCC 
	join CT_PHIEUNHAP ctpn on pn.MaPN = ctpn.MaPN
	where @maHH =ctpn.MaHH
);

select * from f_cau4(N'0003')
	

--5. Tạo hàm lấy danh sách các mặt hàng theo mã nhà cung cấp
create function f_cau5 (@maNCC nvarchar(20))
returns table 
as return (
	select HANGHOA.* from HANGHOA 
	join CT_PHIEUNHAP ctpn on ctpn.MaHH = HANGHOA.MaHH
	join PHIEUNHAP pn on ctpn.MaPN = pn.MaPN
	join NHACUNGCAP ncc on ncc.MaNCC= pn.MaNCC
	where @maNCC = ncc.MaNCC
);

select *from f_cau5(N'0001')

--6.Tạo hàm cho danh sách các khách hàng ở một quận nào đó
create or alter function f_cau6(
	@quan nvarchar(50)
)
returns table as return
(
	select * from KhachHang where lower(DiaChi) like '%' + @quan+'%'
)
select * from f_cau6(N'cầu giấy')