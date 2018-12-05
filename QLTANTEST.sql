CREATE DATABASE QLTANtest2
GO
USE QLTANtest2
GO
CREATE TABLE Luong --Mức lương cơ bản = Mức lương cơ sở x Hệ số lương
(
BacLuong INT NOT NULL CHECK (BacLuong>0),
LuongCoSo NUMERIC(10,2),
HeSoLuong INT DEFAULT 1 CHECK (HeSoLuong>0),
PRIMARY KEY (BacLuong)
)
GO
CREATE TABLE NhanVien
(
IDNhanVien CHAR(8) NOT NULL,
TenNhanVien NVARCHAR(30) NOT NULL,
NgaySinh DATE CHECK ((YEAR(GETDATE())-YEAR(NgaySinh))>=18),
GioiTinh CHAR(1) DEFAULT 'M' CHECK (GioiTinh IN ('M','F')),
DiaChi NVARCHAR(50),
PhuCap NUMERIC(10,2),
Sdt CHAR(10),
BacLuong INT NOT NULL CHECK (BacLuong>0),
PRIMARY KEY (IDNhanVien),
FOREIGN KEY (BacLuong) REFERENCES dbo.Luong(BacLuong)
)
GO
CREATE TABLE MonAn
(
MaMon CHAR(8) NOT NULL,
TenMon NVARCHAR(30) NOT NULL,
DonGia NUMERIC(10,2),
DonViTinh NVARCHAR(10),
PRIMARY KEY (MaMon)
)
GO

CREATE TABLE DonHang
(

MaDonHang CHAR(8) PRIMARY KEY NOT NULL,
MaMon CHAR(8) NOT NULL,
SoLuong INT CHECK(SoLuong>0),
GhiChu NVARCHAR(30),

FOREIGN KEY (MaMon) REFERENCES dbo.MonAn(MaMon),

)
GO
CREATE TABLE HoaDon
(
MaHoaDon CHAR(8) NOT NULL,
MaDonHang CHAR(8) NOT NULL,
IDNhanVien CHAR(8) NOT NULL,
ThoiGian DATETIME2,
PRIMARY KEY (MaHoaDon),
FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien),
FOREIGN KEY (MaDonHang) REFERENCES dbo.DonHang(MaDonHang)
)
GO
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000001', -- MaMon - char(8)
          N'cánh gà chiên', -- TenMon - nvarchar(30)
          47000, -- DonGia - numeric
          N'3 cái'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000002', -- MaMon - char(8)
          'cánh gà chiên', -- TenMon - varchar(30)
          69000, -- DonGia - numeric
          N'5 miếng'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000003', -- MaMon - char(8)
          'khoai tây chiên', -- TenMon - varchar(30)
          12000, -- DonGia - numeric
          N'vừa'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000004', -- MaMon - char(8)
          'khoai tây chiên', -- TenMon - varchar(30)
          25000, -- DonGia - numeric
          N'lớn'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000005', -- MaMon - char(8)
          'khoai tây chiên', -- TenMon - varchar(30)
          35000, -- DonGia - numeric
          N'đại'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000006', -- MaMon - char(8)
          'khoai tây nghiền', -- TenMon - varchar(30)
          10000, -- DonGia - numeric
          N'vừa'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000007', -- MaMon - char(8)
          'khoai tây nghiền', -- TenMon - varchar(30)
          10000, -- DonGia - numeric
          N'lớn'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000008', -- MaMon - char(8)
          'khoai tây nghiền', -- TenMon - varchar(30)
          10000, -- DonGia - numeric
          N'đại'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000009', -- MaMon - char(8)
          'cơm gà ', -- TenMon - varchar(30)
          39000, -- DonGia - numeric
          N'dĩa'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000010', -- MaMon - char(8)
          'cơm phile gà quay tiêu', -- TenMon - varchar(30)
          39000, -- DonGia - numeric
          N'dĩa'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000011', -- MaMon - char(8)
          'cơm phile gà quay flava', -- TenMon - varchar(30)
          39000, -- DonGia - numeric
          N'dĩa'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F000012', -- MaMon - char(8)
          'bơ gơ ocean', -- TenMon - varchar(30)
          22000, -- DonGia - numeric
          N'cái'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000013', -- MaMon - char(8)
          'bơ gơ tôm', -- TenMon - varchar(30)
          39000, -- DonGia - numeric
          N'cái'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000014', -- MaMon - char(8)
          'bơ gơ gà quay flava', -- TenMon - varchar(30)
          45000, -- DonGia - numeric
          N'cái'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F0000015', -- MaMon - char(8)
          'bơ gơ zinger', -- TenMon - varchar(30)
          49000, -- DonGia - numeric
          N'cái'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'D0000001', -- MaMon - char(8)
          'Pepsi tươi', -- TenMon - varchar(30)
          10000, -- DonGia - numeric
          N'ly nhỏ'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'D0000002', -- MaMon - char(8)
          'Pepsi tươi', -- TenMon - varchar(30)
          17000, -- DonGia - numeric
          N'ly lớn'  -- DonViTinh - nvarchar(10)
          )
-- đã insert
INSERT INTO dbo.Luong
        ( BacLuong, LuongCoSo, HeSoLuong )
VALUES  ( 1, -- BacLuong - int
          1390000, -- LuongCoSo - numeric
          1  -- HeSoLuong - int
          )
		  go
INSERT INTO dbo.Luong
        ( BacLuong, LuongCoSo, HeSoLuong )
VALUES  ( 2, -- BacLuong - int
          1435000, -- LuongCoSo - numeric
          2  -- HeSoLuong - int
          )
		  go
INSERT INTO dbo.Luong
        ( BacLuong, LuongCoSo, HeSoLuong )
VALUES  ( 3, -- BacLuong - int
          1523000, -- LuongCoSo - numeric
          3  -- HeSoLuong - int
          )
		  go
INSERT INTO dbo.Luong
        ( BacLuong, LuongCoSo, HeSoLuong )
VALUES  ( 4, -- BacLuong - int
          1639000, -- LuongCoSo - numeric
          4  -- HeSoLuong - int
          )
		  go
--đã insert
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt ,
          BacLuong
        )
VALUES  ( 'NV000001' , -- IDNhanVien - char(8)
          N'Nguyễn Hoài An' , -- TenNhanVien - nvarchar(30)
          '1973-02-15' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'25/3 Lạc Long Quân, Q.10,TP HCM' , -- DiaChi - nvarchar(50)
          '0824806888' , -- Sdt - char(10)
          1  -- BacLuong - int
        )
		go
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt ,
          BacLuong
        )
VALUES  ( 'NV000002' , -- IDNhanVien - char(8)
          N'Trần Trà Hương' , -- TenNhanVien - nvarchar(30)
          '1960-06-20' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'125 Trần Hưng Đạo, Q.1, TP HCM' , -- DiaChi - nvarchar(50)
          '0824800999' , -- Sdt - char(10)
          1  -- BacLuong - int
        )
		go
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt ,
          BacLuong
        )
VALUES  ( 'NV000003' , -- IDNhanVien - char(8)
          N'Nguyễn Ngọc Ánh' , -- TenNhanVien - nvarchar(30)
          '1975-05-11' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'12/21 Võ Văn Ngân Thủ Đức, TP HCM' , -- DiaChi - nvarchar(50)
          '0824722888' , -- Sdt - char(10)
          1  -- BacLuong - int
        )
go
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt ,
          BacLuong
        )
VALUES  ( 'NV000004' , -- IDNhanVien - char(8)
          N'Trương Nam Sơn' , -- TenNhanVien - nvarchar(30)
          '1959-06-20' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'215 Lý Thường Kiệt,TP Biên Hòa' , -- DiaChi - nvarchar(50)
          '0824684999' , -- Sdt - char(10)
          1  -- BacLuong - int
        )
go
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt ,
          BacLuong
        )
VALUES  ( 'NV000005' , -- IDNhanVien - char(8)
          N'Lý Hoàng Hà' , -- TenNhanVien - nvarchar(30)
          '1954-10-23' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'22/5 Nguyễn Xí, Q.Bình Thạnh, TP HCM' , -- DiaChi - nvarchar(50)
          '0843546888' , -- Sdt - char(10)
          1  -- BacLuong - int
        )
go
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt ,
          BacLuong
        )
VALUES  ( 'NV000006' , -- IDNhanVien - char(8)
          N'Trần Bạch Tuyết' , -- TenNhanVien - nvarchar(30)
         '1980-05-20' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'127 Hùng Vương, TP Mỹ Tho' , -- DiaChi - nvarchar(50)
          '0973206878' , -- Sdt - char(10)
          1  -- BacLuong - int
        )
go
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt ,
          BacLuong
        )
VALUES  ( 'NV000007' , -- IDNhanVien - char(8)
          N'Nguyễn An Trung' , -- TenNhanVien - nvarchar(30)
          '1976-06-05' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'234 3/2, TP Biên Hòa' , -- DiaChi - nvarchar(50)
          '0975636353' , -- Sdt - char(10)
          2  -- BacLuong - int
        )
go
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt ,
          BacLuong
        )
VALUES  ( 'NV000008' , -- IDNhanVien - char(8)
          N'Trần Hoàng Nam' , -- TenNhanVien - nvarchar(30)
          '1975-11-22' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'234 Trấn Não,An Phú, TP HCM' , -- DiaChi - nvarchar(50)
          '0977375179' , -- Sdt - char(10)
          1  -- BacLuong - int
        )
go
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt ,
          BacLuong
        )
VALUES  ( 'NV000009' , -- IDNhanVien - char(8)
          N'Phạm Nam Thanh' , -- TenNhanVien - nvarchar(30)
         '1980-12-12' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'221 Hùng Vương,Q.5, TP HCM' , -- DiaChi - nvarchar(50)
          '0972567079' , -- Sdt - char(10)
          2  -- BacLuong - int
        )
go
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt ,
          BacLuong
        )
VALUES  ( 'NV000010' , -- IDNhanVien - char(8)
          N'Nguyễn Quang Hùng' , -- TenNhanVien - nvarchar(30)
          '1990-01-14' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'289 Hai Bà Trưng, phường 8, quận 3, TP HCM' , -- DiaChi - nvarchar(50)
          '0975261579' , -- Sdt - char(10)
          1  -- BacLuong - int
        )
GO
-- đã insert
INSERT INTO dbo.DonHang
        ( MaDonHang, MaMon, SoLuong, GhiChu )
VALUES  ( 'DH000001', -- MaDonHang - char(8)
          'F0000001', -- MaMon - char(8)
          2, -- SoLuong - int
          N''  -- GhiChu - nvarchar(30)
          )
go
INSERT INTO dbo.DonHang
        ( MaDonHang, MaMon, SoLuong, GhiChu )
VALUES  ( 'DH000002', -- MaDonHang - char(8)
          'F0000006', -- MaMon - char(8)
          2, -- SoLuong - int
          N''  -- GhiChu - nvarchar(30)
          )
		  go
INSERT INTO dbo.DonHang
        ( MaDonHang, MaMon, SoLuong, GhiChu )
VALUES  ( 'DH000003', -- MaDonHang - char(8)
          'D0000001', -- MaMon - char(8)
          2, -- SoLuong - int
          N''  -- GhiChu - nvarchar(30)
          )
		  go
INSERT INTO dbo.DonHang
        ( MaDonHang, MaMon, SoLuong, GhiChu )
VALUES  ( 'DH000004', -- MaDonHang - char(8)
          'F0000009', -- MaMon - char(8)
          1, -- SoLuong - int
          N'chỉ gà chiên'  -- GhiChu - nvarchar(30)
          )
		  go
INSERT INTO dbo.DonHang
        ( MaDonHang, MaMon, SoLuong, GhiChu )
VALUES  ( 'DH000005', -- MaDonHang - char(8)
          'D0000002', -- MaMon - char(8)
          1, -- SoLuong - int
          N''  -- GhiChu - nvarchar(30)
          )
		  go
INSERT INTO dbo.DonHang
        ( MaDonHang, MaMon, SoLuong, GhiChu )
VALUES  ( 'DH000006', -- MaDonHang - char(8)
          'F0000010', -- MaMon - char(8)
          10, -- SoLuong - int
          N'ít cay'  -- GhiChu - nvarchar(30)
          )
		  go
INSERT INTO dbo.DonHang
        ( MaDonHang, MaMon, SoLuong, GhiChu )
VALUES  ( 'DH000007', -- MaDonHang - char(8)
          'F0000006', -- MaMon - char(8)
          1, -- SoLuong - int
          N''  -- GhiChu - nvarchar(30)
          )
		  go
INSERT INTO dbo.DonHang
        ( MaDonHang, MaMon, SoLuong, GhiChu )
VALUES  ( 'DH000008', -- MaDonHang - char(8)
          'F0000013', -- MaMon - char(8)
          5, -- SoLuong - int
          N''  -- GhiChu - nvarchar(30)
          )
		  go
INSERT INTO dbo.DonHang
        ( MaDonHang, MaMon, SoLuong, GhiChu )
VALUES  ( 'DH000009', -- MaDonHang - char(8)
          'F0000015', -- MaMon - char(8)
          20, -- SoLuong - int
          N''  -- GhiChu - nvarchar(30)
          )
		  go
INSERT INTO dbo.DonHang
        ( MaDonHang, MaMon, SoLuong, GhiChu )
VALUES  ( 'DH000010', -- MaDonHang - char(8)
          'D0000002', -- MaMon - char(8)
          20, -- SoLuong - int
          N''  -- GhiChu - nvarchar(30)
          )
		  GO
INSERT dbo.HoaDon
        ( MaHoaDon ,
          MaDonHang ,
          IDNhanVien ,
          ThoiGian
        )
VALUES  ( 'HD000001' , -- MaHoaDon - char(8)
          'DH000001' , -- MaDonHang - char(8)
          'NV000001' , -- IDNhanVien - char(8)
          GETDATE()  -- ThoiGian - datetime2
        )          
INSERT dbo.HoaDon
        ( MaHoaDon ,
          MaDonHang ,
          IDNhanVien ,
          ThoiGian
        )
VALUES  ( 'HD000002' , -- MaHoaDon - char(8)
          'DH000003' , -- MaDonHang - char(8)
          'NV000001' , -- IDNhanVien - char(8)
          GETDATE()  -- ThoiGian - datetime2
        )
		
INSERT dbo.HoaDon
        ( MaHoaDon ,
          MaDonHang ,
          IDNhanVien ,
          ThoiGian
        )
VALUES  ( 'HD000003' , -- MaHoaDon - char(8)
          'DH000004' , -- MaDonHang - char(8)
          'NV000001' , -- IDNhanVien - char(8)
          GETDATE()  -- ThoiGian - datetime2
        )
		--đã insert
INSERT dbo.HoaDon
        ( MaHoaDon ,
          MaDonHang ,
          IDNhanVien ,
          ThoiGian
        )
VALUES  ( 'HD000005' , -- MaHoaDon - char(8)
          'DH000002' , -- MaDonHang - char(8)
          'NV000001' , -- IDNhanVien - char(8)
          GETDATE()  -- ThoiGian - datetime2
        )
INSERT dbo.HoaDon
        ( MaHoaDon ,
          MaDonHang ,
          IDNhanVien ,
          ThoiGian
        )
VALUES  ( 'HD000006' , -- MaHoaDon - char(8)
          'DH000010' , -- MaDonHang - char(8)
          'NV000001' , -- IDNhanVien - char(8)
          GETDATE()  -- ThoiGian - datetime2
        )
INSERT dbo.HoaDon
        ( MaHoaDon ,
          MaDonHang ,
          IDNhanVien ,
          ThoiGian
        )
VALUES  ( 'HD000007' , -- MaHoaDon - char(8)
          'DH000008' , -- MaDonHang - char(8)
          'NV000001' , -- IDNhanVien - char(8)
          GETDATE()  -- ThoiGian - datetime2
        )
INSERT dbo.HoaDon
        ( MaHoaDon ,
          MaDonHang ,
          IDNhanVien ,
          ThoiGian
        )
VALUES  ( 'HD000008' , -- MaHoaDon - char(8)
          'DH000009' , -- MaDonHang - char(8)
          'NV000001' , -- IDNhanVien - char(8)
          GETDATE()  -- ThoiGian - datetime2
        )
INSERT dbo.HoaDon
        ( MaHoaDon ,
          MaDonHang ,
          IDNhanVien ,
          ThoiGian
        )
VALUES  ( 'HD000009' , -- MaHoaDon - char(8)
          'DH000006' , -- MaDonHang - char(8)
          'NV000001' , -- IDNhanVien - char(8)
          GETDATE()  -- ThoiGian - datetime2
        )
INSERT dbo.HoaDon
        ( MaHoaDon ,
          MaDonHang ,
          IDNhanVien ,
          ThoiGian
        )
VALUES  ( 'HD000010' , -- MaHoaDon - char(8)
          'DH000007' , -- MaDonHang - char(8)
          'NV000001' , -- IDNhanVien - char(8)
          GETDATE()  -- ThoiGian - datetime2
        )
INSERT INTO dbo.HoaDon
        ( MaHoaDon ,
          MaDonHang ,
          IDNhanVien ,
          ThoiGian
        )
VALUES  ( 'DH000004' , -- MaHoaDon - char(8)
          'DH000005' , -- MaDonHang - char(8)
          'NV000003' , -- IDNhanVien - char(8)
          GETDATE()  -- ThoiGian - datetime2
        )
--thêm dữ liệu cho cột phụ cấp
UPDATE dbo.NhanVien SET PhuCap = 234000 WHERE (IDNhanVien='NV000001')
go
UPDATE dbo.NhanVien SET PhuCap = 500000 WHERE (IDNhanVien='NV000002')
go
UPDATE dbo.NhanVien SET PhuCap = 142000 WHERE (IDNhanVien='NV000003')
go
UPDATE dbo.NhanVien SET PhuCap = 356000 WHERE (IDNhanVien='NV000004')
go
UPDATE dbo.NhanVien SET PhuCap = 132000 WHERE (IDNhanVien='NV000005')
go
UPDATE dbo.NhanVien SET PhuCap = 145000 WHERE (IDNhanVien='NV000006')
go
UPDATE dbo.NhanVien SET PhuCap = 274000 WHERE (IDNhanVien='NV000007')
go
UPDATE dbo.NhanVien SET PhuCap = 265000 WHERE (IDNhanVien='NV000008')
go
UPDATE dbo.NhanVien SET PhuCap = 148000 WHERE (IDNhanVien='NV000009')
go
UPDATE dbo.NhanVien SET PhuCap = 178000WHERE (IDNhanVien='NV000010')
go
SELECT * FROM dbo.DonHang
SELECT * FROM dbo.MonAn
SELECT * FROM dbo.NhanVien
SELECT * FROM dbo.HoaDon
USE QLTANtest2
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          TenNhanVien,
		  BacLuong
          
        )
VALUES  ( 'NV000013' , -- IDNhanVien - char(8)
          N'Cô Hiền',  -- TenNhanVien - nvarchar(30)
          1
        )
