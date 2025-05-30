create database QLKhachSan_BTTuan
USE QLKhachSan_BTTuan
GO
/****** Object:  Table [dbo].[tChiTietKH]    Script Date: 31-Oct-19 3:03:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChiTietKH](
	[MaDK] [nvarchar](3) NULL,
	[LoaiKH] [nvarchar](1) NULL,
	[TenKH] [nvarchar](25) NULL,
	[NgaySinh] [datetime] NULL,
	[Phai] [bit] NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](7) NULL
) 
GO
/****** Object:  Table [dbo].[tDangKy]    Script Date: 31-Oct-19 3:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tDangKy](
	[MaDK] [nvarchar](3) NOT NULL,
	[SoPhong] [nvarchar](50) NULL,
	[LoaiPhong] [nvarchar](2) NULL,
	[NgayVao] [datetime] NULL,
	[NgayRa] [datetime] NULL,
 CONSTRAINT [PK_tDangKy] PRIMARY KEY CLUSTERED 
(
	[MaDK] ASC
)
) 
GO
/****** Object:  Table [dbo].[tDoanhThu]    Script Date: 31-Oct-19 3:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tDoanhThu](
	[MaDK] [nvarchar](3) NOT NULL,
	[LoaiPhong] [nvarchar](2) NULL,
	[SoNgayO] [int] NULL,
	[ThucThu] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDK] ASC
)
) 
GO
/****** Object:  Table [dbo].[tKhachHang]    Script Date: 31-Oct-19 3:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tKhachHang](
	[LoaiKH] [nvarchar](1) NULL,
	[DienGiai] [nvarchar](50) NULL
) 
GO
/****** Object:  Table [dbo].[tLoaiPhong]    Script Date: 31-Oct-19 3:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tLoaiPhong](
	[LoaiPhong] [nvarchar](1) NULL,
	[GiaiThich] [nvarchar](50) NULL,
	[DonGia] [int] NULL
) 
GO
/****** Object:  Table [dbo].[tPhong]    Script Date: 31-Oct-19 3:03:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPhong](
	[SoPhong] [nvarchar](50) NOT NULL,
	[LoaiPhong] [nvarchar](2) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tPhong] PRIMARY KEY CLUSTERED 
(
	[SoPhong] ASC
)
) 
GO
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'001', N'1', N'Trần Hồng Hà', CAST(N'1980-12-12T00:00:00.000' AS DateTime), 0, N'34A Trần phú', NULL)
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'002', N'1', N'Nguyễn Thế Anh', CAST(N'1968-03-22T00:00:00.000' AS DateTime), 0, N'123 Trần Hưng Đạo', NULL)
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'003', N'1', N'Lê Gia Linh', CAST(N'1981-04-12T00:00:00.000' AS DateTime), 1, N'564 Nguyễn Trãi', N'8445563')
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'004', N'3', N'Nguyễn Thị Minh tâm', CAST(N'1975-05-23T00:00:00.000' AS DateTime), 1, N'56/12 Đặng văn Ngữ', NULL)
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'005', N'1', N'Nguyễn Kim Sơn', CAST(N'1969-09-12T00:00:00.000' AS DateTime), 0, N'78/9 Nguyễn Thị Minh Khai', N'8355647')
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'006', N'1', N'Trần Hạnh Dung', CAST(N'1952-12-15T00:00:00.000' AS DateTime), 1, N'34 Lê Duẩn', NULL)
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'007', N'2', N'Lý Mỹ Lệ', CAST(N'1980-01-16T00:00:00.000' AS DateTime), 1, N'14/2 Vũ Trọng Phụng', N'8679456')
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'008', N'2', N'Nguyễn Kim An', CAST(N'1963-03-12T00:00:00.000' AS DateTime), 0, N'23 Trần Bình Trọng', NULL)
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'009', N'1', N'Nguyễn Phương Dung', CAST(N'1982-06-10T00:00:00.000' AS DateTime), 1, N'67 Hoàng Hoa Thám', N'8767752')
INSERT [dbo].[tChiTietKH] ([MaDK], [LoaiKH], [TenKH], [NgaySinh], [Phai], [DiaChi], [DienThoai]) VALUES (N'010', N'1', N'Lê Thị Kim thảo', CAST(N'1969-09-03T00:00:00.000' AS DateTime), 1, N'56 Nguyễn Tuân', NULL)
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'001', N'201', N'A', CAST(N'1998-04-26T00:00:00.000' AS DateTime), CAST(N'1998-04-28T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'002', N'202', N'B', CAST(N'1998-04-30T00:00:00.000' AS DateTime), CAST(N'1998-05-03T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'003', N'101', N'A', CAST(N'1998-05-01T00:00:00.000' AS DateTime), CAST(N'1998-06-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'004', N'102', N'A', CAST(N'1998-05-02T00:00:00.000' AS DateTime), CAST(N'1998-05-15T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'005', N'405', N'B', CAST(N'1998-05-03T00:00:00.000' AS DateTime), CAST(N'1998-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'006', N'608', N'C', CAST(N'1998-06-01T00:00:00.000' AS DateTime), CAST(N'1998-07-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'007', N'304', N'C', CAST(N'1998-06-05T00:00:00.000' AS DateTime), CAST(N'1998-06-08T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'008', N'201', N'B', CAST(N'1998-06-30T00:00:00.000' AS DateTime), CAST(N'1998-07-15T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'009', N'205', N'A', CAST(N'1999-07-01T00:00:00.000' AS DateTime), CAST(N'1999-07-30T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'010', N'601', N'B', CAST(N'1999-01-01T00:00:00.000' AS DateTime), CAST(N'1999-01-12T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'011', N'202', N'B', CAST(N'2019-01-01T00:00:00.000' AS DateTime), CAST(N'2019-01-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'012', N'601', N'A', CAST(N'2019-04-03T00:00:00.000' AS DateTime), CAST(N'2019-04-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'013', N'601', N'A', CAST(N'2019-04-03T00:00:00.000' AS DateTime), CAST(N'2019-04-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'014', N'601', N'A', CAST(N'2019-04-03T00:00:00.000' AS DateTime), CAST(N'2019-04-03T00:01:00.000' AS DateTime))
INSERT [dbo].[tDangKy] ([MaDK], [SoPhong], [LoaiPhong], [NgayVao], [NgayRa]) VALUES (N'015', N'601', N'A', CAST(N'2019-04-03T00:00:00.000' AS DateTime), CAST(N'2019-04-04T00:00:00.000' AS DateTime))
INSERT [dbo].[tDoanhThu] ([MaDK], [LoaiPhong], [SoNgayO], [ThucThu]) VALUES (N'012', N'A', 2, 400000)
INSERT [dbo].[tDoanhThu] ([MaDK], [LoaiPhong], [SoNgayO], [ThucThu]) VALUES (N'013', N'A', 2, -400000)
INSERT [dbo].[tDoanhThu] ([MaDK], [LoaiPhong], [SoNgayO], [ThucThu]) VALUES (N'014', N'A', 1, 200000)
INSERT [dbo].[tDoanhThu] ([MaDK], [LoaiPhong], [SoNgayO], [ThucThu]) VALUES (N'015', N'A', 1, 200000)
INSERT [dbo].[tKhachHang] ([LoaiKH], [DienGiai]) VALUES (N'1', N'Khách vãng lai')
INSERT [dbo].[tKhachHang] ([LoaiKH], [DienGiai]) VALUES (N'2', N'Khách hàng thân thiết')
INSERT [dbo].[tKhachHang] ([LoaiKH], [DienGiai]) VALUES (N'3', N'Khách có thẻ của công ty Bảo hiểm')
INSERT [dbo].[tLoaiPhong] ([LoaiPhong], [GiaiThich], [DonGia]) VALUES (N'A', N'Máy Lạnh, Nước nóng, Ti Vi,Tủ lạnh, Đ.Thoại', 200000)
INSERT [dbo].[tLoaiPhong] ([LoaiPhong], [GiaiThich], [DonGia]) VALUES (N'B', N'Máy Lạnh, Nươc Nóng, Điện Thoại', 150000)
INSERT [dbo].[tLoaiPhong] ([LoaiPhong], [GiaiThich], [DonGia]) VALUES (N'C', N'Điện Thoại', 100000)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'101', N'A', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'102', N'A', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'103', N'C', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'104', N'A', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'105', N'B', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'201', N'A', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'202', N'B', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'203', N'A', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'204', N'B', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'205', N'A', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'301', N'A', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'302', N'B', N'')
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'303', N'C', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'304', N'C', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'305', N'A', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'401', N'A', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'402', N'B', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'403', N'C', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'404', N'A', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'405', N'B', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'601', N'B', NULL)
INSERT [dbo].[tPhong] ([SoPhong], [LoaiPhong], [GhiChu]) VALUES (N'608', N'C', NULL)
