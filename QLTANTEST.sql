CREATE DATABASE QLTAN_GITHUB1
go
USE QLTAN_GITHUB1
GO

CREATE TABLE NhanVien
(
IDNhanVien CHAR(4) NOT NULL,
HoNhanVien NVARCHAR(30) NOT NULL,
TenNhanVien NVARCHAR(30) NOT NULL,
NgaySinh DATE CHECK ((YEAR(GETDATE())-YEAR(NgaySinh))>=18),
GioiTinh CHAR(1) DEFAULT 'M' CHECK (GioiTinh IN ('M','F')),
DiaChi NVARCHAR(50),
Sdt CHAR(10),
CONSTRAINT PK_NV PRIMARY KEY (IDNhanVien)

)
GO
CREATE TABLE Luong --Lương tháng = (Lương + Phụ cấp (nếu có) / ngày công chuẩn của tháng)x Số ngày làm việc thực tế
(
SttLuong CHAR(2) NOT NULL,
IDNhanVien CHAR(4) NOT NULL,
Luong NUMERIC(10,2) NOT NULL,
Thang INT NOT NULL,
NgayCong INT DEFAULT 26,
SoNgayLamViec INT,
PhuCap NUMERIC(10,2),
CONSTRAINT PK_Long PRIMARY KEY (SttLuong),
CONSTRAINT FK_Luong_NV FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(IDNhanVien)
ON DELETE CASCADE
ON UPDATE CASCADE

)
GO
CREATE TABLE MonAn
(
MaMon CHAR(4) NOT NULL,
TenMon NVARCHAR(30) NOT NULL,
DonGia NUMERIC(10,2),
DonViTinh NVARCHAR(10),
PRIMARY KEY (MaMon)
)
GO
CREATE TABLE HoaDon
(
MaDonHang CHAR(4) NOT NULL,
IDNhanVien CHAR(4) NOT NULL,
ThoiGian DATETIME,
CONSTRAINT PK_HD_MDH PRIMARY KEY (MaDonHang),
CONSTRAINT FK_HD_NV FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(IDNhanVien)
ON DELETE CASCADE
ON UPDATE CASCADE
)
CREATE TABLE DonHang
(
STT INT NOT NULL,
MaDonHang CHAR(4)  NOT NULL,
MaMon CHAR(4) NOT NULL,
SoLuong INT CHECK(SoLuong>0),
GhiChu NVARCHAR(30),
CONSTRAINT PK_DH PRIMARY KEY (STT),
CONSTRAINT FK_DH_HD FOREIGN KEY (MaDonHang) REFERENCES HoaDon(MaDonHang),
CONSTRAINT FK_DH_MA FOREIGN KEY (MaMon) REFERENCES MonAn(MaMon)

)
GO

INSERT INTO dbo.NhanVien
        
VALUES  ( 'NV01' , -- IDNhanVien - char(4)
			N'Nguyễn',
          N' Hoài An' , -- TenNhanVien - nvarchar(30)
          '1973-02-15'  , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'25/3 Lạc Long Quân, Q.10,TP HCM' , -- DiaChi - nvarchar(50)
          '0824806888'  -- Sdt - char(10)
        )
INSERT INTO dbo.NhanVien
        
VALUES  ( 'NV02' , -- IDNhanVien - char(8)
N'Trần',
          N'Trà Hương' , -- TenNhanVien - nvarchar(30)
          '1960-06-20' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'125 Trần Hưng Đạo, Q.1, TP HCM' , -- DiaChi - nvarchar(50)
          '0824800999' -- Sdt - char(10)
          
        )
		go
INSERT INTO dbo.NhanVien
        
VALUES  ( 'NV03' , -- IDNhanVien - char(8)
N'Nguyễn',
          N'Ngọc Ánh' , -- TenNhanVien - nvarchar(30)
          '1975-05-11' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'12/21 Võ Văn Ngân Thủ Đức, TP HCM' , -- DiaChi - nvarchar(50)
          '0824722888'  -- Sdt - char(10)
          
        )
go
INSERT INTO dbo.NhanVien
        
VALUES  ( 'NV04' , -- IDNhanVien - char(8)
N'Trương',
          N'Nam Sơn' , -- TenNhanVien - nvarchar(30)
          '1959-06-20' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'215 Lý Thường Kiệt,TP Biên Hòa' , -- DiaChi - nvarchar(50)
          '0824684999'  -- Sdt - char(10)
        
        )
go
INSERT INTO dbo.NhanVien
        
VALUES  ( 'NV05' , -- IDNhanVien - char(8)
N'Lý',
          N'Hoàng Hà' , -- TenNhanVien - nvarchar(30)
          '1954-10-23' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'22/5 Nguyễn Xí, Q.Bình Thạnh, TP HCM' , -- DiaChi - nvarchar(50)
          '0843546888' -- Sdt - char(10)
         
        )
go
INSERT INTO dbo.NhanVien
        
VALUES  ( 'NV06' , -- IDNhanVien - char(8)
N'Trần',
          N'Bạch Tuyết' , -- TenNhanVien - nvarchar(30)
         '1980-05-20' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'127 Hùng Vương, TP Mỹ Tho' , -- DiaChi - nvarchar(50)
          '0973206878'  -- Sdt - char(10)
          
        )
go
INSERT INTO dbo.NhanVien
        
VALUES  ( 'NV07' , -- IDNhanVien - char(8)
N'Nguyễn',
          N'An Trung' , -- TenNhanVien - nvarchar(30)
          '1976-06-05' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'234 3/2, TP Biên Hòa' , -- DiaChi - nvarchar(50)
          '0975636353'  -- Sdt - char(10)
        
        )
go
INSERT INTO dbo.NhanVien
        
VALUES  ( 'NV08' , -- IDNhanVien - char(8)
N'Trần',
          N'Hoàng Nam' , -- TenNhanVien - nvarchar(30)
          '1975-11-22' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'234 Trấn Não,An Phú, TP HCM' , -- DiaChi - nvarchar(50)
          '0977375179'  -- Sdt - char(10)
          
        )
go
INSERT INTO dbo.NhanVien
        
       
VALUES  ( 'NV09' , -- IDNhanVien - char(8)
N'Phạm',
          N'Nam Thanh' , -- TenNhanVien - nvarchar(30)
         '1980-12-12' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'221 Hùng Vương,Q.5, TP HCM' , -- DiaChi - nvarchar(50)
          '0972567079'  -- Sdt - char(10)
         
        )
go
INSERT INTO dbo.NhanVien
        
VALUES  ( 'NV10' , -- IDNhanVien - char(8)
N'Nguyễn',
          N'Quang Hùng' , -- TenNhanVien - nvarchar(30)
          '1990-01-14' , -- NgaySinh - date
          'M' , -- GioiTinh - char(1)
          N'289 Hai Bà Trưng, phường 8, quận 3, TP HCM' , -- DiaChi - nvarchar(50)
          '0975261579'  -- Sdt - char(10)
         
        )
--đã insert 
SELECT IDNhanVien,NgaySinh,DiaChi,Sdt,HoNhanVien+TenNhanVien AS HoTen FROM dbo.NhanVien
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F001', -- MaMon - char(8)
          N'cánh gà chiên', -- TenMon - nvarchar(30)
          47000, -- DonGia - numeric
          N'3 cái'  -- DonViTinh - nvarchar(10)
          )
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F002', -- MaMon - char(8)
          'cánh gà chiên', -- TenMon - varchar(30)
          69000, -- DonGia - numeric
          N'5 miếng'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F003', -- MaMon - char(8)
          'khoai tây chiên', -- TenMon - varchar(30)
          12000, -- DonGia - numeric
          N'vừa'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F004', -- MaMon - char(8)
          'khoai tây chiên', -- TenMon - varchar(30)
          25000, -- DonGia - numeric
          N'lớn'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F005', -- MaMon - char(8)
          'khoai tây chiên', -- TenMon - varchar(30)
          35000, -- DonGia - numeric
          N'đại'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F006', -- MaMon - char(8)
          'khoai tây nghiền', -- TenMon - varchar(30)
          10000, -- DonGia - numeric
          N'vừa'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F007', -- MaMon - char(8)
          'khoai tây nghiền', -- TenMon - varchar(30)
          10000, -- DonGia - numeric
          N'lớn'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F008', -- MaMon - char(8)
          'khoai tây nghiền', -- TenMon - varchar(30)
          10000, -- DonGia - numeric
          N'đại'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F009', -- MaMon - char(8)
          'cơm gà ', -- TenMon - varchar(30)
          39000, -- DonGia - numeric
          N'dĩa'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F010', -- MaMon - char(8)
          'cơm phile gà quay tiêu', -- TenMon - varchar(30)
          39000, -- DonGia - numeric
          N'dĩa'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F011', -- MaMon - char(8)
          'cơm phile gà quay flava', -- TenMon - varchar(30)
          39000, -- DonGia - numeric
          N'dĩa'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F012', -- MaMon - char(8)
          'bơ gơ ocean', -- TenMon - varchar(30)
          22000, -- DonGia - numeric
          N'cái'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F013', -- MaMon - char(8)
          'bơ gơ tôm', -- TenMon - varchar(30)
          39000, -- DonGia - numeric
          N'cái'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F014', -- MaMon - char(8)
          'bơ gơ gà quay flava', -- TenMon - varchar(30)
          45000, -- DonGia - numeric
          N'cái'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'F015', -- MaMon - char(8)
          'bơ gơ zinger', -- TenMon - varchar(30)
          49000, -- DonGia - numeric
          N'cái'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'D001', -- MaMon - char(8)
          'Pepsi tươi', -- TenMon - varchar(30)
          10000, -- DonGia - numeric
          N'ly nhỏ'  -- DonViTinh - nvarchar(10)
          )
		  go
INSERT INTO dbo.MonAn
        ( MaMon, TenMon, DonGia, DonViTinh )
VALUES  ( 'D002', -- MaMon - char(8)
          'Pepsi tươi', -- TenMon - varchar(30)
          17000, -- DonGia - numeric
          N'ly lớn'  -- DonViTinh - nvarchar(10)
          )
		  GO
          --đã insert
SELECT * FROM dbo.MonAn
UPDATE dbo.MonAn SET DonGia=20000 WHERE MaMon='D002'
--Đơn hàng 


--insert dữ liệu bảng Luong
UPDATE dbo.Luong SET PhuCap=221000 WHERE SttLuong='10'
INSERT INTO dbo.Luong
        
VALUES  ( '10','NV01' , -- IDNhanVien - char(4)
          3450000 , -- Luong - numeric
          1 , -- Thang - int
          26 , -- NgayCong - int
          24 , -- SoNgayLamViec - int
          NULL  -- PhuCap - numeric
        )
		go
INSERT INTO dbo.Luong
        
VALUES  ( '9','NV02' , -- IDNhanVien - char(4)
          6530000 , -- Luong - numeric
          1 , -- Thang - int
          26, -- NgayCong - int
          24 , -- SoNgayLamViec - int
          0  -- PhuCap - numeric
        )
		go
INSERT INTO dbo.Luong
        
VALUES  ( '8','NV03' , -- IDNhanVien - char(4)
          5214000, -- Luong - numeric
          1 , -- Thang - int
          26 , -- NgayCong - int
          25 , -- SoNgayLamViec - int
          234000  -- PhuCap - numeric
        )
		go
INSERT INTO dbo.Luong
        
VALUES  ( '7','NV04' , -- IDNhanVien - char(4)
          4314000, -- Luong - numeric
          1 , -- Thang - int
          26 , -- NgayCong - int
          26 , -- SoNgayLamViec - int
          230000  -- PhuCap - numeric
        )
		go
INSERT INTO dbo.Luong
        
VALUES  ( '6','NV05' , -- IDNhanVien - char(4)
          8230000 , -- Luong - numeric
          1 , -- Thang - int
          26 , -- NgayCong - int
          26 , -- SoNgayLamViec - int
          345000  -- PhuCap - numeric
        )
		go
INSERT INTO dbo.Luong
        
VALUES  ('5', 'NV06' , -- IDNhanVien - char(4)
          3460000 , -- Luong - numeric
          1 , -- Thang - int
          26 , -- NgayCong - int
          26 , -- SoNgayLamViec - int
          234000  -- PhuCap - numeric
        )
		go
INSERT INTO dbo.Luong
       
VALUES  ( '4','NV07' , -- IDNhanVien - char(4)
          4550000 , -- Luong - numeric
          1 , -- Thang - int
          26 , -- NgayCong - int
          26 , -- SoNgayLamViec - int
          1020000  -- PhuCap - numeric
        )
		go
INSERT INTO dbo.Luong
        
VALUES  ( '3','NV08' , -- IDNhanVien - char(4)
          12300000 , -- Luong - numeric
          1 , -- Thang - int
          26, -- NgayCong - int
          26, -- SoNgayLamViec - int
          341000  -- PhuCap - numeric
        )
		go
INSERT INTO dbo.Luong
        
VALUES  ( '2','NV09' , -- IDNhanVien - char(4)
          7340000 , -- Luong - numeric
          1 , -- Thang - int
          26 , -- NgayCong - int
          24 , -- SoNgayLamViec - int
          230000  -- PhuCap - numeric
        )
		go
INSERT INTO dbo.Luong
        
VALUES  ('1', 'NV10' , -- IDNhanVien - char(4)
          3210000 , -- Luong - numeric
          1 , -- Thang - int
          26 , -- NgayCong - int
          12, -- SoNgayLamViec - int
          0  -- PhuCap - numeric
        )
		go
		--đã insert

		--hóa đơn
		INSERT INTO dbo.HoaDon
		        ( MaDonHang, IDNhanVien, ThoiGian )
		VALUES  ( 'DH01', -- MaDonHang - char(4)
		          'NV02', -- IDNhanVien - char(4)
		          GETDATE()  -- ThoiGian - datetime
		          )
	INSERT INTO dbo.DonHang
	        ( STT ,
	          MaDonHang ,
	          MaMon ,
	          SoLuong ,
	          GhiChu
	        )
	VALUES  ( 1 , -- STT - int
	          'DH01' , -- MaDonHang - char(4)
	          'F001' , -- MaMon - char(4)
	          1 , -- SoLuong - int
	          N''  -- GhiChu - nvarchar(30)
	        )
INSERT INTO dbo.DonHang
	        ( STT ,
	          MaDonHang ,
	          MaMon ,
	          SoLuong ,
	          GhiChu
	        )
	VALUES  ( 2 , -- STT - int
	          'DH01' , -- MaDonHang - char(4)
	          'D001' , -- MaMon - char(4)
	          2 , -- SoLuong - int
	          N''  -- GhiChu - nvarchar(30)
	        )
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH02', -- MaDonHang - char(4)
          'NV02', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )
INSERT INTO dbo.DonHang
        ( STT ,
          MaDonHang ,
          MaMon ,
          SoLuong ,
          GhiChu
        )
VALUES  ( 3 , -- STT - int
          'DH02' , -- MaDonHang - char(4)
          'F006' , -- MaMon - char(4)
          2 , -- SoLuong - int
          N''  -- GhiChu - nvarchar(30)
        )
		go
INSERT INTO dbo.DonHang
        ( STT ,
          MaDonHang ,
          MaMon ,
          SoLuong ,
          GhiChu
        )
VALUES  ( 4 , -- STT - int
          'DH02' , -- MaDonHang - char(4)
          'D002' , -- MaMon - char(4)
          2 , -- SoLuong - int
          N''  -- GhiChu - nvarchar(30)
        )
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH03', -- MaDonHang - char(4)
          'NV01', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )
INSERT INTO DonHang VALUES ( 5,'DH03','F015',5,N'cay nhiều')
GO
INSERT INTO DonHang VALUES ( 6,'DH03','F002',5,N'')
SELECT * FROM dbo.DonHang
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH04', -- MaDonHang - char(4)
          'NV01', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )
INSERT INTO DonHang VALUES ( 7,'DH04','F005',1,N'')
go
INSERT INTO DonHang VALUES ( 8,'DH04','F002',2,N'')
go
INSERT INTO DonHang VALUES ( 9,'DH04','D002',2,N'')
SELECT * FROM dbo.HoaDon
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH05', -- MaDonHang - char(4)
          'NV01', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )
INSERT INTO DonHang VALUES ( 10,'DH05','F004',2,N'')
go
INSERT INTO DonHang VALUES (11 ,'DH05','F005',2,N'')
go
INSERT INTO DonHang VALUES ( 12,'DH05','F007',2,N'')
go
INSERT INTO DonHang VALUES ( 13,'DH05','D002',6,N'')
GO
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH06', -- MaDonHang - char(4)
          'NV03', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )
		  GO
          INSERT INTO DonHang VALUES ( 14,'DH06','F004',1,N'')
		  GO
          INSERT INTO DonHang VALUES ( 15,'DH06','D001',2,N'')
		  GO
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH07', -- MaDonHang - char(4)
          'NV03', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )  
		  GO
		  INSERT INTO DonHang VALUES ( 16,'DH07','F005',20,N'') 
		  GO
		  INSERT INTO DonHang VALUES ( 17,'DH07','D001',20,N'')    
		  go   
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH08', -- MaDonHang - char(4)
          'NV06', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )
		  go
 INSERT INTO DonHang VALUES ( 18,'DH08','D001',5,N'')    
		  GO
  INSERT INTO DonHang VALUES ( 19,'DH08','F006',5,N'')    
		  go  
 INSERT INTO DonHang VALUES ( 20,'DH08','F003',2,N'')    
		  go		         
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH09', -- MaDonHang - char(4)
          'NV04', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )
		  go
INSERT INTO DonHang VALUES ( 21,'DH09','F003',2,N'không cay')    
		  GO
INSERT INTO DonHang VALUES ( 22,'DH09','F006',2,N'không cay')  
			GO
INSERT INTO DonHang VALUES ( 23,'DH09','F008',2,N'không cay') 
GO
INSERT INTO DonHang VALUES ( 24,'DH09','D002',6,N'')
go     			           
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH10', -- MaDonHang - char(4)
          'NV07', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )
		  GO
          INSERT INTO DonHang VALUES ( 25,'DH10','F001',3,N'')
		  GO
          INSERT INTO DonHang VALUES ( 26,'DH10','F003',6,N'')
		  GO
          INSERT INTO DonHang VALUES ( 27,'DH10','F002',3,N'')
		  GO
          INSERT INTO DonHang VALUES ( 28,'DH10','F004',6,N'')
		  GO
          INSERT INTO DonHang VALUES ( 29,'DH10','F005',4,N'')
		  go
		  INSERT INTO DonHang VALUES ( 30,'DH10','D002',19,N'')
		  go
		  SELECT * FROM dbo.DonHang
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH11', -- MaDonHang - char(4)
          'NV10', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )
		  GO
          INSERT INTO DonHang VALUES ( 31,'DH11','F009',1,N'')
		  GO
          INSERT INTO DonHang VALUES ( 32,'DH11','F012',2,N'')
		  GO
          INSERT INTO DonHang VALUES ( 33,'DH11','F013',3,N'')
		  GO
          INSERT INTO DonHang VALUES ( 34,'DH11','D002',8,N'')
		  go
INSERT INTO dbo.HoaDon
        ( MaDonHang, IDNhanVien, ThoiGian )
VALUES  ( 'DH12', -- MaDonHang - char(4)
          'NV10', -- IDNhanVien - char(4)
          GETDATE()  -- ThoiGian - datetime
          )
		  GO
          INSERT INTO DonHang VALUES ( 35,'DH12','F015',2,N'')
		  GO
          INSERT INTO DonHang VALUES ( 36,'DH12','F014',2,N'')
		  GO
          INSERT INTO DonHang VALUES ( 37,'DH12','D002',1,N'')
		  GO
          INSERT INTO DonHang VALUES ( 38,'DH12','D001',1,N'')
		  go
--1.Thống kê nhân viên đã lập bao nhiêu hóa đơn
SELECT NhanVien.IDNhanVien,HoNhanVien+TenNhanVien AS HoTen, COUNT(MaDonHang)AS SoLuong FROM dbo.NhanVien JOIN dbo.HoaDon
ON HoaDon.IDNhanVien = NhanVien.IDNhanVien
GROUP BY NhanVien.IDNhanVien,HoNhanVien,TenNhanVien
--2.tính lương nhân viên
SELECT Luong.IDNhanVien,HoNhanVien+TenNhanVien AS HoTenNV, ROUND((((Luong+PhuCap)/NgayCong) * SoNgayLamViec),0) AS LuongThang FROM dbo.Luong JOIN dbo.NhanVien
ON NhanVien.IDNhanVien = Luong.IDNhanVien
--3.Danh sách những nhân viên có tuổi lớn hơn 30
SELECT IDNhanVien,TenNhanVien,(YEAR(GETDATE())- YEAR(NgaySinh)) AS Tuoi FROM dbo.NhanVien
WHERE (YEAR(GETDATE())- YEAR(NgaySinh))>30
--4.Tính lương của nhân viên
SELECT Luong.IDNhanVien,HoNhanVien+TenNhanVien AS HoTenNV, ROUND((((Luong+PhuCap)/NgayCong) * SoNgayLamViec),0) AS LuongThang FROM dbo.NhanVien JOIN dbo.Luong
ON Luong.IDNhanVien = NhanVien.IDNhanVien
--5.Tính hóa đơn bán hàng
SELECT MaDonHang,SoLuong * DonGia AS ThanhTien 
FROM dbo.DonHang JOIN dbo.MonAn
ON MonAn.MaMon = DonHang.MaMon
GROUP BY MaDonHang,SoLuong,DonGia
--6.Tính tổng tiền của từng hóa đơn
SELECT MaDonHang,SUM(SoLuong * DonGia) AS ttien
FROM dbo.MonAn,dbo.DonHang
where MonAn.MaMon = DonHang.MaMon
GROUP BY MaDonHang
--7.tính tổng tiền thu được của cửa hàng
SELECT (SUM(SoLuong * DonGia) )AS ttien
FROM dbo.MonAn,dbo.DonHang
where MonAn.MaMon = DonHang.MaMon
--8.tính lương của nhân viên và sắp xếp giảm dần
SELECT Luong.IDNhanVien,HoNhanVien+TenNhanVien AS HoTenNV, ROUND((((Luong+PhuCap)/NgayCong) * SoNgayLamViec),0) AS LuongThang FROM dbo.NhanVien JOIN dbo.Luong
ON Luong.IDNhanVien = NhanVien.IDNhanVien
ORDER BY LuongThang DESC
--9.kiểm tra số lượng món ăn bán trong ngày
SELECT SUM(SoLuong) AS SoLuong ,MaMon FROM dbo.DonHang JOIN dbo.HoaDon
ON HoaDon.MaDonHang = DonHang.MaDonHang
WHERE day(ThoiGian)='3' AND MONTH(ThoiGian)='1' AND YEAR(ThoiGian)='2019'
GROUP BY MaMon
SELECT SUM(SoLuong) AS SoLuong FROM dbo.DonHang JOIN dbo.HoaDon
ON HoaDon.MaDonHang = DonHang.MaDonHang
WHERE day(ThoiGian)='3' AND MONTH(ThoiGian)='1' AND YEAR(ThoiGian)='2019'
--10.Kiểm tra những nhân viên ở TP HCM
SELECT IDNhanVien, HoNhanVien + TenNhanVien AS HoVaTen,GioiTinh,DiaChi,Sdt FROM dbo.NhanVien
WHERE DiaChi LIKE '%HCM'
--11.Tăng lương cho nhân viên trên 40 tuổi
UPDATE Luong SET Luong=Luong+200000 FROM dbo.Luong JOIN dbo.NhanVien
ON NhanVien.IDNhanVien = Luong.IDNhanVien
WHERE YEAR(GETDATE())-YEAR(NgaySinh)>40

--13.Tạo ra tài khoản đăng nhập cho các quản lí: ‘ql1’,’ql2’,’ql3’ và cho giám đốc là ‘gd1’ với mật khẩu tùy ý 
CREATE LOGIN ql1
WITH PASSWORD ='123456',
DEFAULT_DATABASE= QLTAN_GITHUB1
CREATE LOGIN ql2
WITH PASSWORD ='123456',
DEFAULT_DATABASE= QLTAN_GITHUB1
CREATE LOGIN ql3
WITH PASSWORD ='123456',
DEFAULT_DATABASE= QLTAN_GITHUB1
CREATE LOGIN gd1
WITH PASSWORD ='123456',
DEFAULT_DATABASE= QLTAN_GITHUB1
USE QLTAN_GITHUB1
GO
GRANT SELECT  ON dbo.Luong TO gd1
--14.Kiểm tra nếu NV có độ tuổi lớn hơn 40 thì sẽ không được xóa
CREATE TRIGGER UTG
ON NHANVIENFOR DELETE
AS
BEGIN
	DECLARE @count INT=0
	SELECT  @count=count(*)  FROM DELETED
	WHERE YEAR(GETDATE)-YEAR(NGAYSINH)>40
 	IF @count>0
BEGIN
PRINT N'Không được xóa giáo viên trên 40 tuổi'
	ROLLBACK TRAN
	ENDEND
--15.in ra id và tên nhân viên giới tính nam
SELECT TenNhanVien+HoNhanVien AS HoTen,IDNhanVien FROM dbo.NhanVien WHERE GioiTinh='M' 
--16.lấy ra tên những món có giá lớn hơn 10000d
SELECT TenMon,DonViTinh FROM dbo.MonAn WHERE DonGia>10000
--17.lấy ra những hóa đơn có giá trị lớn hơn 100000d
SELECT MaDonHang,SUM(SoLuong * DonGia) AS ThanhTien
FROM dbo.MonAn,dbo.DonHang
where MonAn.MaMon = DonHang.MaMon
GROUP BY MaDonHang
HAVING SUM(SoLuong * DonGia)>100000
--18.in ra danh sách nhân viên theo thứ tự giam dần
SELECT HoNhanVien+TenNhanVien AS HoTen, IDNhanVien,NgaySinh FROM dbo.NhanVien 
ORDER BY TenNhanVien ASC
--19.xuất ra thông tin nhân viên bắt đầu bằng chũ N
SELECT * FROM dbo.NhanVien 
WHERE  TenNhanVien LIKE 'N%'
--20.tăng giá món cơm gà thêm 3000d
SELECT * FROM dbo.MonAn
WHERE TenMon LIKE 'Cơm gà%'
UPDATE dbo.MonAn
SET DonGia=DonGia+3000
WHERE MaMon='F009'
--21.xóa những đơn đặt hàng trước ngày 10 tháng 1 năm 2019
DELETE FROM dbo.HoaDon 
WHERE ThoiGian<'2019-01-10'
------
SELECT * FROM dbo.NhanVien
UPDATE dbo.NhanVien SET TenNhanVien=N'Hương'
FROM dbo.NhanVien
WHERE IDNhanVien='NV02'
UPDATE dbo.NhanVien SET TenNhanVien=N'Ánh'
FROM dbo.NhanVien
WHERE IDNhanVien='NV03'
UPDATE dbo.NhanVien SET TenNhanVien=N'Sơn'
FROM dbo.NhanVien
WHERE IDNhanVien='NV04'
go
UPDATE dbo.NhanVien SET TenNhanVien=N'Hà'
FROM dbo.NhanVien
WHERE IDNhanVien='NV05'
go
UPDATE dbo.NhanVien SET TenNhanVien=N'Tuyết'
FROM dbo.NhanVien
WHERE IDNhanVien='NV06'
go
UPDATE dbo.NhanVien SET TenNhanVien=N'Trung'
FROM dbo.NhanVien
WHERE IDNhanVien='NV07'
go
UPDATE dbo.NhanVien SET TenNhanVien=N'Nam'
FROM dbo.NhanVien
WHERE IDNhanVien='NV08'
go
UPDATE dbo.NhanVien SET TenNhanVien=N'Thanh'
FROM dbo.NhanVien
WHERE IDNhanVien='NV09'
go
UPDATE dbo.NhanVien SET TenNhanVien=N'Hùng'
FROM dbo.NhanVien
WHERE IDNhanVien='NV10'
GO
CREATE TRIGGER UST ON dbo.NhanVien
AFTER INSERT 
AS 
BEGIN
UPDATE dbo.Luong
SET 
go
CREATE TRIGGER TINSERT
ON NHANVIENFOR insert
AS
BEGIN
	DECLARE @count INT=0
	SELECT  @count=count(*)  FROM Inserted
	WHERE YEAR(GETDATE())-YEAR(NGAYSINH)>40
 	IF @count>0
BEGIN
PRINT N'Không được chèn giáo viên trên 40 tuổi'
	ROLLBACK TRAN
	ENDEND
INSERT INTO dbo.NhanVien 
        ( IDNhanVien ,
          HoNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt
        )
VALUES  ( 'NV99' , -- IDNhanVien - char(4)
          N'NGuyễn' , -- HoNhanVien - nvarchar(30)
          N'Hiền' , -- TenNhanVien - nvarchar(30)
          '1930-05-05' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'Ninh Hòa-Khánh Hòa' , -- DiaChi - nvarchar(50)
          '0123456789'  -- Sdt - char(10)
        )




		

