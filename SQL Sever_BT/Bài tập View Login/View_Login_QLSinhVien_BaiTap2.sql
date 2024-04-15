USE [BT1_TKCSDL]
--1. Tạo view DSHS10A1 gồm thông tin Mã học sinh, họ tên, giới tính (là “Nữ” nếu Nu=1,
--ngược lại là “Nam”), các điểm Toán, Lý, Hóa, Văn của các học sinh lớp 10A1
create view DSHS10A1 as
select DSHS.MAHS, DSHS.HO, DSHS.TEN, DIEM.TOAN, DIEM.LY, DIEM.HOA,DIEM.VAN,
	Case
		when DSHS.NU =1 then N'Nữ'
		else N'Nam'
	End as GioiTinh
from DSHS join DIEM on DSHS.MAHS = DIEM.MAHS
where DSHS.MALOP = N'10A1'

Select *from DSHS10A1

--2. Tạo login TranThanhPhong, tạo user TranThanhPhong cho TranThanhPhong trên CSDL QLHocSinh
Create login TranThanhPhong with password ='123'
Create user TranThanhPhong for login TranThanhPhong
--Phân quyền Select trên view DSHS10A1 cho TranThanhPhong
Grant select on DSHS10A1 to TranThanhPhong
--Đăng nhập TranThanhPhong để kiểm tra
--Tạo login PhamVanNam, tạo PhamVanNam cho PhamVanNam trên CSDL QLHocSinh
Create login PhamVanNam with password = '123'
Create user PhamVanNam for login PhamVanNam
--Đăng nhập PhamVanNam để kiểm tra
--Tạo view DSHS10A2 tương tự như câu 1
create view DSHS10A2 as
select DSHS.MAHS, DSHS.HO, DSHS.TEN, DIEM.TOAN, DIEM.LY, DIEM.HOA,DIEM.VAN,
	Case
		when DSHS.NU =1 then N'Nữ'
		else N'Nam'
	End as GioiTinh
from DSHS join DIEM on DSHS.MAHS = DIEM.MAHS
where DSHS.MALOP = N'10A1'

Select *from DSHS10A2
--Phân quyền Select trên view DSHS10A2 cho PhamVanNam
Grant select on DSHS10A2 to PhamVanNam
--Đăng nhập PhamVanNam để kiểm tra

--3. Tạo view báo cáo Kết thúc năm học gồm các thông tin: Mã học sinh, Họ và tên, Ngày sinh,
--Giới tính, Điểm Toán, Lý, Hóa, Văn, Điểm Trung bình, Xếp loại, Sắp xếp theo xếp loại (chọn
--1000 bản ghi đầu). Trong đó:
--Điểm trung bình (DTB) = ((Toán + Văn)*2 + Lý + Hóa)/6)
--Cách thức xếp loại như sau:
--- Xét điểm thấp nhất (DTN) của các 4 môn
--- Nếu DTB>5 và DTN>4 là “Lên Lớp”, ngược lại là lưu ban
Create view BaoCao as
select DSHS.MAHS, DSHS.HO, DSHS.TEN, DSHS.NGAYSINH, 
Case when DSHS.NU =1 then N'Nữ' else N'Nam'
End as GioiTinh,
DIEM.TOAN, DIEM.LY, DIEM.HOA, DIEM.VAN, 
((DIEM.TOAN + DIEM.VAN)*2 +DIEM.LY + DIEM.HOA)/6 as DTB, 
Case
	When LEAST ( DIEM.TOAN, DIEM.LY,DIEM.HOA,DIEM.VAN) >4  
	AND ((DIEM.TOAN + DIEM.VAN)*2 +DIEM.LY + DIEM.HOA)/6 >5 
	THEN N'Lên lớp'
	ELSE N'Lưu ban'
End as XepLoai
From DSHS join DIEM on DSHS.MAHS = DIEM.MAHS

Select *from BaoCao

--4. Tạo view danh sách HOC SINH XUAT SAC bao gồm các học sinh có DTB>=8.5 và
--DTN>=8 với các trường: Lop, Mahs, Hoten, Namsinh (năm sinh), Nu, Toan, Ly, Hoa, Van,
--DTN, DTB
Create view HocSinhXuatSac as
select DSHS.MALOP, BaoCao.MAHS, BaoCao.HO, BaoCao.TEN, year(BaoCao.NGAYSINH) as NamSinh, 
BaoCao.GioiTinh, BaoCao.TOAN, BaoCao.LY, BaoCao.HOA, BaoCao.VAN,
LEAST( BaoCao.TOAN, BaoCao.LY, BaoCao.HOA, BaoCao.VAN) as DTN,
((BaoCao.TOAN + BaoCao.VAN)*2 +BaoCao.LY + BaoCao.HOA)/6 as DTB
from BaoCao join DSHS on BaoCao.MAHS = DSHS.MAHS
where ((BaoCao.TOAN + BaoCao.VAN)*2 +BaoCao.LY + BaoCao.HOA)/6 >=8.5 AND
		LEAST( BaoCao.TOAN, BaoCao.LY, BaoCao.HOA, BaoCao.VAN) >=8

Select *from HocSinhXuatSac

--5. Tạo view danh sách HOC SINH DAT THU KHOA KY THI bao gồm các học sinh xuất
--sắc có DTB lớn nhất với các trường: Lop, Mahs, Hoten, Namsinh, Nu, Toan, Ly, Hoa, Van,
--DTB
Create view HSThuKhoa as
Select a.MALOP, a.MAHS, a.HO, a.TEN, a.NamSinh, a.TOAN, a.LY, a.HOA, a.VAN,a.DTB
from HocSinhXuatSac a join BaoCao on a.MAHS = BaoCao.MAHS
where a.DTB = ( Select max (a.DTB) from HocSinhXuatSac a )

Select *from HSThuKhoa

