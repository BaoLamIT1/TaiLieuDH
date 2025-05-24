use BT2
select *from DSSinhVien

--Nếu kết quả trả về là 1, tức là user User1 có quyền UPDATE trên bảng DSSinhVien.
SELECT HAS_PERMS_BY_NAME('DSSinhVien', 'OBJECT', 'UPDATE');
