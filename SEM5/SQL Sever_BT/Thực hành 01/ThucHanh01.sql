USE QLDuThi
--1. Tạo view KET QUA chứa kết quả thi của từng học sinh bao gồm các thông tin:
--SoBD, HoTen, Phai, Tuoi, Toan, Van, AnhVan, TongDiem, XepLoai, DTDuThi
--Biết rằng: TongDiem = Toan + Van + AnhVan + DiemUT
--XepLoai học sinh như sau:
--* Giỏi nếu TongDiem>=24 và tất cả các môn >=7
--* Khá nếu TongDiem>=21 và tất cả các môn >=6
--* Trung Bình nếu TongDiem>=15 và tất cả các môn >=4
--* Trượt nếu ngược lại
create view KETQUA as
select 
	ds.SoBD, ds.Ho +' '+ ds.Ten as HoTen, ds.Phai,
	datediff(year,ds.NTNS, getdate()) as Tuoi,
	dt.Toan,dt.Van, dt.AnhVan, 
	dt.Toan + dt.Van + dt.AnhVan + isnull(ctdt.DiemUT,0) as TongDiem,
case 
	when dt.Toan + dt.Van + dt.AnhVan + isnull(ctdt.DiemUT,0) >=24 
	and dt.Toan >=7 and dt.Van >=7 and dt.AnhVan >=7 
	then N'Giỏi'

	when dt.Toan + dt.Van + dt.AnhVan + isnull(ctdt.DiemUT,0) >=21 
	and dt.Toan >=6 and dt.Van >=6 and dt.AnhVan >=6 
	then N'Khá'

	when dt.Toan + dt.Van + dt.AnhVan + isnull(ctdt.DiemUT,0) >=15 
	and dt.Toan >=4 and dt.Van >=4 and dt.AnhVan >=4 
	then N'Trung Bình'
end as XepLoai,
ds.DTDuThi
from DanhSach ds
inner join DiemThi dt on ds.SoBD = dt.SoBD
left join ChiTietDT ctdt on ds.DTDuThi = ctdt.DTDuThi

select *from KETQUA
--2. Tạo view GIOI TOAN – VAN – ANH VAN bao gồm các học sinh có ít nhất 1
--môn 10 và có TongDiem>=25 bao gồm các thông tin: SoBD, HoTen, Toan, Van,
--AnhVan, TongDiem, DienGiaiDT
create view Gioi_Toan_Van_AnhVan 
as 
select ds.SoBD, ds.Ho+ ' '+ds.Ten as Hoten, dt.Toan, dt.Van, dt.AnhVan,
dt.Toan + dt.Van + dt.AnhVan + isnull(ctdt.DiemUT,0) as TongDiem ,
ctdt.DienGiaiDT
from DanhSach ds 
inner join DiemThi dt on ds.SoBD = dt.SoBD
join ChiTietDT ctdt on ds.DTDuThi = ctdt.DTDuThi
where (dt.Toan =10 or dt.Van = 10 or dt.AnhVan = 10)
	and (dt.Toan + dt.Van + dt.AnhVan + isnull(ctdt.DiemUT,0) )>=25

select *from Gioi_Toan_Van_AnhVan
--3. Tạo view DANH SACH DAU (ĐẬU) gồm các học sinh có XepLoai là Giỏi, Khá
--hoặc Trung Bình với các field: SoBD, HoTen, Phai, Tuoi, Toan, Van, AnhVan,
--TongDiem, XepLoai, DTDuThi
create view Danh_Sach_Dau
as
select kq.SoBD, kq.HoTen, kq.Phai, kq.Tuoi,
kq.Toan, kq.Van, kq.AnhVan,kq.TongDiem,kq.XepLoai,kq.DTDuThi
from KETQUA kq
where XepLoai in (N'Giỏi', N'Khá',N'Trung Bình')

select *from Danh_Sach_Dau

--4. Tạo view HOC SINH DAT THU KHOA KY THI bao gồm các học sinh “ĐẬU”
--có TongDiem lớn nhất với các field: SoBD, HoTen, Phai, Tuoi, Toan, Van, AnhVan,
--TongDiem, DienGiaiDT
create view Hoc_Sinh_Dat_Thu_Khoa_Ky_Thi
as
select top 1 with ties dsd.SoBD, dsd.HoTen, dsd.Phai, dsd.Tuoi, dsd.Toan, 
dsd.Van, dsd.AnhVan, dsd.TongDiem,ctdt.DienGiaiDT 
from Danh_Sach_Dau dsd join ChiTietDT ctdt on dsd.DTDuThi= ctdt.DTDuThi
order by TongDiem desc

select *from Hoc_Sinh_Dat_Thu_Khoa_Ky_Thi
--5. Tạo thủ tục có đầu vào là số báo danh, đầu ra là các điểm thi, điểm ưu tiên và tổng điểm
create procedure pro_cau5 
(
	@sbd int,
	@toan float output, @van float output, @anhvan float output, @diemUT float output,
	@tongdiem float output
)
as
begin 
	select @sbd = ds.SoBD, @toan = dt.Toan , @van = dt.Van, @anhvan = dt.AnhVan,
	@diemUT = ct.DiemUT,
	@tongdiem = (dt.Toan + dt.Van + dt.AnhVan + isnull(ct.DiemUT,0)) 
	from DanhSach ds
	join DiemThi dt on ds.SoBD = dt.SoBD
	join ChiTietDT ct on ds.DTDuThi = ct.DTDuThi
	where ds.SoBD = @sbd
end
-------------
declare @sbd int , @toan float, @van float, @anhvan float, @diemUT float, @tongdiem float
exec pro_cau5 @sbd = '2' , @toan = @toan output, @van=@van output, @anhvan = @anhvan output,@diemUT = @diemUT output,@tongdiem = @tongdiem output
print 'diem Toan: ' + convert(nvarchar(5),@toan)
print 'diem Van: '   + convert(nvarchar(5),@van)
print 'diem Anh Van: ' + convert(nvarchar(5),@anhvan)
print 'diem uu tien: '  + convert(nvarchar(5),@diemUT)
print 'Tong diem: '  + convert(nvarchar(5),@tongdiem)
--6. Tạo trigger kiểm tra xem việc nhập mã đối tượng dự thi trong bảng danh sách có đúng với bảng đối tượng dự thi không
create trigger Kiem_Tra_Doi_Tuong_Du_Thi 
on DanhSach
for insert, update 
AS begin
 -- Kiểm tra xem mã đối tượng dự thi trong DanhSach có tồn tại trong ChiTietDT hay không
 IF EXISTS (select 1 from inserted i
                left join ChiTietDT d on i.DTDuThi = d.DTDuThi
                where d.DTDuThi IS NULL)
    begin
	-- Nếu không tồn tại, gửi một thông báo lỗi và hủy bỏ thao tác chèn
        RAISERROR('Mã đối tượng dự thi không hợp lệ', 16, 1)
        ROLLBACK TRANSACTION
    end
end
INSERT [dbo].[DanhSach] ([SoBD], [Ho], [Ten], [Phai], [NTNS], [DTDuThi]) 
VALUES (1, N'Nguyen Viet', N'Hong', 0, CAST(N'1981-04-04T00:00:00.000' AS DateTime), 4)
--7. Thêm trường điểm ưu tiên và tổng điểm vào bảng Điểm thi. Tạo trigger cập nhật
--tự động trường ưu tiên và tổng điểm mỗi khi nhập hay chỉnh sửa
alter table DiemThi
add DiemUT int, TongDiem real;

create trigger Cap_Nhat_Diem
on DiemThi
for insert, update
as
begin 
	--Cập nhật diemUT va TongDiem
	declare @sbd int , @diemUT int, @toan real, @van real, @anhvan real, @dt tinyint
	select @sbd = SoBD ,@toan = isnull(inserted.Toan,0),
	@van= isnull(inserted.Van,0),@anhvan= isnull(inserted.AnhVan,0) from inserted
	select @dt= DTDuThi from DanhSach where DanhSach.SoBD = @sbd
	select @diemut = DiemUT  from ChiTietDT where ChiTietDT.DTDuThi = @dt
	update DiemThi 
	set TongDiem = @toan+@van+@anhvan+isnull(@diemUT,0) where SoBD = @sbd
end
select *from DiemThi
update DiemThi set AnhVan = 6 where SoBD= 2
--8. Tạo trigger xóa tự động bản ghi tương ứng ở bảng điểm khi xóa bản ghi ở danh sách
create trigger Xoa_Tu_Dong
on DanhSach
for delete as
BEGIN
	declare @sbd int
	select @sbd = SoBD from deleted
	delete from DiemThi where @sbd = SoBD
END
select * from DiemThi where SoBD = 1
Delete DanhSach where SoBD = 1
select * from DiemThi where SoBD = 1
INSERT [dbo].[DanhSach] ([SoBD], [Ho], [Ten], [Phai], [NTNS], [DTDuThi]) 
VALUES (1, N'Nguyen Viet', N'Hong', 0, CAST(N'1981-04-04T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[DiemThi] ([SoBD], [Toan], [Van], [AnhVan]) VALUES (1, 8, 5, 8)