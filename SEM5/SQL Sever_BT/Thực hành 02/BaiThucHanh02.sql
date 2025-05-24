USE QLBanHang
--Tạo VIEW
--1. Liệt kê thông tin mã nhân viên, họ tên, tuổi, quê quán, số điện thoại, hệ số lương,
--lương (=HSL * 1500000)
create view v_cau1 as
select MaNV, HoTen, DATEDIFF(year,NgaySinh,GETDATE())as Tuoi,
QueQuan,SDT,HSL, HSL*1500000 as Luong
from NHANVIEN

select *from v_cau1
--2. Liệt kê các nhân viên cùng quê Hà Nội
create view v_cau2 as
select MaNV, HoTen, QueQuan
from NHANVIEN
where QueQuan like N'%Hà Nội%'

select *from v_cau2

--3. Liệt kê các mặt hàng của cùng nhà cung cấp có mã ‘0001’
create view v_cau3 as
select hh. MaHH, hh.HangSX, hh.TenHH, hh.GiaBan
from HANGHOA hh join CT_PHIEUNHAP ctn on hh.MaHH = ctn.MaHH
				join PHIEUNHAP pn on pn.MaPN = ctn.MaPN
				join NHACUNGCAP ncc on ncc.MaNCC = pn.MaNCC
where ncc.MaNCC = '0001'

select *from v_cau3
--4. Tạo view doanh thu theo từng hóa đơn của tháng 11 năm 2021
alter view v_cau4 as
select cthd.MaHD, sum( cthd.SL * hh.GiaBan) As DoanhThu
from CT_HOADON cthd 
join HangHoa hh on cthd.MaHH = hh.MaHH
join HOADON hd on hd.MaHD = cthd.MaHD
where month(hd.NgayLap) = 3 and year(hd.NgayLap)=2015
group by cthd.MaHD

select *from v_cau4
--5. Tạo view doanh thu theo mỗi khách hàng trong năm 2021
create view v_cau5 as
select hd.MaKH, kh.TenKH , sum(cthd.SL * hh.GiaBan) as doanhthu
from CT_HOADON cthd
join HANGHOA hh on cthd.MaHH = hh.MaHH
join HOADON hd on cthd.MaHD = hd.MaHD
join KHACHHANG kh on hd.MaKH = kh.MaKH
where YEAR(hd.NgayLap) = 2021
group by hd.MaKH , kh.TenKH

select *from v_cau5
--6. Tạo view liệt kê số tiền phải trả cho mỗi nhà cung cấp trong năm 2021
create view v_cau6 as
select ncc.MaNCC, ncc.TenNCC,
sum(ctpn.GiaMua * ctpn.SL) as TienPhaiTra
from CT_PHIEUNHAP ctpn
join PHIEUNHAP pn on ctpn.MaPN = pn.MaPN
join NHACUNGCAP ncc on pn.MaNCC = ncc.MaNCC
where year(pn.NgayLap) = 2015
group by ncc.MaNCC , ncc.TenNCC

select *from v_cau6
--7. Tạo view số lượng nhập và bán ứng với mỗi sản phẩm trong năm 2021
alter view v_cau7 as
select HH.MaHH, HH.TenHH , sum(distinct ctpn.SL) as SoLuongNhap,
sum(distinct cthd.SL) as SoLuongBan
from HANGHOA HH
left join CT_PHIEUNHAP ctpn on hh.MaHH = ctpn.MaHH
left join CT_HOADON cthd on hh.MaHH = cthd.MaHH
join PHIEUNHAP pn on ctpn.MaPN = pn.MaPN
join HOADON hd on cthd.MaHD = hd.MaHD
where year(pn.NgayLap) =2021 and year(hd.NgayLap) = 2021
group by HH.MaHH, HH.TenHH

select *from v_cau7

--IV. Tạo PROC
--1. Cho biết tổng số tiền của một hóa đơn nào đó theo mã hóa đơn
create procedure p_cau1 (@maHD int , @tongtien money output )
as
begin 
	select @tongtien = sum(cthd.SL*hh.Giaban)
	from CT_HOADON cthd join HANGHOA hh on cthd.MaHH= hh.MaHH
	where @maHD = MaHD
end
---------
declare @tongtien money
exec p_cau1 @maHD=N'0001', @tongtien=@tongtien output
print 'Tong so tien cua hoa don la: ' +convert(nvarchar(20), @tongtien)

--2. Cho biết tổng số hóa đơn đã lập được trong một tháng của một năm nào đó
create procedure p_cau2 ( @thang int, @nam int, @TongHD int output)
as
begin 
	select @TongHD = count(*)
	from HOADON
	where month(NgayLap) =@thang and year(NgayLap) = @nam
end
------
declare @TongHD int
exec p_cau2 @thang= 3, @nam = 2015, @TongHD=@TongHD output
print @TongHD
--3. Cho biết tổng số hóa đơn đã lập và tổng doanh thu đã bán hàng của một nhân
--viên trong một năm nào đó dựa vào mã nhân viên
create procedure p_cau3
(	@MaNV int, @Nam int, @tongHD int output, @tongDoanhThu money output)
as begin
select 
	@tongHD = count(*),
	@tongDoanhThu = sum(cthd.SL * hh.GiaBan)
	from HoaDon hd 
	join CT_HOADON cthd on hd.MaHD = cthd.MaHD
	join HANGHOA hh on cthd.MaHH = hh.MaHH
where hd.MaNV= @MaNV and year(hd.NgayLap) = @Nam
end
-------
declare @tongHD int , @tongDoanhThu money
exec p_cau3 @MaNV=N'0002', @Nam=2015,@tongHD=@tongHD output, @tongDoanhThu=@tongDoanhThu output
print 'Tong so HD trong nam do la:' + convert(nvarchar(20),@tongHD)
print 'Tong doanh thu: '+ convert(nvarchar(20),@tongDoanhThu)
--4. Cho biết tổng số lượng đã nhập và tổng số tiền đã nhập của một mặt hàng nào đó trong một năm nào đó dựa vào mã hàng hóa nào đó
create procedure p_cau4
( @MaHH int , @Nam int, @tongSLN int output, @tongtien money output)
as begin 
select 
	@tongSLN = sum(ctpn.SL),
	@tongtien = sum(ctpn.SL*ctpn.GiaMua)
	from CT_PHIEUNHAP ctpn
	join PHIEUNHAP pn on ctpn.MaPN = pn.MaPN
	where @MaHH= ctpn.MaHH and @Nam = year(pn.NgayLap)
end
----------
declare @tongSLN int , @tongtien money 
exec p_cau4 @MaHH=N'0001', @Nam=2015, @tongSLN=@tongSLN output, @tongtien=@tongtien output
print 'Tong SL nhap la: ' + convert(nvarchar(20),@tongSLN)
print 'Tong tien nhap la: ' + convert(nvarchar(20),@tongtien)
--5. Tính tổng số tiền thu được của từng hóa đơn
create procedure p_cau5
as begin
select 
	cthd.MaHD, sum(cthd.SL*hh.GiaBan) as TongTien
	from CT_HOADON cthd join HANGHOA hh on cthd.MaHH = hh.MaHH
	group by MaHD
end
-----------
exec p_cau5 
--6. Tính tổng số lượng và tổng số tiền đã bán được của từng hàng hóa
create procedure p_cau6
as begin
select 
	hh.MaHH, hh.TenHH,sum(cthd.SL) as TongSL,
	sum(cthd.SL*hh.GiaBan) as TongTienBan
	from HANGHOA hh 
	join CT_HOADON cthd on hh.MaHH = cthd.MaHH
	group by hh.MaHH,hh.TenHH
end
-----
exec p_cau6
--7. Tính tổng số lượng và tổng số tiền đã nhập của từng hàng hóa
create procedure p_cau7
as begin
select 
	MaHH, sum(SL) as TongSLNhap, 
	sum(Sl*GiaMua) as TongTienNhap
	from CT_PHIEUNHAP 
	group by MaHH
end
---------
exec p_cau7
--8. Tính tổng số hóa đơn đã lập trong từng tháng của năm 2015
create procedure p_cau8
as begin
select 
	month(NgayLap) as Thang, count(*) as TongSoHD
	from HOADON
	where year(NgayLap)=2015
	group by month(NgayLap)
end
------
exec p_cau8