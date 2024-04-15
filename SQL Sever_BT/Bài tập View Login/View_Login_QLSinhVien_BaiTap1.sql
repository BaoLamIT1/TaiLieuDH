USE BT2
--1. Tạo View danh sách sinh viên, gồm các thông tin sau: Mã sinh viên, Họ sinh viên, Tên sinh viên, Học bổng.
CREATE VIEW DanhSachSV
AS
SELECT DSSinhVien.MaSV, DSSinhVien.HoSV, DSSinhVien.TenSV, DSSinhVien.HocBong
FROM DSSinhVien

SELECT * FROM DanhSachSV
--2. Tạo view Liệt kê các sinh viên có học bổng từ 150,000 trở lên và sinh ở Hà Nội, gồm các thông tin: Họ tên sinh viên, Mã khoa, Nơi sinh, Học bổng.
CREATE VIEW Cau2
AS
SELECT DSSinhVien.HoSV, DSSinhVien.TenSV, DSSinhVien.MaKhoa, DSSinhVien.NoiSinh, DSSinhVien.HocBong
FROM DSSinhVien
WHERE DSSinhVien.HocBong >=150000 AND DSSinhVien.NoiSinh = N'Hà Nội'

SELECT *FROM Cau2

--3. Tạo view liệt kê những sinh viên nam của khoa Anh văn và khoa tin học, gồm các thông tin: Mã sinh viên, Họ tên sinh viên, tên khoa, Phái.
CREATE VIEW Cau3
AS
SELECT DSSinhVien.MaSV, DSSinhVien.HoSV, DSSinhVien.TenSV, DMKhoa.TenKhoa, DSSinhVien.Phai
FROM  DSSinhVien join DMKhoa on DSSinhVien.MaKhoa = DMKhoa.MaKhoa
WHERE DSSinhVien.Phai = N'Nam' AND DMKhoa.TenKhoa IN ( N'Anh Văn' ,N'Tin Học') 

SELECT *FROM Cau3

--4. Tạo view gồm những sinh viên có tuổi từ 20 đến 25, thông tin gồm: Họ tên sinh viên, Tuổi, Tên khoa.
CREATE VIEW Cau4
AS
SELECT DSSinhVien.HoSV, DSSinhVien.TenSV , DMKhoa.TenKhoa, DATEDIFF( YEAR ,DSSinhVien.NgaySinh, GETDATE()) AS Tuoi
FROM DSSinhVien join DMKhoa on DSSinhVien.MaKhoa = DMKhoa.MaKhoa
WHERE DATEDIFF( YEAR ,DSSinhVien.NgaySinh, GETDATE()) BETWEEN 20 AND 25

SELECT *FROM Cau4

--5. Tạo view cho biết thông tin về mức học bổng của các sinh viên, gồm: Mã sinh viên,
--Phái, Mã khoa, Mức học bổng. Trong đó, mức học bổng sẽ hiển thị là “Học bổng cao”
--nếu giá trị của field học bổng lớn hơn 500,000 và ngược lại hiển thị là “Mức trung bình”
CREATE VIEW Cau5
AS
SELECT DSSinhVien.MaSV, DSSinhVien.Phai, DSSinhVien.MaKhoa,
	CASE
		WHEN DSSinhVien.HocBong > 500000 THEN 'Học bổng cao'
		ELSE 'Mức trung bình'
END AS MucHocBong
FROM DSSinhVien;

SELECT *FROM Cau5
--6. Tạo view đưa ra thông tin những sinh viên có học bổng lớn hơn bất kỳ học bổng của
--sinh viên học khóa anh văn
CREATE VIEW Cau6
AS
SELECT DSSinhVien.MaSV, DSSinhVien.HoSV , DSSinhVien.TenSV, DSSinhVien.HocBong
FROM DSSinhVien
WHERE DSSinhVien.HocBong > (
		SELECT MAX( sv2.HocBong)
		FROM DSSinhVien sv2
		WHERE sv2.MaKhoa = N'AV'
		)
SELECT *FROM Cau6

--7. Tạo view đưa ra thông tin những sinh viên đạt điểm cao nhất trong từng môn.
CREATE VIEW Cau7
AS
SELECT DSSinhVien.MaSV ,DSSinhVien.HoSV, DSSinhVien.TenSV, DMMonHoc.TenMH, KetQua.Diem 
FROM KetQua 
join DSSinhVien on KetQua.MaSV = DSSinhVien.MaSV
join DMMonHoc on  KetQua.MaMH = DMMonHoc.MaMH
WHERE KetQua.Diem = (
	SELECT MAX( kq.Diem)
	FROM KetQua kq
	WHERE kq.MaMH = KetQua.MaMH
	)
SELECT *FROM Cau7

--8. Tạo view đưa ra những sinh viên chưa thi môn cơ sở dữ liệu.
CREATE VIEW Cau8
AS
SELECT  DSSinhVien.MaSV, DSSinhVien.HoSV, DSSinhVien.TenSV
FROM DSSinhVien 
WHERE DSSinhVien.MaSV NOT IN (
	SELECT KetQua.MaSV
	FROM KetQua 
	WHERE KetQua.MaMH = N'Cơ Sở Dữ Liệu'
	)

SELECT *FROM Cau8
--9. Tạo view đưa ra thông tin những sinh viên không trượt môn nào.
CREATE VIEW Cau9
AS
SELECT DSSinhVien.MaSV, DSSinhVien.HoSV, DSSinhVien.TenSV
FROM DSSinhVien
WHERE DSSinhVien.MaSV NOT IN (
	SELECT KetQua.MaSV
	FROM KetQua 
	WHERE KetQua.Diem <4)

SELECT *FROM Cau9
