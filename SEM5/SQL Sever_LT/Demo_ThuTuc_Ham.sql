----Declare @t int, @x int
----Set @t = 1 ; Set @x = 1
----While (@x <= 10)
----begin
----set @t = @t * @x
----set @x = @x + 1
----end
----Print @t--USE [BT1_TKCSDL]--alter table DSHS add dtbc float--Declare hs cursor for select mahs from DSHS
--Open hs
--Declare @mahs nvarchar(5), @dtb float
--Fetch next from hs into @mahs
--While (@@fetch_status = 0)
--begin
--select @dtb=round((toan*2+van*2+hoa+ly)/6,2) from diem where
--MAHS=@mahs
--update dshs set dtbc=@dtb where MAHS=@mahs
--Fetch next from hs into @mahs
--end

--Close hs; Deallocate hs

--Select * from DSHS

USE [BT1_TKCSDL]
DECLARE cs CURSOR FOR SELECT MAHS FROM DIEM
OPEN cs
DECLARE @mahs nvarchar(5), @dtb float
FETCH NEXT FROM cs into @mahs
WHILE @@FETCH_STATUS=0
BEGIN
	declare @xl nvarchar(50)
	select @dtb = dtbc from DSHS where  MAHS = @mahs

	IF (@dtb >= 8 ) SET @xl=N'Giỏi'
	ELSE IF (@dtb<8 AND @dtb>=6.5) SET @xl=N'Khá'
	ELSE IF (@dtb < 6.5 and @dtb >=5) SET @xl =N'Trung binh' 
	ELSE If (@dtb< 5) set @xl= N'Yếu'
	Update DIEM set XepLoai=@xl where MAHS=@mahs
	
	update DIEM set dtb = @dtb where MAHS = @mahs
	FETCH NEXT FROM cs into @mahs
END
CLOSE cs
DEALLOCATE cs

Select * from DIEM

/* tạo thủ tục có đầu vào là mã học sinh, đầu ra là điểm
trung bình của học sinh đó*/
CREATE PROCEDURE DiemTrungBinh @mahs nvarchar(5), @dtb float
output
AS
begin
select @dtb=round((toan*2+van*2+ly+hoa)/6, 2) from diem where
MAHS=@mahs
End
--Gọi thủ tục:
declare @tb float
exec DiemTrungBinh '00001', @tb output
print @tb

