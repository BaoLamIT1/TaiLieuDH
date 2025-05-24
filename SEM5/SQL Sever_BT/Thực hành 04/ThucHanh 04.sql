USE [QLKhachSan]

--Câu 1: Tạo thủ tục có đầu vào là số điện thoại khách hàng, năm, đầu ra là số lượng phiếu đặt
--của khách hàng đó trong năm đó (năm được tính dựa trên ngày đến dự kiến).
create or alter  procedure pro_cau1 
(	@sdt nvarchar(10) , @nam int , @solgphieu int output	)
as 
begin 
	select @solgphieu = COUNT(*)
	from PHIEUDAT join KHACHHANG on PHIEUDAT.MaKH = KHACHHANG.MaKH
	where @nam = YEAR(NgayDenDukien) and @sdt = Dienthoai
end;

declare @solgphieu int
exec pro_cau1  N'0987654321', 2022 ,   @solgphieu output
print N'Số lượng phiếu đặt trong năm: '+  CAST(@solgphieu AS nvarchar(10));
--Câu 2: Tạo hàm có đầu vào là Ngày, đầu ra là danh sách các thông tin chi tiết phòng đặt dự
--kiến đến trong ngày đó, các thông tin đưa ra như bảng dưới đây (bảng ví dụ dưới có ngày là
--‘09/01/2022’)
-- Mã booking ||Ngày đến dự kiến ||Ngày đi dự kiến ||Kiểu phòng || Số lượng phòng||
create or alter function func_cau2 ( @Ngay date	)
returns table 
as
return 
(	select pd.MaBooking, pd.NgayDenDukien, pd.NgayDiDuKien,
		   lp.Kieuphong , ctpd.SLPhong
	from PHIEUDAT as pd
	join CHITIETPHONGDAT ctpd on pd.MaBooking = ctpd.MaBooking
	join LOAIPHONG lp on ctpd.MaLP = lp.MaLP
	where pd.NgayDenDukien = @Ngay
);
select * from func_cau2( N'2022-01-09' )
--Câu 3: Thêm trường Số ngày thuê vào bảng Phòng. Tạo Trigger cập nhật tự động cho trường
--này mỗi khi thêm, sửa, xóa một bản ghi ở bảng Phiếu thuê, biết:
--số ngày thuê = {
--1, Thời gian checkin và checkout cùng 1 ngày
--Thoigiancheckout − Thoigiancheckin, Trường hợp khác
alter table PHONG
add SoNgayThue int null
drop trigger trig_cau4
create or alter trigger trig_cau4 
on PHIEUTHUE
after insert, update, delete
as begin
if exists ( select * from inserted)
	begin
		update Phong
		set SoNgayThue = iif(inserted.Thoigiancheckout= inserted.Thoigiancheckin, 1,datediff(day, inserted.Thoigiancheckin, inserted.Thoigiancheckout))
		FROM Phong
		JOIN PhieuThue ON Phong.Maphong = phieuThue.Maphong
		JOIN inserted ON PhieuThue.MaPT =inserted.MaPT AND Phong.MaPhong = inserted.MaPhong
	end
else
	begin
		update Phong
		set SoNgayThue = 0
		FROM Phong
		JOIN PhieuThue ON Phong.MaPhong = PhieuThue.MaPhong
		JOIN deleted ON Phong.MaPhong = deleted.MaPhong
	end
end

INSERT [dbo].[PHIEUTHUE] ([MaPT], [MaBooking], [ThoigianlapPT], [Thoigiancheckout], [Thoigiancheckin], [KMPhong], [Maphong]) VALUES 
(N'PT00011', N'PD0016', CAST(N'2022-12-12T00:00:00.000' AS DateTime), CAST(N'2022-12-15T00:00:00.000' AS DateTime), CAST(N'2022-12-12T00:00:00.000' AS DateTime), 0, N'P101')
select * from PHIEUTHUE 
update PHIEUTHUE set Thoigiancheckout = '2022-12-20T00:00:00.000' where MaPT = 'PT00011'   -- thay đổi ngày checkout
delete from PHIEUTHUE where MaPT = N'PT00011'  -- xoá đi Phiếu thuê 
select * from PHONG 
--Câu 4: Tạo View gồm các thông tin mã khách hàng, tên khách hàng, địa chỉ, điện thoại, mã
--Booking, tiền đặt cọc, mã loại phòng, số lượng phòng có ngày đến dự kiến từ ngày
--12/12/2022 đến ngày 19/12/2022
create or alter view v_cau4
as 
select kh.MaKH, kh.TenKH, kh.Diachi, kh.Dienthoai,	
		pd.MaBooking, pd.Tiendatcoc, ct.MaLP, ct.SLPhong
from KHACHHANG kh 
join PHIEUDAT pd on kh.MaKH = pd.MaKH
join CHITIETPHONGDAT ct on pd.MaBooking = ct.MaBooking
where pd.NgayDenDukien between '2022-12-12' AND '2022-12-19'

select * from v_cau4
--Câu 5: Tạo login TranHuyHiep, tạo user TranHuyHiep cho login TranHuyHiep trên CSDL đã cho.
create LOGIN TranHuyHiep WITH PASSWORD = '123'
CREATE USER TranHuyHiep FOR LOGIN TranHuyHiep
--Phân quyền Select trên view ở câu 5 cho TranHuyHiep, và TranHuyHiep được phép phânquyền cho người khác
GRANT SELECT ON dbo.v_cau4 TO TranHuyHiep with grant option   
--Tạo login PhamVietTrung, tạo user PhamVietTrung cho login PhamVietTrung trên CSDL trên.
CREATE LOGIN PhamVietTrung WITH PASSWORD = '123'
CREATE USER PhamVietTrung FOR LOGIN PhamVietTrung
--Từ login TranHuyHiep, phân quyền Select trên view Câu 5 cho PhamVietTrung
GRANT SELECT ON dbo.v_cau4 TO PhamVietTrung

--Câu 6: Tạo view đưa ra danh sách khách hàng có số tiền tiêu dùng nằm trong top(3) số tiền
--tiêu dùng lớn nhất tại khách sạn.
--Tiền tiêu dùng của khách là số tiền khách trả cho tiền thuê phòng tại khách sạn.
create or alter view v_cau6 as
select top 3 with ties PHIEUDAT.MaKH, TenKH, sum(
	(case 
	when datediff(day,Thoigiancheckin,Thoigiancheckout) = 0 then 1
	else datediff(day,Thoigiancheckin, Thoigiancheckout) end) 
	* SLPhong * (1 - KMPhong) *Dongiaphong) as tongtien
	from PHIEUDAT join CHITIETPHONGDAT on CHITIETPHONGDAT.MaBooking = PHIEUDAT.MaBooking 
	join LOAIPHONG on LOAIPHONG.MaLP = CHITIETPHONGDAT.MaLP 
	join PHIEUTHUE on PHIEUTHUE.MaBooking = PHIEUDAT.MaBooking
	join KHACHHANG on KHACHHANG.MaKH= PHIEUDAT.MaKH
	group by PHIEUDAT.MaKH, TenKH
	order by tongtien desc
select * from v_cau6
--select top 3 with ties  A.MaKH, KHACHHANG.TenKH, 
--sum(A.tongtien) as TongTienTieuDung from
--( 
--	select PHIEUDAT.MaKH, 
--	sum( LOAIPHONG .Dongiaphong * CHITIETPHONGDAT.SLPhong 
--			*
--			(	case 
--			when datediff(day,PHIEUTHUE.Thoigiancheckin, PHIEUTHUE.Thoigiancheckout) <=0 then 1
--			else datediff(day,PHIEUTHUE.Thoigiancheckin, PHIEUTHUE.Thoigiancheckout) end
--			) 
--			* 
--			( 1- PHIEUTHUE.KMPhong )
--		) as tongtien 
--	from PHIEUDAT join PHIEUTHUE on PHIEUDAT.MaBooking = PHIEUTHUE.MaBooking
--	join PHONG on PHONG.Maphong = PHIEUTHUE.Maphong
--	join LOAIPHONG on LOAIPHONG.MaLP = PHONG.MaLP
--	join CHITIETPHONGDAT on CHITIETPHONGDAT.MaLP = LOAIPHONG.MaLP
--	group by PHIEUDAT.MaKH
--)A
--	join KHACHHANG on KHACHHANG.MaKH= A.MaKH
--	group by A.MaKH, KHACHHANG.TenKH
--	order by sum(A.tongtien) desc
--select * from v_cau6