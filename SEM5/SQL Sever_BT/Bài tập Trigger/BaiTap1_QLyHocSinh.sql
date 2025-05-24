USE [BT_TRIGGER_QLYHOCSINH]
--Cau1
create trigger trig_cau1
on DIEM
after insert, update 
as begin
	update DIEM
	set DTB = ((d.TOAN + d.VAN)*2+ d.LY+ d.HOA)/6
	from DIEM d join inserted on d.MAHS = inserted.MAHS
end
--update DIEM 
--set DTB = null, XEPLOAI = null from DIEM where MAHS = N'00014'
--set LY = 0 from DIEM where MAHS = N'00014'
select * from DIEM where MAHS = N'00014'

--Cau 2 
drop trigger trig_cau2
on DIEM
after insert, update
as begin
	update DIEM
	set DTB = ((d.TOAN + d.VAN)*2+ d.LY+ d.HOA)/6
	from DIEM d join inserted on d.MAHS = inserted.MAHS

	update DIEM
	set XEPLOAI = 
	case
	when inserted.DTB >=5 then N'Lên lớp'
	else N'Lưu ban' 
	end
	from DIEM join inserted on DIEM.MAHS = inserted.MAHS
end
---
update DIEM 
set LY = 6 from DIEM where MAHS = N'00014'
select * from DIEM where MAHS = N'00014'
--- Cau 3
drop trigger trig_cau3
create trigger trig_cau3
on DIEM
after insert, update
as 
begin
	update DIEM
	set DTB = ((d.TOAN + d.VAN)*2+ d.LY+ d.HOA)/6
	from DIEM d join inserted on d.MAHS = inserted.MAHS

	update DIEM
	set XEPLOAI = 
	case
		when i.DTB >=5 and i.TOAN >=4 and i.VAN >=4 and i.LY>=4 and i.HOA>=4 
		then N'Lên lớp'
		else N'Lưu ban'
	end
	from DIEM join inserted i on DIEM.MAHS = i.MAHS
end

update DIEM 
set LY = 6 from DIEM where MAHS = N'00014'
select * from DIEM where MAHS = N'00014'

update DIEM 
set DTB = null, XEPLOAI = null from DIEM where MAHS = N'00014'
update DIEM
set LY = 0 from DIEM where MAHS = N'00014'
--Cau4
drop trigger trig_cau4
create trigger trig_cau4
on DSHS
after delete 
as
begin 
	delete from DIEM
	where MAHS in ( select MAHS from deleted )
end

select * from DSHS where MAHS = N'00014'
select * from DIEM where MAHS = N'00014'
delete DSHS where MAHS = N'00014'


INSERT [dbo].[DIEM] ([MAHS], [TOAN], [LY], [HOA], [VAN], [DTB], [XEPLOAI]) VALUES (N'00014', 8.5, 0, 4.5, 10, NULL, NULL)
INSERT [dbo].[DSHS] ([MAHS], [HO], [TEN], [NU], [NGAYSINH], [MALOP], [GHICHU], [XEPLOAI]) 
VALUES (N'00014', N'Trang Phi', N'Hùng', 0, CAST(N'1975-11-04T00:00:00.000' AS DateTime), N'10A2', NULL, NULL)
