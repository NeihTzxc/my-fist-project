CREATE DATABASE QLBH2
GO
USE QLBH2
CREATE TABLE KHACHHANG
(
MaKH CHAR(7) NOT NULL PRIMARY KEY(MaKH),
TenKH NVARCHAR(50) NOT NULL,
TenGiaoDich NVARCHAR(20),
DiaChi NVARCHAR(80),
Email VARCHAR(30),
DienThoai CHAR(11),
Fax VARCHAR(15),

)
CREATE TABLE NHACUNGCAP
(
MaNCC CHAR(3) NOT NULL CONSTRAINT PK_NHACUNGCAP_MANCC PRIMARY KEY(MaNCC),
TenNCC NVARCHAR(50),
TenGiaoDich NVARCHAR(20),
DiaChi NVARCHAR(50),
DienThoai CHAR(11),
Fax VARCHAR(15),
Email VARCHAR(30)
)

CREATE TABLE NHANVIEN
(
MaNV CHAR(4) NOT NULL,
HoTen NVARCHAR(40) NOT NULL,
NgaySinh DATE CHECK ( NgaySinh<GETDATE()),
GioiTinh CHAR(1) DEFAULT 'M' CHECK (GioiTinh IN ('M', 'F')),
NgayVaoLam DATE NOT NULL DEFAULT GETDATE() CHECK (NgayVaoLam <= GETDATE()),
DiaChi NVARCHAR(60),
DienThoai CHAR(11),
LuongCoban NUMERIC(10,2) NOT NULL CHECK (LuongCoban>0),
PhuCap NUMERIC(10,2) DEFAULT 0 CHECK (PhuCap>=0),
CONSTRAINT PK_NHANVIEN_MAKH PRIMARY KEY(MaNV)
)
CREATE TABLE DONDATHANG
(
SoHD INT NOT NULL,
MaKH CHAR(7) NOT NULL,
MaNV CHAR(4) NOT NULL ,
NgayDatHang DATE DEFAULT GETDATE(),
NgayGiaoHang DATE,
NgayChuyenHang DATE,
NoiGiaoHang NVARCHAR(80),
)
--tao khoa ngoai cho bang DONDATHANG
ALTER TABLE dbo.DONDATHANG
ADD CONSTRAINT PK_DDH_SoHD PRIMARY KEY(SoHD)
ALTER TABLE dbo.DONDATHANG
ADD CONSTRAINT FK_DDH_MAKH FOREIGN KEY(MaKH) REFERENCES dbo.KHACHHANG(MaKH) 
ON DELETE CASCADE 
ON UPDATE CASCADE
ALTER TABLE dbo.DONDATHANG 
ADD CONSTRAINT FK_DDH_MANV FOREIGN KEY (MaNV) REFERENCES dbo.NHANVIEN(MaNV)
ON DELETE CASCADE
ON UPDATE CASCADE
CREATE TABLE LOAIHANG
(
MaLH CHAR(2) NOT NULL,
TenLoaiHang NVARCHAR(100) NOT NULL,
CONSTRAINT PK_LOAIHANG_MALH PRIMARY KEY(MaLH)
)
CREATE TABLE MATHANG
(
MaHang CHAR(4) NOT NULL,
TenHang NVARCHAR(100) NOT NULL,
MaNCC CHAR(3) NOT NULL,
MaLH CHAR(2) NOT NULL,
SoLuong INT DEFAULT 1,
CONSTRAINT CHK_SOLUONG CHECK(SoLuong>=0),
DonViTinh NVARCHAR(10),
GiaHang NUMERIC(10,2) CHECK (GiaHang>=0),
CONSTRAINT PK_MATHANG_MAHANG PRIMARY KEY (MaHang),
CONSTRAINT FK_MATHANG_MANCC FOREIGN KEY(MaNCC) REFERENCES NHACUNGCAP(MaNCC)
ON DELETE CASCADE
ON UPDATE CASCADE
)
CREATE TABLE CHITIETDATHANG
(
SoHD INT NOT NULL,
MaHang CHAR(4) NOT NULL,
GiaBan NUMERIC (10,2) CHECK(GiaBan>0),
SoLuong INT DEFAULT 1 CHECK(SoLuong>0),
ChietKhau NUMERIC(10,2) CHECK(ChietKhau>0),
CONSTRAINT PK_CTDH_SOHD_MAHANG PRIMARY KEY(SoHD, MaHang),
CONSTRAINT FK_CTDH_SOHD FOREIGN KEY(SoHD) REFERENCES DONDATHANG(SoHD)
ON DELETE CASCADE
ON UPDATE CASCADE,
CONSTRAINT FK_CTDH_MAHANG FOREIGN KEY(MaHang) REFERENCES MATHANG(MaHang)
ON DELETE CASCADE
ON UPDATE CASCADE,
 
)
ALTER TABLE NHANVIEN
ADD CONSTRAINT TUOILV CHECK (YEAR(NgayVaoLam)-YEAR(NgaySinh)>=18)
ALTER TABLE MATHANG 
ADD CONSTRAINT FK_MATHANG_MALH FOREIGN KEY(MaLH) REFERENCES LOAIHANG(MaLH)
ON DELETE CASCADE
ON UPDATE CASCADE
ALTER TABLE LOAIHANG
ADD GhiChu NVARCHAR(100)
ALTER TABLE LOAIHANG 
ALTER COLUMN GhiChu VARCHAR(50)
ALTER TABLE LOAIHANG
DROP COLUMN GhiChu
GO
-- da hoan thanh
SET DATEFORMAT DMY -- dinh dang kieu datetime
--nhap du lieu cho bang loai hang
INSERT INTO dbo.LOAIHANG
        ( MaLH, TenLoaiHang )
VALUES  ( 'TP', -- MaLH - char(2)
          N'Thực Phẩm'  -- TenLoaiHang - nvarchar(100)
          )
INSERT INTO dbo.LOAIHANG
        ( MaLH, TenLoaiHang )
VALUES  ( 'DT', -- MaLH - char(2)
          N'Điện tử'  -- TenLoaiHang - nvarchar(100)
          )
INSERT INTO dbo.LOAIHANG
        ( MaLH, TenLoaiHang )
VALUES  ( 'MM', -- MaLH - char(2)
          N'May mặc'  -- TenLoaiHang - nvarchar(100)
          )
INSERT INTO dbo.LOAIHANG
        ( MaLH, TenLoaiHang )
VALUES  ( 'NT', -- MaLH - char(2)
          N'Nội thất'  -- TenLoaiHang - nvarchar(100)
          )
INSERT INTO dbo.LOAIHANG
        ( MaLH, TenLoaiHang )
VALUES  ( 'VP', -- MaLH - char(2)
          N'Văn Phòng'  -- TenLoaiHang - nvarchar(100)
          )
		  --xong
--nhap du lieu  bang khach hang
INSERT INTO dbo.KHACHHANG
        ( MaKH ,
          TenKH ,
          TenGiaoDich ,
          DiaChi ,
          Email ,
          DienThoai ,
          Fax
        )
VALUES  ( 'KH0001' , -- MaKH - char(7)
          N'Cửa hàng thiên kim' , -- TenKH - nvarchar(50)
          N'THIENKIM' , -- TenGiaoDich - nvarchar(20)
          N'Nha Trang' , -- DiaChi - nvarchar(80)
          'thienkim@nhatrang.com' , -- Email - varchar(30)
          '02583891135     ' , -- DienThoai - char(11)
          ''  -- Fax - varchar(15)
        )
INSERT INTO dbo.KHACHHANG
        ( MaKH ,
          TenKH ,
          TenGiaoDich ,
          DiaChi ,
          Email ,
          DienThoai ,
          Fax
        )
VALUES  ( 'KH0002' , -- MaKH - char(7)
          N'Nhà sách Bảo Bình' , -- TenKH - nvarchar(50)
          N'BAOBINH' , -- TenGiaoDich - nvarchar(20)
          N'Sài Gòn' , -- DiaChi - nvarchar(80)
          'Baobinh@vietnam.com' , -- Email - varchar(30)
          '0833808803' , -- DienThoai - char(11)
          ''  -- Fax - varchar(15)
        )
INSERT INTO dbo.KHACHHANG
        ( MaKH ,
          TenKH ,
          TenGiaoDich ,
          DiaChi ,
          Email ,
          DienThoai ,
          Fax
        )
VALUES  ( 'KH0003' , -- MaKH - char(7)
          N'Đại lí sữa NUTRIFOOD ĐN' , -- TenKH - nvarchar(50)
          N'NUTRIFOOD' , -- TenGiaoDich - nvarchar(20)
          N'Đà Nẵng' , -- DiaChi - nvarchar(80)
          'nutrifood@vietnam.com' , -- Email - varchar(30)
          '0436888888' , -- DienThoai - char(11)
          ''  -- Fax - varchar(15)
        )
INSERT INTO dbo.KHACHHANG
        ( MaKH ,
          TenKH ,
          TenGiaoDich ,
          DiaChi ,
          Email ,
          DienThoai ,
          Fax
        )
VALUES  ( 'KH0004' , -- MaKH - char(7)
          N'Thế giới di động' , -- TenKH - nvarchar(50)
          N'TGDD' , -- TenGiaoDich - nvarchar(20)
          N'Sài Gòn' , -- DiaChi - nvarchar(80)
          'tgdd@gmail.com' , -- Email - varchar(30)
          '0833898399' , -- DienThoai - char(11)
          ''  -- Fax - varchar(15)
        )
INSERT INTO dbo.KHACHHANG
        ( MaKH ,
          TenKH ,
          TenGiaoDich ,
          DiaChi ,
          Email ,
          DienThoai ,
          Fax
        )
VALUES  ( 'KH0005' , -- MaKH - char(7)
          N'Hãng hàng không VietJet' , -- TenKH - nvarchar(50)
          N'VIETJET' , -- TenGiaoDich - nvarchar(20)
          N'Hà Nội' , -- DiaChi - nvarchar(80)
          'vietjet@vietnam.com' , -- Email - varchar(30)
          '0436888888' , -- DienThoai - char(11)
          ''  -- Fax - varchar(15)
        )
INSERT INTO dbo.KHACHHANG
        ( MaKH ,
          TenKH ,
          TenGiaoDich ,
          DiaChi ,
          Email ,
          DienThoai ,
          Fax
        )
VALUES  ( 'KH0006' , -- MaKH - char(7)
          N'Đại lí văn phòng phẩm MICCOS' , -- TenKH - nvarchar(50)
          N'MICCOS' , -- TenGiaoDich - nvarchar(20)
          N'Hà Nội' , -- DiaChi - nvarchar(80)
          'miccos@vietnam.com' , -- Email - varchar(30)
          '0433804408' , -- DienThoai - char(11)
          ''  -- Fax - varchar(15)
        )
		--đã insert bang KHACHHANG
--nhập dữ liệu bảng  NHANVIEN
INSERT INTO dbo.NHANVIEN
        ( MaNV ,
          HoTen ,
          NgaySinh ,
          GioiTinh ,
          NgayVaoLam ,
          DiaChi ,
          DienThoai ,
          LuongCoban ,
          PhuCap
        )
VALUES  ( 'A001' , -- MaNV - char(4)
          N'Lê Thị Giang' , -- HoTen - nvarchar(40)
          '07/02/1990' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          '03/04/2013' , -- NgayVaoLam - date
          N'Nghệ An' , -- DiaChi - nvarchar(60)
          '0972647995' , -- DienThoai - char(11)
          6000000 , -- LuongCoban - numeric
          0  -- PhuCap - numeric
        )
INSERT INTO dbo.NHANVIEN
        ( MaNV ,
          HoTen ,
          NgaySinh ,
          GioiTinh ,
          NgayVaoLam ,
          DiaChi ,
          DienThoai ,
          LuongCoban ,
          PhuCap
        )
VALUES  ( 'H001' , -- MaNV - char(4)
          N'Lê Thị Hoa' , -- HoTen - nvarchar(40)
          '20/5/1986' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          '03/01/2013' , -- NgayVaoLam - date
          N'Đồng Nai' , -- DiaChi - nvarchar(60)
          '0988567432' , -- DienThoai - char(11)
          6300000, -- LuongCoban - numeric
          810000  -- PhuCap - numeric
        )
INSERT INTO dbo.NHANVIEN
        ( MaNV ,
          HoTen ,
          NgaySinh ,
          GioiTinh ,
          NgayVaoLam ,
          DiaChi ,
          DienThoai ,
          LuongCoban ,
          PhuCap
        )
VALUES  ( 'H002' , -- MaNV - char(4)
          N'Hồ Kim Giàu' , -- HoTen - nvarchar(40)
           '08/11/1987', -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          '03/04/2013' , -- NgayVaoLam - date
          N'Đà Nẵng' , -- DiaChi - nvarchar(60)
          '0905611725' , -- DienThoai - char(11)
          6000000 , -- LuongCoban - numeric
          750000  -- PhuCap - numeric
        )
INSERT INTO dbo.NHANVIEN
        ( MaNV ,
          HoTen ,
          NgaySinh ,
          GioiTinh ,
          NgayVaoLam ,
          DiaChi ,
          DienThoai ,
          LuongCoban ,
          PhuCap
        )
VALUES  ( 'H003' , -- MaNV - char(4)
          N'Trần Nguyễn Hoàng' , -- HoTen - nvarchar(40)
         '04/09/1985' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
         '03/01/2013' , -- NgayVaoLam - date
          N'Đà Nẵng' , -- DiaChi - nvarchar(60)
          '0987654245' , -- DienThoai - char(11)
          9600000 , -- LuongCoban - numeric
          0  -- PhuCap - numeric
        )
INSERT INTO dbo.NHANVIEN
        ( MaNV ,
          HoTen ,
          NgaySinh ,
          GioiTinh ,
          NgayVaoLam ,
          DiaChi ,
          DienThoai ,
          LuongCoban ,
          PhuCap
        )
VALUES  ( 'P001' , -- MaNV - char(4)
          N'Nguyễn Hoài Phong' , -- HoTen - nvarchar(40)
          '14/05/1991' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          '03/01/2013' , -- NgayVaoLam - date
          N'Quy Nhơn' , -- DiaChi - nvarchar(60)
          '0563891135' , -- DienThoai - char(11)
          5300000 , -- LuongCoban - numeric
          725000  -- PhuCap - numeric
        )
INSERT INTO dbo.NHANVIEN
        ( MaNV ,
          HoTen ,
          NgaySinh ,
          GioiTinh ,
          NgayVaoLam ,
          DiaChi ,
          DienThoai ,
          LuongCoban ,
          PhuCap
        )
VALUES  ( 'Q001' , -- MaNV - char(4)
          N'Trương Thị Trang' , -- HoTen - nvarchar(40)
          '06/01/1987' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          '03/01/2013' , -- NgayVaoLam - date
          N'Nha Trang' , -- DiaChi - nvarchar(60)
          '0979792176' , -- DienThoai - char(11)
          10000000 , -- LuongCoban - numeric
          500000  -- PhuCap - numeric
        )
INSERT INTO dbo.NHANVIEN
        ( MaNV ,
          HoTen ,
          NgaySinh ,
          GioiTinh ,
          NgayVaoLam ,
          DiaChi ,
          DienThoai ,
          LuongCoban ,
          PhuCap
        )
VALUES  ( 'T001' , -- MaNV - char(4)
          N'Nguyễn Đức Thắng' , -- HoTen - nvarchar(40)
          '25/08/1988' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          '03/04/2013' , -- NgayVaoLam - date
          N'Nha Trang' , -- DiaChi - nvarchar(60)
          '0955593893' , -- DienThoai - char(11)
          5750000 , -- LuongCoban - numeric
          0  -- PhuCap - numeric
        )
INSERT INTO dbo.NHANVIEN
        ( MaNV ,
          HoTen ,
          NgaySinh ,
          GioiTinh ,
          NgayVaoLam ,
          DiaChi ,
          DienThoai ,
          LuongCoban ,
          PhuCap
        )
VALUES  ( 'D001' , -- MaNV - char(4)
          N'Nguyễn Minh Đăng' , -- HoTen - nvarchar(40)
          '12/02/1989' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          '03/01/2013' , -- NgayVaoLam - date
          N'Hải Dương' , -- DiaChi - nvarchar(60)
          '0905779919' , -- DienThoai - char(11)
          12000000 , -- LuongCoban - numeric
          1200000  -- PhuCap - numeric
        )
INSERT INTO dbo.NHANVIEN
        ( MaNV ,
          HoTen ,
          NgaySinh ,
          GioiTinh ,
          NgayVaoLam ,
          DiaChi ,
          DienThoai ,
          LuongCoban ,
          PhuCap
        )
VALUES  ( 'M001' , -- MaNV - char(4)
          N'Hồ Thị Mai' , -- HoTen - nvarchar(40)
          '09/11/1987' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          '03/04/2009' , -- NgayVaoLam - date
          N'Ninh Bình' , -- DiaChi - nvarchar(60)
          '0968675457' , -- DienThoai - char(11)
          5000000 , -- LuongCoban - numeric
          500000  -- PhuCap - numeric
        )
-- đã insert bảng NHANVIEN
--Nhập dữ liệu bảng NHACUNGCAP
INSERT INTO dbo.NHACUNGCAP
        ( MaNCC ,
          TenNCC ,
          TenGiaoDich ,
          DiaChi ,
          DienThoai ,
          Fax ,
          Email
        )
VALUES  ( 'THM' , -- MaNCC - char(3)
          N'Công ty sữa Việt Nam' , -- TenNCC - nvarchar(50)
          N'THMILK' , -- TenGiaoDich - nvarchar(20)
          N'Nghệ An' , -- DiaChi - nvarchar(50)
          '0433891135' , -- DienThoai - char(11)
          '' , -- Fax - varchar(15)
          'thmilk@vietnam.com'  -- Email - varchar(30)
        )
INSERT INTO dbo.NHACUNGCAP
        ( MaNCC ,
          TenNCC ,
          TenGiaoDich ,
          DiaChi ,
          DienThoai ,
          Fax ,
          Email
        )
VALUES  ( 'MAP' , -- MaNCC - char(3)
          N'Công ty may mặc An Phước' , -- TenNCC - nvarchar(50)
          N'ANPHUOC' , -- TenGiaoDich - nvarchar(20)
          N'Sài Gòn' , -- DiaChi - nvarchar(50)
          '0833808803' , -- DienThoai - char(11)
          '' , -- Fax - varchar(15)
          'ANPHUOC@vietnam.com'  -- Email - varchar(30)
        )
INSERT INTO dbo.NHACUNGCAP
        ( MaNCC ,
          TenNCC ,
          TenGiaoDich ,
          DiaChi ,
          DienThoai ,
          Fax ,
          Email
        )
VALUES  ( 'SCM' , -- MaNCC - char(3)
          N'Siêu thị Coop-mart' , -- TenNCC - nvarchar(50)
          N'COOPMART' , -- TenGiaoDich - nvarchar(20)
          N'Sài Gòn' , -- DiaChi - nvarchar(50)
          '0833888666' , -- DienThoai - char(11)
          '' , -- Fax - varchar(15)
          'coopmart@vietnam.com'  -- Email - varchar(30)
        )
INSERT INTO dbo.NHACUNGCAP
        ( MaNCC ,
          TenNCC ,
          TenGiaoDich ,
          DiaChi ,
          DienThoai ,
          Fax ,
          Email
        )
VALUES  ( 'DQV' , -- MaNCC - char(3)
          N'Công ty máy tính Quang Vũ' , -- TenNCC - nvarchar(50)
          N'QUANGVU' , -- TenGiaoDich - nvarchar(20)
          N'Quy Nhơn' , -- DiaChi - nvarchar(50)
          '0563888777' , -- DienThoai - char(11)
          '' , -- Fax - varchar(15)
          'quangvu@vietnam.com'  -- Email - varchar(30)
        )
INSERT INTO dbo.NHACUNGCAP
        ( MaNCC ,
          TenNCC ,
          TenGiaoDich ,
          DiaChi ,
          DienThoai ,
          Fax ,
          Email
        )
VALUES  ( 'DAF' , -- MaNCC - char(3)
          N'Nội thất Đài Loan Dafuco' , -- TenNCC - nvarchar(50)
          N'DAFUCO' , -- TenGiaoDich - nvarchar(20)
          N'Đà Nẵng' , -- DiaChi - nvarchar(50)
          '0473888111' , -- DienThoai - char(11)
          '' , -- Fax - varchar(15)
          'dafuco@vietnam.com'  -- Email - varchar(30)
        )
INSERT INTO dbo.NHACUNGCAP
        ( MaNCC ,
          TenNCC ,
          TenGiaoDich ,
          DiaChi ,
          DienThoai ,
          Fax ,
          Email
        )
VALUES  ( 'GOL' , -- MaNCC - char(3)
          N'Công ty GOLDEN' , -- TenNCC - nvarchar(50)
          N'GOLDEN' , -- TenGiaoDich - nvarchar(20)
          N'Quy Nhơn' , -- DiaChi - nvarchar(50)
          '0563891135' , -- DienThoai - char(11)
          '' , -- Fax - varchar(15)
          'golden@vietnam.com'  -- Email - varchar(30)
        )
		-- đã insert
--nhập dữ liệu bảng mặt hàng
INSERT INTO dbo.MATHANG
        ( MaHang ,
          TenHang ,
          MaNCC ,
          MaLH ,
          SoLuong ,
          DonViTinh ,
          GiaHang
        )
VALUES  ( '' , -- MaHang - char(4)
          N'' , -- TenHang - nvarchar(100)
          '' , -- MaNCC - char(3)
          '' , -- MaLH - char(2)
          0 , -- SoLuong - int
          N'' , -- DonViTinh - nvarchar(10)
          NULL  -- GiaHang - numeric
        )