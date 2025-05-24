use BT2

--1. Tạo login Login1, tạo User1 cho Login1
Create login Login1 with password = '123'
Create user User1 for login Login1

--2. Phân quyền Select trên bảng DSSinhVien cho User1
Grant select on DSSinhVien To User1

--3. Đăng nhập để kiểm tra

--4. Tạo login Login2, tạo User2 cho Login2
Create login Login2 with password ='123'
Create user User2 for login Login2

--5. Phân quyền Update trên bảng DSSinhVien cho User2, người này có thể cho phép người
--khác sử dụng quyền này
Grant update on DSSinhVien to User2 with grant option 
--6. Đăng nhập dưới Login2 và trao quyền Update trên bảng DSSinhVien cho User 1

--7. Đăng nhập Login 1 để kiểm tra

