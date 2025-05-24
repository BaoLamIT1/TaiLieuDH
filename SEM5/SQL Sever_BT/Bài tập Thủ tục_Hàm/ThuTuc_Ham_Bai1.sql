	USE QLVanTai

--1. Tạo hàm có đầu vào là lộ trình, đầu ra là số xe, mã trọng tải, số lượng vận tải, ngày đi, ngày
--đến (SoXe, MaTrongTai, SoLuongVT, NgayDi, NgayDen.)
create function f_cau1(@Malotrinh nvarchar(20))
returns table 
as
return 
(
	Select SoXe, MaTrongTai, SoLuongVT, NgayDi,NgayDen
	from ChiTietVanTai
	where @Malotrinh= MaLoTrinh
)
select *from f_cau1('HN')
select *from f_cau1('NT')
--2. Thiết lập hàm có đầu vào là số xe, đầu ra là thông tin về lộ trình
create function f_cau2(@soxe nvarchar(20)) 
returns table 
as 
return 
(
	select * from ChiTietVanTai
	where @soxe = SoXe
)
select *from f_cau2('333')
--3.Tạo hàm có đầu vào là trọng tải, đầu ra là các số xe có trọng tải quy định lớn hơn hoặc bằng trọng tải đó
create function f_cau3(@TrongTai int)
returns table 
as
return 
(
	select SoXe
	from ChiTietVanTai
	join TrongTai on ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai
	where TrongTai.TrongTaiQD >= @TrongTai
)
select *from f_cau3('4')
select *from f_cau3('12')
--4. Tạo hàm có đầu vào là trọng tải và mã lộ trình, đầu ra là số lượng xe có trọng tải quy định 
--lớn hơn hoặc bằng trọng tải đó và thuộc lộ trình đó.
--drop function f_cau4
create function f_cau4 
(	@TrongTaiQD int, 
	@malotrinh nvarchar(20)
)
returns int
as
begin
	declare @SoluongXe int
	select @SoluongXe = count(*)
	from ChiTietVanTai
	inner join TrongTai on ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai
	where TrongTai.TrongTaiQD >= @TrongTaiQD 
	and ChiTietVanTai.MaLoTrinh = @malotrinh
	return @SoluongXe
end
select dbo.f_cau4(4,'HN') 
select dbo.f_cau4(8,'HN')
--5. Tạo thủ tục có đầu vào Mã lộ trình đầu ra là số lượng xe thuộc lộ trình đó.
create procedure p_cau5
(
	@Malt nvarchar(20),
	@slxe int output
)
as
begin 
	select @slxe = count(*)
	from ChiTietVanTai
	where @Malt = MaLoTrinh
end
-----------------------------
declare @slxe int 
exec p_cau5 @Malt = 'HN', @slxe = @slxe output 
print @slxe 
--6. Tạo thủ tục có đầu vào là mã lộ trình, năm vận tải, đầu ra là số tiền theo mã lộ trình và năm vận tải đó
create procedure p_cau6
(
	@MaLT nvarchar(20),
	@NamVT int,
	@tongtien int output
)
as
begin 
	select @tongtien = sum(ChiTietVanTai.SoLuongVT * LoTrinh.DonGia)
	from ChiTietVanTai
	inner join LoTrinh on ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh
	where ChiTietVanTai.MaLoTrinh = @MaLT and year(ChiTietVanTai.NgayDi) = @NamVT
end
--------------------------
declare @tongtien int 
exec p_cau6 @MaLT ='HN', @NamVT = 2014 , @tongtien = @tongtien output
print @tongtien
--7. Tạo thủ tục có đầu vào là số xe, năm vận tải, đầu ra là số tiền theo số xe và năm vận tải đó
create procedure p_cau7
(
	@soxe int,
	@NamVT int ,
	@tongTien int output
)
as
begin
	select @tongTien = sum(ChiTietVanTai.SoLuongVT * LoTrinh.DonGia )
	from ChiTietVanTai
	inner join LoTrinh on ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh
	where ChiTietVanTai.SoXe = @soxe and year(ChiTietVanTai.NgayDi) = @NamVT
end
----------------------
declare @tongTien int
exec p_cau7 @soxe = '444' ,@NamVT = 2014, @tongTien= @tongTien output
print @tongTien

--8. Tạo thủ tục có đầu vào là mã trọng tải, đầu ra là số lượng xe vượt quá trọng tải quy định của mã trọng tải đó. 
create procedure p_cau8
(
	@matrongtai nvarchar(20),
	@solgxe int output
)
as
begin
	select @solgxe = count(*)
	from ChiTietVanTai
	inner join TrongTai on ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai
	where ChiTietVanTai.MaTrongTai = @matrongtai and ChiTietVanTai.SoLuongVT > TrongTai.TrongTaiQD
end
--------------------------
declare @solgxe int 
exec p_cau8 @matrongtai = N'50' , @solgxe = @solgxe output
print @solgxe 
