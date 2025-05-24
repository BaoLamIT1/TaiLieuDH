-- Sử dụng CSDL DuLieu
CREATE DATABASE DuLieu;
USE DuLieu;
GO

-- Tạo bảng tblChatLieu
CREATE TABLE tblChatLieu (
    MaCL INT PRIMARY KEY,
    TenCL NVARCHAR(50)
);
GO

-- Thêm dữ liệu vào bảng tblChatLieu
INSERT INTO tblChatLieu (MaCL, TenCL) VALUES
(1, N'Gỗ'),
(2, N'Sắt'),
(3, N'Nhựa PVC'),
(4, N'Đồng');
GO

-- Tạo bảng tblSanPham
CREATE TABLE tblSanPham (
    MaSP INT PRIMARY KEY,
    TenSP NVARCHAR(100),
    ChatLieu INT FOREIGN KEY REFERENCES tblChatLieu(MaCL),
    MoTa NVARCHAR(MAX),
    GiaNhap FLOAT,
    GiaBan FLOAT,
    Soluong INT
);
GO

-- Thêm dữ liệu vào bảng tblSanPham
INSERT INTO tblSanPham (MaSP, TenSP, ChatLieu, MoTa, GiaNhap, GiaBan, Soluong) VALUES
(1, N'Bàn ghế gỗ', 1, N'Bàn ghế làm từ gỗ xà cừ', 200000, 350000, 10),
(2, N'Đèn bàn kim loại', 2, N'Đèn bàn chất liệu kim loại sắt', 150000, 250000, 15),
(3, N'Hộp nhựa', 3, N'Hộp bánh làm từ nhựa cao cấp', 50000, 80000, 20),
(4, 'Dây điện đồng', 3, N'Lõi dây diện làm từ liệu đồng cao cấp', 50000, 80000, 20);
GO