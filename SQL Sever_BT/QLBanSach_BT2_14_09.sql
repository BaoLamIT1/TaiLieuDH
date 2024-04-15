USE BT1CSDL
--1.Tạo view in ra danh sách các sách của nhà xuất bản giáo dục nhập trong năm 2021
--2.Tạo view thống kê các sách không bán được trong năm 2021
--3.Tạo view thống kê 10 khách hàng có tổng tiền tiêu dùng cao nhất trong năm 2021
create view [soluong]
as 
select top 10 with ties tKhachHang.MaKH, tKhachHang.TenKH, sum(tChiTietHDB.SLBan* tSach.DonGiaBan) as tongtien
from tKhachHang join tHoaDonBan on tHoaDonBan.MaKH = tKhachHang.MaKH
				join tChiTietHDB on tChiTietHDB.SoHDB= tHoaDonBan.SoHDB
				join tSach on tSach.MaSach = tChiTietHDB.MaSach
where YEAR(tHoaDonBan.NgayBan) = 2014
group by tKhachHang.MaKH, TenKH
order by tongtien desc
drop view [soluong]

select * from soluong
--4.Tạo view thống kê số lượng sách bán ra trong năm 2021 và số lượng sách nhập trong năm 2021 và chênh lệch giữa hai số lượng này ứng với mỗi đầu sách
create view []
as
select tSach.MaSach
from tSach  join tChiTietHDB on tSach.MaSach = tChiTietHDB.MaSach
			join tHoaDonBan on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
			join tChiTietHDN on tSach
--5.Tạo view đưa ra những thông tin hóa đơn và tổng tiền của hóa đơn đó trong ngày 16/11/2021
create view cau5
as
select tHoaDonBan.SoHDB, sum(tChiTietHDB.SLBan*tSach.DonGiaBan) as tongsotien
from tSach join tChiTietHDB on tSach.MaSach = tChiTietHDB.MaSach
			join tHoaDonBan on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
where tHoaDonBan.NgayBan = N'2021-11-16'
group by tHoaDonBan.SoHDB

select * from cau5
--6. Tạo view đưa ra doanh thu bán hàng của từng tháng trong năm 2014, những tháng không có doanh thu thì ghi là 0.

--7. Tạo view đưa ra doanh thu bán hàng theo ngày, và tổng doanh thu cho mỗi tháng (dùng roll up)
--8.Tạo view đưa ra danh sách 3 khách hàng có tiền tiêu dùng cao nhất
create view [top3kh]
as 
select top 10 with ties tKhachHang.MaKH, tKhachHang.TenKH, sum(tChiTietHDB.SLBan* tSach.DonGiaBan) as tongtien
from tKhachHang join tHoaDonBan on tHoaDonBan.MaKH = tKhachHang.MaKH
				join tChiTietHDB on tChiTietHDB.SoHDB= tHoaDonBan.SoHDB
				join tSach on tSach.MaSach = tChiTietHDB.MaSach
group by tKhachHang.MaKH, TenKH
order by tongtien desc

select * from top3kh
--9.Tạo view đưa ra 10 đầu sách được tiêu thụ nhiều nhất trong năm 2022 và số lượng tiêu thụ mỗi đầu sách.
create view [top10sach]
as 
select top 10  with ties tSach.TenSach, tSach.MaSach as top10
from tSach join tChiTietHDB on tSach.MaSach= tChiTietHDB.MaSach
		join tHoaDonBan on tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
where  Month( tHoaDonBan.NgayBan ) = 2022
group by tSach.MaSach,TenSach
order by tChiTietHDB.SLBan desc

select * from top3kh
--10.Tạo view SachGD đưa ra danh sách các sách với các thông tin MaSach,TenSach, tên thể loại, tổng số lượng nhập, tổng số lượng bán, số lượng tồn do Nhà xuất bản Giáo Dụcxuất bản

