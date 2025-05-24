USE BT1_TKCSDL

--Cau 1: tạo  thủ tục có đầu vào là mã lớp, đầu ra là số hs nam và nữ của lớp 
create procedure KT_cau2
(
	@Malop nvarchar(5),
	@HsNam int output,
	@HsNu int output
)
as 
begin
	select @HsNam = count( case when ds.NU = 0 then 1 end),
		   @HsNu = count ( case when ds.NU = 1 then 1 end)
	from DSHS ds
	where ds.MALOP = @Malop
end
declare @Malop nvarchar(5), @HsNam int  , @HsNu int 
exec KT_cau2 @Malop = N'10A4',@HsNam= @HsNam output, @HsNu = @HsNu output
print @HsNam 
print @HsNu

--Cau3
create login LeBichPhuong with password ='123'
create user LeBichPhuong for login LeBichPhuong

grant select on view1 to LeBichPhuong
select *from DSHS

