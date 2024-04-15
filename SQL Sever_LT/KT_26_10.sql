use QLVanTai

--Cau 1
create procedure test_cau1
( @ngaydi date,  @slgxe int output )
as begin 
	select @slgxe = count (*)
	from ChiTietVanTai
	where @ngaydi = NgayDi
end;

declare @slgxe int 
exec test_cau1 @ngaydi = N'2014-05-03' , @slgxe = @slgxe output
print @slgxe

--Cau 2
create or alter function test_f_cau2( @maTT nvarchar(255) , @ngaydi date )
returns table
as return 
	(
		select MaVT, count(SoXe) as SoXe, MaLoTrinh, NgayDi, NgayDen
		from ChiTietVanTai
		inner join  TrongTai on ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai
		where @ngaydi = NgayDi and @maTT = ChiTietVanTai.MaTrongTai
		group by MaVT, MaLoTrinh, NgayDi, NgayDen
)

SELECT * FROM test_f_cau2(50, '2014-05-01')

--Cau3
create view test_Cau3
as
	select * from ChiTietVanTai
	where ChiTietVanTai.NgayDi < GETDATE()
	and ChiTietVanTai.NgayDen > GETDATE()
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) 
VALUES (1, N'317', N'62', N'PK', 5, CAST(N'2023-10-24T00:00:00.000' AS DateTime), CAST(N'2023-10-27T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) 
VALUES (2, N'127', N'70', N'QN', 10, CAST(N'2023-10-20T00:00:00.000' AS DateTime), CAST(N'2023-10-27T00:00:00.000' AS DateTime))

select *from test_Cau3

--Cau4
alter table TrongTai
add SoLuongXe int;

create trigger test_cau4
on ChiTietVanTai
after insert
as begin 
	update tt
	set SoLuongXe = SoLuongXe +1
	from inserted i
	inner join TrongTai tt on i.MaTrongTai = tt.MaTrongTai
	where i.SoLuongVT < tt.TrongTaiQD
end;


---Cau 5
create login A with password ='123'
create login B with password ='123'

exec sp_adduser A, A
exec sp_adduser B,B
grant select,update,insert on ChiTietVanTai to B with grant option

SELECT HAS_PERMS_BY_NAME('ChiTietVanTai', 'OBJECT', 'UPDATE');
SELECT HAS_PERMS_BY_NAME('ChiTietVanTai', 'OBJECT', 'SELECT');
SELECT HAS_PERMS_BY_NAME('ChiTietVanTai', 'OBJECT', 'INSERT');

---------bên B----------------
exec sp_adduser A 
grant select,update on ChiTietVanTai to A

select *from ChiTietVanTai