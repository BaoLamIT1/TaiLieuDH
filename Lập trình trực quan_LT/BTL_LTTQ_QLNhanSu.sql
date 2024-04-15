create database [BTL_QuanLyNS_Test]
use [BTL_QuanLyNS_Test]
go 
CREATE TABLE TruongDaoTao (
  MaTruongDaoTao NVARCHAR(10) NOT NULL,
  TenTruongDaoTao NVARCHAR(50) NOT NULL,
  DiaChi NVARCHAR(100) NOT NULL,
  DienThoai NVARCHAR(20) NOT NULL,
  PRIMARY KEY (MaTruongDaoTao)
);

go
CREATE TABLE XepLoai (
  MaXepLoai NVARCHAR(10) NOT NULL,
  TenXepLoai NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaXepLoai)
);

go

CREATE TABLE HinhThuc (
  MaHinhThuc NVARCHAR(10) NOT NULL,
  TenHinhThuc NVARCHAR(50) NOT NULL
  PRIMARY KEY (MaHinhThuc)
);

go
CREATE TABLE NganhDaoTao (
  MaNganhDT NVARCHAR(10) NOT NULL,
  TenNganhDT NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaNganhDT)
);

go
--
CREATE TABLE HocVan (
  MaHocVan NVARCHAR(10) NOT NULL PRIMARY KEY,
  TenHocVan NVARCHAR(20) NOT NULL
);

go
CREATE TABLE ChuyenMon (
  MaChuyenMon NVARCHAR(10) NOT NULL PRIMARY KEY,
  TenChuyenMon NVARCHAR(50)
);
go
CREATE TABLE NgoaiNgu (
  MaNgoaiNgu NVARCHAR(20) NOT NULL PRIMARY KEY,
  TenNgoaiNgu NVARCHAR(20) NOT NULL
);
go

CREATE TABLE GioiTinh (
  MaGioiTinh NVARCHAR(1) NOT NULL PRIMARY KEY,
  TenGioiTinh NVARCHAR(20) NOT NULL
);
go

CREATE TABLE DanToc (
  MaDanToc NVARCHAR(10) NOT NULL PRIMARY KEY,
  TenDanToc NVARCHAR(20) NOT NULL
);
go

CREATE TABLE TonGiao (
  MaTonGiao NVARCHAR(10) NOT NULL PRIMARY KEY,
  TenTonGiao NVARCHAR(50) NOT NULL,
  GhiChu NVARCHAR(20) NULL
);
go

CREATE TABLE NoiSinh (
  MaNoiSinh NVARCHAR(10) NOT NULL PRIMARY KEY,
  TenNoiSinh NVARCHAR(50) NOT NULL
);
go

CREATE TABLE PhongBan (
  MaPhongBan NVARCHAR(10) NOT NULL PRIMARY KEY,
  TenPhongBan NVARCHAR(50) NOT NULL,
  DienThoai NVARCHAR(20)
);
go

CREATE TABLE ChucVu (
  MaChucVu NVARCHAR(10) NOT NULL PRIMARY KEY,
  TenChucVu NVARCHAR(20) NOT NULL
);
go

CREATE TABLE HoSoNhanVien (
  MaNhanVien NVARCHAR(10) NOT NULL PRIMaRy key,
  HoTen NVARCHAR(50) NOT NULL,
  MaGioiTinh NVARCHAR(1) NOT NULL,
  MaChucVu NVARCHAR(10) null,
  MaDanToc NVARCHAR(10) null,
  MaTonGiao NVARCHAR(10)  NULL,
  NgaySinh DATE  NULL,
  QueQuan NVARCHAR(50)  NULL,
  MaNoiSinh NVARCHAR(10)  NULL,
  DiaChi NVARCHAR(100)  NULL,
  DienThoai NVARCHAR(10) NOT NULL,
  SoCMND NVARCHAR(12)  NULL,
  MaPhongBan NVARCHAR(10)  NULL,
  MaHocVan NVARCHAR(10)  NULL,
  MaChuyenMon NVARCHAR(10)  NULL,
  VoChong INT,
  Con INT,
  FOREIGN KEY (MaGioiTinh) REFERENCES GioiTinh (MaGioiTinh),
  FOREIGN KEY (MaDanToc) REFERENCES DanToc (MaDanToc),
  FOREIGN KEY (MaTonGiao) REFERENCES TonGiao(MaTonGiao),

  FOREIGN KEY (MaNoiSinh) REFERENCES NoiSinh (MaNoiSinh),
  FOREIGN KEY (MaHocVan) REFERENCES HocVan (MaHocVan),
  FOREIGN KEY (MaChuyenMon) REFERENCES ChuyenMon(MaChuyenMon)
);
go

CREATE TABLE QuaTrinhDaoTao (
  MaQuaTrinhDaoTao NVARCHAR(10) NOT NULL,
  MaNhanVien NVARCHAR(10) NULL,
  TuNgay DATE NOT NULL,
  DenNgay DATE NOT NULL,
  MaTruongDaoTao NVARCHAR(10) NULL,
  MaHinhThuc NVARCHAR(10) NULL,
  MaNganhDT NVARCHAR(10)  NULL,
  MaXepLoai NVARCHAR(10)  NULL,
  FOREIGN KEY (MaNhanVien) REFERENCES HoSoNhanVien (MaNhanVien),
  FOREIGN KEY (MaTruongDaoTao) REFERENCES TruongDaoTao (MaTruongDaoTao),
  FOREIGN KEY (MaNganhDT) REFERENCES NganhDaoTao (MaNganhDT),
  FOREIGN KEY (MaHinhThuc) REFERENCES HinhThuc (MaHinhThuc),
  FOREIGN KEY (MaXepLoai) REFERENCES XepLoai(MaXepLoai)
);
go
CREATE TABLE NV_NgoaiNgu(
	
	MaNgoaiNgu NVARCHAR(20) NOT NULL,
	MaNhanVien NVARCHAR(10) NOT NULL,
	MaXepLoai NVARCHAR(10) NOT NULL,
	FOREIGN KEY (MaXepLoai) REFERENCES XepLoai(MaXepLoai),
	FOREIGN KEY (MaNhanVien) REFERENCES HoSoNhanVien(MaNhanVien)


);

alter table NV_NgoaiNgu
 ADD FOREIGN KEY (MaNgoaiNgu) REFERENCES NgoaiNgu (MaNgoaiNgu);
go

CREATE TABLE QuaTrinhCongTac (
  MaNhanVien NVARCHAR(10) NOT NULL primary key,
  MaQuaTrinhCongTac NVARCHAR(10) NOT NULL ,
  TuNgay DATE NOT NULL,
  DenNgay DATE NOT NULL,
  MaPhongBan NVARCHAR(10) NOT NULL,
  MaChucVu NVARCHAR(10) NOT NULL,
  
	FOREIGN KEY (MaNhanVien) REFERENCES HoSoNhanVien (MaNhanVien),
	FOREIGN KEY (MaPhongBan) REFERENCES PhongBan (MaPhongBan),
	FOREIGN KEY (MaChucVu) REFERENCES ChucVu (MaChucVu)
);

go
create TABLE DangNhap (
  MaDangNhap NVARCHAR(10) NOT NULL PRIMARY KEY,
  TenDangNhap NVARCHAR(50) NOT NULL,
  MatKhau NVARCHAR(50) NOT NULL,
);
-- BaoCao
go
CREATE TABLE Report_QTDT
(
	[HoTen] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [TuNgay] DATE NULL, 
    [DenNgay] DATE NULL, 
    [TenNganhDT] NVARCHAR(50) NULL, 
    [TenHinhThuc] NVARCHAR(50) NULL, 
    [XepLoai] NVARCHAR(50) NULL
)
go
CREATE TABLE Report_QTCT
(
	[HoTen] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [MaQTCT] NVARCHAR(50) NULL, 
    [TuNgay] DATE NULL, 
    [DenNgay] DATE NULL, 
    [MaChucVu] NVARCHAR(50) NULL, 
    [TenChucVu] NVARCHAR(50) NULL
)


--
go
ALTER TABLE NV_NgoaiNgu
ADD CONSTRAINT [constraint_setprm1]
PRIMARY KEY (MaNgoaiNgu, MaNhanVien);

ALTER TABLE [dbo].[QuaTrinhCongTac]
ADD CONSTRAINT [constraint_setprm2]
PRIMARY KEY (MaQuaTrinhCongTac, MaNhanVien);

ALTER TABLE [dbo].[QuaTrinhDaoTao]
ADD CONSTRAINT [constraint_setprm3]
PRIMARY KEY (MaQuaTrinhDaoTao, MaNhanVien);
go

--Them du lieu vao bang
--Bảng hồ sơ nhân viên----------------------------

--Bảng Trường đào tạo-------------------
INSERT INTO [dbo].[TruongDaoTao] ([MaTruongDaoTao], [TenTruongDaoTao], [DiaChi], [DienThoai])
VALUES ('UTC',N'ĐH Giao Thông Vận Tải',N'số 3 cầu giấy','02437663311')
INSERT INTO [dbo].[TruongDaoTao] ([MaTruongDaoTao], [TenTruongDaoTao], [DiaChi], [DienThoai])
VALUES ('TMU',N'ĐH Thương Mại',N'79 hồ tùng mậu','02437643219')
INSERT INTO [dbo].[TruongDaoTao] ([MaTruongDaoTao], [TenTruongDaoTao], [DiaChi], [DienThoai])
VALUES ('FTU',N'ĐH Ngoại Thương',N'91 chùa láng','02432595158')
INSERT INTO [dbo].[TruongDaoTao] ([MaTruongDaoTao], [TenTruongDaoTao], [DiaChi], [DienThoai])
VALUES ('VNU',N'ĐH KHTN-ĐHQG', N'334 nguyễn trãi','02438584615')
INSERT INTO [dbo].[TruongDaoTao] ([MaTruongDaoTao], [TenTruongDaoTao], [DiaChi], [DienThoai])
VALUES ('BA',N'HV Ngân Hàng',N'12 chùa bộc','02438521308')
INSERT INTO [dbo].[TruongDaoTao] ([MaTruongDaoTao], [TenTruongDaoTao], [DiaChi], [DienThoai])
VALUES ('HaUI',N'ĐH Công Nghiệp',N'298 cầu diễn','02437655121')
INSERT INTO [dbo].[TruongDaoTao] ([MaTruongDaoTao], [TenTruongDaoTao], [DiaChi], [DienThoai])
VALUES ('EPU',N'ĐH Điện Lực',N'235 Hoàng Quốc Việt','02422185607')

--Bảng Xếp loại ---------------
INSERT INTO XepLoai (MaXepLoai, TenXepLoai)
VALUES('L1', N'Xuất sắc')
INSERT INTO XepLoai (MaXepLoai, TenXepLoai)
VALUES('L2', N'Giỏi')
INSERT INTO XepLoai (MaXepLoai, TenXepLoai)
VALUES('L3', N'Khá')
INSERT INTO XepLoai (MaXepLoai, TenXepLoai)
VALUES('L4','Trung Bình')


--Bảng Hình thức ---------------
INSERT INTO HinhThuc (MaHinhThuc, TenHinhThuc)
VALUES('ht1',N'chính quy')
INSERT INTO HinhThuc (MaHinhThuc, TenHinhThuc)
VALUES('ht2',N'vừa học vừa làm')


--Bảng Ngành đào tạo 
INSERT INTO NganhDaoTao (MaNganhDT, TenNganhDT)
VALUES('N1', N'Công nghệ thông tin')
INSERT INTO NganhDaoTao (MaNganhDT, TenNganhDT)
VALUES('N2', N'Kế Toán')
INSERT INTO NganhDaoTao (MaNganhDT, TenNganhDT)
VALUES('N3', N'Maketting')
INSERT INTO NganhDaoTao (MaNganhDT, TenNganhDT)
VALUES('N4', N'Tự Động Hóa')
INSERT INTO NganhDaoTao (MaNganhDT, TenNganhDT)
VALUES('N5', N'Kinh Tế Quốc Tế')
INSERT INTO NganhDaoTao (MaNganhDT, TenNganhDT)
VALUES('N6', N'Quản Trị Kinh Doanh')



INSERT INTO GioiTinh (MaGioiTinh, TenGioiTinh)
VALUES('0', N'Nam')
INSERT INTO GioiTinh (MaGioiTinh, TenGioiTinh)
VALUES('1', N'Nữ')

INSERT INTO [dbo].[ChucVu] ([MaChucVu],[TenChucVu])
VALUES ('TTS', N'thực tập sinh')
INSERT INTO [dbo].[ChucVu] ([MaChucVu],[TenChucVu])
VALUES ('NV', N'nhân viên')
INSERT INTO [dbo].[ChucVu] ([MaChucVu],[TenChucVu])
VALUES ('TT', N'tổ trưởng')
INSERT INTO [dbo].[ChucVu] ([MaChucVu],[TenChucVu])
VALUES ('PP', N'phó phòng')
INSERT INTO [dbo].[ChucVu] ([MaChucVu],[TenChucVu])
VALUES ('TP', N'trưởng phòng')
INSERT INTO [dbo].[ChucVu] ([MaChucVu],[TenChucVu])
VALUES ('PGD', N'phó giám đốc')
INSERT INTO [dbo].[ChucVu] ([MaChucVu],[TenChucVu])
VALUES ('GD', N'giám đốc')

				
INSERT INTO [dbo].[DanToc] ([MaDanToc], [TenDanToc])
values ('K',N'Kinh')
INSERT INTO [dbo].[DanToc] ([MaDanToc], [TenDanToc])
values ('M',N'Mường')
INSERT INTO [dbo].[DanToc] ([MaDanToc], [TenDanToc])
values ('HM',N'Hmong')
INSERT INTO [dbo].[DanToc] ([MaDanToc], [TenDanToc])
values ('H',N'Hoa')


INSERT INTO [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu])
VALUES ('PG',N'Phật giáo',NULL)
INSERT INTO [dbo].[TonGiao] ([MaTonGiao], [TenTonGiao], [GhiChu])
VALUES ('KTG',N'Ki tô giáo',NULL)



INSERT INTO [dbo].[NoiSinh] ([MaNoiSinh], [TenNoiSinh])
VALUES ('HN',N'Hà Nội')
INSERT INTO [dbo].[NoiSinh] ([MaNoiSinh], [TenNoiSinh])
VALUES ('ND',N'Nam Định')
INSERT INTO [dbo].[NoiSinh] ([MaNoiSinh], [TenNoiSinh])
VALUES ('HP',N'Hải Phòng')
INSERT INTO [dbo].[NoiSinh] ([MaNoiSinh], [TenNoiSinh])
VALUES ('QN',N'Quảng Nam')
INSERT INTO [dbo].[NoiSinh] ([MaNoiSinh], [TenNoiSinh])
VALUES ('TH',N'Thanh Hóa')
INSERT INTO [dbo].[NoiSinh] ([MaNoiSinh], [TenNoiSinh])
VALUES ('NB',N'Ninh Bình')
INSERT INTO [dbo].[NoiSinh] ([MaNoiSinh], [TenNoiSinh])
VALUES ('TB',N'Thái Bình')
INSERT INTO [dbo].[NoiSinh] ([MaNoiSinh], [TenNoiSinh])
VALUES ('BN',N'Bắc Ninh')
INSERT INTO [dbo].[NoiSinh] ([MaNoiSinh], [TenNoiSinh])
VALUES ('HT',N'Hà Tĩnh')
INSERT INTO [dbo].[NoiSinh] ([MaNoiSinh], [TenNoiSinh])
VALUES ('QNi',N'Quảng Ninh')


INSERT INTO [dbo].[NgoaiNgu] ([MaNgoaiNgu], [TenNgoaiNgu])
VALUES ('TA',N'Tiếng Anh')
INSERT INTO [dbo].[NgoaiNgu] ([MaNgoaiNgu], [TenNgoaiNgu])
VALUES ('NB',N'Tiếng Nhật')



INSERT INTO [dbo].[HocVan] ([MaHocVan], [TenHocVan])
VALUES('CN',N'Cử nhân')
INSERT INTO [dbo].[HocVan] ([MaHocVan], [TenHocVan])
VALUES('KS',N'Kỹ sư')
INSERT INTO [dbo].[HocVan] ([MaHocVan], [TenHocVan])
VALUES('TS',N'Tiến sỹ')
INSERT INTO [dbo].[HocVan] ([MaHocVan], [TenHocVan])
VALUES('ThS',N'Thạc sỹ')


	
INSERT INTO [dbo].[ChuyenMon] ([MaChuyenMon], [TenChuyenMon])
VALUES ('CM01',N'Marketing và Quảng cáo')
INSERT INTO [dbo].[ChuyenMon] ([MaChuyenMon], [TenChuyenMon])
VALUES ('CM02',N'Kỹ thuật')
INSERT INTO [dbo].[ChuyenMon] ([MaChuyenMon], [TenChuyenMon])
VALUES ('CM03',N'Kinh tế và quản lí nhân sự')
INSERT INTO [dbo].[ChuyenMon] ([MaChuyenMon], [TenChuyenMon])
VALUES ('CM04',N'Kinh doanh và dịch vụ')



INSERT INTO [dbo].[PhongBan]([MaPhongBan],[TenPhongBan] ,[DienThoai])
VALUES ('MKT',N'Marketing','0354271823')
INSERT INTO [dbo].[PhongBan]([MaPhongBan],[TenPhongBan] ,[DienThoai])
VALUES ('TCNS',N'Tài chính nhân sự','0708365261')
INSERT INTO [dbo].[PhongBan]([MaPhongBan],[TenPhongBan] ,[DienThoai])
VALUES ('CNTT',N'Công nghệ thông tin','0983646162')
INSERT INTO [dbo].[PhongBan]([MaPhongBan],[TenPhongBan] ,[DienThoai])
VALUES ('CSKH',N'Chăm sóc khách hàng','0877635612')

--HO SO NHAN VIEN
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('001', N'Lê Ngọc Lan Anh','1','K','NV','PG', '2003-05-19',N'Hải Phòng','HP', N'Đống Đa,HN','818639388','211241218','MKT','CN','CM01','0','0');
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('002', N'Lê Tuấn Anh', '1', 'K', 'NV', 'PG', '2004-10-18', N'Hà Nội', 'HN', N'Đống Đa,HN', '949563237', '211210173', 'TCNS', 'CN', 'CM03', '1', '1')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('003', N'Nguyễn Thị Phương Anh', '1', 'K', 'PP', 'KTG', '2003-01-28', N'Hà Nội','HN', N'Đống Đa,HN', '983370551', '211240962', 'CNTT', 'KS', 'CM01', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('004', N'Nguyễn Xuân Bách', '0', 'M', 'NV', 'PG', '2003-01-11', N'Nam Định','ND', N'Đống Đa,HN', '345434221', '211243054', 'CSKH', 'CN', 'CM04', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('005', N'Nguyễn Quỳnh Chi', '1', 'H', 'TT', 'PG', '2003-01-10', N'Hà Nội', 'HN', N'Cầu Giấy, HN', '912038811', '211201577', 'MKT', 'TS', 'CM01', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('006', N'Phạm Thị Hà',      '1', 'K', 'TTS', null, '2003-03-12', N'Hà Nội', 'HN', N'Cầu Giấy, HN', '388580312', '211240940', 'TCNS', null, 'CM03', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('007', N'Đỗ Thị Hải', '1', 'H', 'TTS', null, '2003-05-08', N'Ninh Bình', 'NB', N'Cầu Giấy, HN', '961765837', '211243882', 'TCSN', null, 'CM03', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('008', N'Hoàng Thị Hiên', '1', 'H', 'NV', null, '2003-05-03', N'Hà Nội', 'HN', N'Cầu Giấy, HN', '969647871', '211200829', 'CNTT', 'CN', 'CM02', '1', '1')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('009', N'Lê Thị Hường', '1', 'H', 'NV', 'PG', '2003-05-10', N'Thanh Hoá', 'TH', N'Thanh Xuân,HN', '398168475', '211204093', 'CNTT', 'KS', 'CM02', '1', '2')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('010', N'Đỗ Tuấn Khải', '0', 'H', 'TTS', 'PG', '2003-09-11', N'Hà Nội', 'HN', N'Thanh Xuân,HN', '865636911', '211210438', 'MKT', 'CN', 'CM01', 1, 1)
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('011', N'Vũ Bảo Lâm', '0', 'K', 'PGD', 'PG', '2003-10-10', N'Hải Phòng', 'HP', N'Thanh Xuân,HN', '768386086', '211241205', 'CNTT', 'KS', 'CM02', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('012', N'Hoàng Trung Nguyên', '0', 'H', 'TTS', 'KTG', '2002-01-17', N'Hà Nội', 'HN', N'Thanh Xuân,HN', '93942816', '211243705', 'CSKH', null, 'CM04', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('013', N'Nguyễn Hoài Sơn', '0', 'Hm', 'NV', null, '2003-03-08', N'Hà Nội', 'HN', N'Giảng Võ,HN', '372567544', '211213561', 'TCSN', 'ThS', 'CM03', '1', '1')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('014', N'Nguyễn Thanh Thảo', '1', 'K', 'NV', null, '2003-01-06', N'Quảng Nam', 'QN', N'Giảng Võ,HN', '935449301', '211214540', 'CSKH', 'CN', 'CM04', '1', '2')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('015', N'Trần Thị Thu Thúy', '1', 'M', 'NV', 'PG', '2003-03-15', N'Thái Bình', 'TB', N'Giảng Võ,HN', '865564397', '211201567', 'CSKH', 'CN', 'CM04', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('016', N'Bùi Thị Thu Trang', '1', 'H', 'NV', 'PG', '2003-01-05', N'Bắc Ninh', 'BN', N'Giảng Võ,HN', '337795415', '211242564', 'CSKH', 'CN', 'CM04', '1', '3')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('017', N'Lương Thị Trang', '1', 'K', 'GD', null, '2003-06-17', N'Nam Định', 'ND', N'Long Biên,HN', '888369001', '211213117', 'TCNS', 'CN', 'CM03', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('018', N'Nguyễn Đình Trung', '0', 'K', 'TP', null, '2002-08-17', N'Nam Định', 'ND', N'Long Biên,HN', '969878093', '211242408', 'MKT', 'ThS', 'CM01', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('019', N'Cao Anh Tuấn', '1', 'K', 'TTS', 'KTG', '2001-01-08', N'Hà Tĩnh', 'HT', N'Long Biên,HN', '356712218', '211202927', 'MKT', null, 'CM01', '0', '0')
INSERT INTO [dbo].[HoSoNhanVien] (MaNhanVien, HoTen, MaGioiTinh, MaDanToc, MaChucVu, MaTonGiao, NgaySinh, QueQuan, MaNoiSinh, DiaChi, DienThoai, SoCMND, MaPhongBan, MaHocVan, MaChuyenMon, VoChong, Con)
VALUES ('020', N'Nguyễn Anh Tuấn', '1', 'K', 'NV', 'KTG', '2003-06-13', N'Quảng Ninh', 'QN', N'Long Biên,HN', '335848634', '211204148', 'CNTT', 'TS', 'CM02', '1', '2')


--Bảng quá trình đào tạo--------------------------
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M1', '001', '2015-9-15', '2019-5-20', 'UTC', 'ht2', 'N2', 'L2')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M1', '002', '2016-09-16', '2020-04-25', 'VNU', 'ht1', 'N2', 'L1')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M1', '003', '2016-09-30', '2020-05-31', 'TMU', 'ht1', 'N4', 'L3')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M1', '004', '2010-09-10', '2014-05-25', 'FTU', 'ht1', 'N3', 'L2')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M1', '005', '2018-09-25', '2022-04-26', 'TMU', 'ht2', 'N1', 'L1')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M1', '006', '2018-09-05', '2022-04-20', 'EPU', 'ht1', 'N5', 'L4')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M1', '007', '2014-10-21', '2018-05-15', 'EPU', 'ht1', 'N4', 'L4')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M2', '008', '2013-09-30', '2017-09-17', 'HaUI', 'ht2', 'N3', 'L3')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M2', '009', '2009-08-31', '2013-11-26', 'BA', 'ht1', 'N1', 'L2')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M2', '010', '2014-09-18', '2018-10-30', 'BA', 'ht1', 'N1', 'L2')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M2', '011', '2016-09-15', '2020-12-12', 'TMU', 'ht1', 'N2', 'L3')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M2', '012', '2018-10-03', '2022-11-15', 'UTC', 'ht1', 'N2', 'L4')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M2', '013', '2008-09-20', '2012-10-25', 'FTU', 'ht1', 'N5', 'L1')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M2', '014', '2019-09-19', '2023-09-30', 'FTU', 'ht2', 'N5', 'L1')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M2', '015', '2017-09-21', '2021-10-16', 'BA', 'ht1', 'N4', 'L3')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M2', '016', '2013-10-05', '2017-11-14', 'HaUI', 'ht1', 'N3', 'L2')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M3', '017', '2016-09-17', '2021-04-20', 'EPU', 'ht1', 'N1', 'L2')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M3', '018', '2015-09-05', '2020-05-25', 'BA', 'ht1', 'N6', 'L3')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M3', '019', '2019-10-02', '2024-05-21', 'VNU', 'ht2', 'N1', 'L4')
INSERT INTO [dbo].[QuaTrinhDaoTao]([MaQuaTrinhDaoTao], [MaNhanVien], [TuNgay], [DenNgay],[MaTruongDaoTao], [MaHinhThuc], [MaNganhDT], [MaXepLoai])
VALUES ('M3', '020', '2014-09-26', '2019-05-29', 'VNU', 'ht1', 'N4', 'L1')

-- Bảng quá trình công tác
INSERT INTO QuaTrinhCongTac (MaNhanVien, MaQuaTrinhCongTac, TuNgay, DenNgay, MaPhongBan, MaChucVu)
VALUES
  ('001', '2', '2018-10-15', '2023-10-21', 'MKT', 'NV'),
  ('002', '1', '2020-06-05', '2021-06-05', 'TCNS', 'NV'),
  ('003', '1', '2020-07-30', '2022-12-15', 'CNTT', 'PP'),
  ('004', '3', '2014-08-26', '2023-10-21', 'CSKH', 'NV'),
  ('005', '1', '2022-01-14', '2023-10-21', 'MKT', 'TT'),
  ('006', '1', '2021-06-20', '2022-12-30', 'TCNS', 'TTS'),
  ('007', '2', '2018-07-08', '2023-10-31', 'TCNS', 'TTS'),
  ('008', '2', '2017-02-16', '2023-10-21', 'CNTT', 'NV'),
  ('009', '3', '2013-01-24', '2023-10-21', 'CNTT', 'NV'),
  ('010', '2', '2018-02-18', '2023-05-31', 'MKT', 'TTS'),
  ('011', '1', '2020-06-19', '2023-10-21', 'CNTT', 'PGD'),
  ('012', '1', '2022-07-07', '2023-07-07', 'CSKH', 'TTS'),
  ('013', '3', '2012-01-10', '2023-10-19', 'TCNS', 'NV'),
  ('014', '1', '2023-03-30', '2023-12-30', 'CSKH', 'NV'),
  ('015', '1', '2022-01-02', '2023-10-21', 'CSKH', 'NV'),
  ('016', '2', '2017-04-13', '2023-10-21', 'CSKH', 'NV'),
  ('017', '1', '2020-07-20', '2022-08-30', 'TCNS', 'GD'),
  ('018', '1', '2020-01-25', '2023-12-31', 'MKT', 'TP'),
  ('019', '1', '2020-01-25', '2024-09-30', 'MKT', 'TTS'),
  ('020', '2', '2019-01-7', '2023-10-21', 'CNTT', 'NV')

 --NGOAI NGU
 INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('001', N'TA', 'l2')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('002', 'TA', 'l1')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('003', 'NB', 'l3')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('004', 'TA', 'l2')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('005', 'TA', 'l1')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('006', 'NB', 'l4')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('007', 'NB', 'l4')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('008', 'TA', 'l3')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('009', 'NB', 'l2')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('010', 'NB', 'l2')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('011', 'TA', 'l3')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('012', 'TA', 'l4')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('013', 'NB', 'l1')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('014', 'TA', 'l1')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('015', 'NB', 'l3')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('016', 'NB', 'l2')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('017', 'TA', 'l2')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('018', 'NB', 'l3')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('019', 'TA', 'l4')
INSERT INTO [dbo].[NV_NgoaiNgu] ([MaNhanVien], [MaNgoaiNgu],[MaXepLoai])
VALUES ('020', 'TA', 'l1')

----Dang Nhap
go
INSERT INTO [dbo].[DangNhap]([MaDangNhap],[TenDangNhap],[MatKhau])
VALUES ('dn1',N'NhanVien1','123')