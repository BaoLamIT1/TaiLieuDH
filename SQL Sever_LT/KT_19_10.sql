USE BT1CSDL

create procedure p_ktr_cau1
( @MaNXB nvarchar(10), @SlSach int output, @tienNhapHang money output)
as begin
select
	@SlSach= count(*) 
	from tSach 
	where @MaNXB = MaNXB;
select 
	@tienNhapHang = sum(hdn.SLNhap*tSach.DonGiaNhap)
	from tChiTietHDN hdn join tSach on hdn.MaSach = tSach.MaSach
	where @MaNXB = MaNXB
end
--
declare @SlSach int , @tienNhapHang money
exec p_ktr_cau1 @MaNXB = N'NXB01', @SlSach= @SlSach output, @tienNhapHang=@tienNhapHang output
print @SLSach 
print @tienNhapHang

create view ktr_cau2 
as 
select hdn.MaNCC, hdn.SoHDN, sum(cthdn.SLNhap * tSach.DonGiaNhap) as TriGiaHDN
from tHoaDonNhap hdn join tChiTietHDN  cthdn on hdn.SoHDN= cthdn.SoHDN
join tSach on cthdn.MaSach= tSach.MaSach
where year(hdn.NgayNhap) = 2014
group by hdn.MaNCC, hdn.SoHDN
select *from ktr_cau2
----------Cau3--------
create login NguyenMaiTrang with password ='123'
create user NguyenMaiTrang for login NguyenMaiTrang

grant select on tSach to NguyenMaiTrang
grant update on tSach to NguyenMaiTrang 

create login NguyenVanTrieu with password ='123'
create user NguyenVanTrieu for login NguyenVanTrieu

exec sp_addlogin NguyenMaiTrang, 123
-------------------------
--use BT1CSDL
exec sp_adduser NguyenMaiTrang, NguyenMaiTrang
grant select,update on tSach to NguyenMaiTrang with grant option
-------------------------------
exec sp_addlogin NguyenVanTrieu, 123
exec sp_adduser NguyenVanTrieu, NguyenVanTrieu
-----------------------------
create procedure ktr_cau6
(
