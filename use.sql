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
SELECT MaDonHang,DonHang.MaMon,SoLuong * DonGia AS ThanhTien 
FROM dbo.DonHang JOIN dbo.MonAn
ON MonAn.MaMon = DonHang.MaMon
GROUP BY MaDonHang,SoLuong,DonGia,DonHang.MaMon
--6.Tính tổng tiền của từng hóa đơn
SELECT MaDonHang,SUM(SoLuong * DonGia) AS ttien
FROM dbo.MonAn,dbo.DonHang
where MonAn.MaMon = DonHang.MaMon
GROUP BY MaDonHang
--join
SELECT HoaDon.MaDonHang,SUM(SoLuong*DonGia) AS ThanhTien FROM 
(dbo.DonHang JOIN dbo.HoaDon 
ON HoaDon.MaDonHang = DonHang.MaDonHang ) 
JOIN dbo.MonAn ON MonAn.MaMon = DonHang.MaMon
GROUP BY HoaDon.MaDonHang
--7.tính tổng tiền thu được của cửa hàng
SELECT (SUM(SoLuong * DonGia) )AS Ttien
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
--22.tính tổng tiền thu được của cửa hàng vào tháng 1
SELECT (SUM(SoLuong * DonGia) )AS ThanhTien
FROM dbo.MonAn,dbo.DonHang,dbo.HoaDon
where MonAn.MaMon = DonHang.MaMon AND DonHang.MaDonHang=HoaDon.MaDonHang AND MONTH(ThoiGian)='1' AND YEAR(ThoiGian)='2019'
go
--
CREATE TRIGGER TRDNV ON NhanVien AFTER DELETE AS FOR delete
AS 
DELETE IdNhanVien FROM dbo.NhanVien,
deleted WHERE NhanVien.IDNhanVien=HoaDon.IDNhanVien
GO
--store procedure truy vấn những hóa đơn có giá lớn hơn 100000d
CREATE PROC UPR_MH_DH AS 
SELECT MaDonHang,SUM(SoLuong * DonGia) AS ThanhTien
FROM dbo.MonAn,dbo.DonHang
where MonAn.MaMon = DonHang.MaMon
GROUP BY MaDonHang
HAVING SUM(SoLuong * DonGia)>100000
EXEC dbo.UPR_MH_DH
--nhung nv ngay cong lon hon 26 va co tuoi < 20
SELECT Luong.IDNhanVien,HoNhanVien+TenNhanVien AS HoVaTen FROM dbo.NhanVien JOIN dbo.Luong
ON Luong.IDNhanVien = NhanVien.IDNhanVien 
WHERE NgayCong>25 AND YEAR(GETDATE())-YEAR(NgaySinh)<20
SELECT NgayCong FROM dbo.Luong
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          HoNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt
        )
VALUES  ( 'NV20' , -- IDNhanVien - char(4)
          N'Nguyễn' , -- HoNhanVien - nvarchar(30)
          N'Thiên' , -- TenNhanVien - nvarchar(30)
          '1998-03-05' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'Ninh Hòa' , -- DiaChi - nvarchar(50)
          '0123456789'  -- Sdt - char(10)
        )
INSERT INTO dbo.NhanVien
        ( IDNhanVien ,
          HoNhanVien ,
          TenNhanVien ,
          NgaySinh ,
          GioiTinh ,
          DiaChi ,
          Sdt
        )
VALUES  ( 'NV22' , -- IDNhanVien - char(4)
          N'Trần' , -- HoNhanVien - nvarchar(30)
          N'Thảo' , -- TenNhanVien - nvarchar(30)
          '2000-05-05' , -- NgaySinh - date
          'F' , -- GioiTinh - char(1)
          N'Nha Trang, Khanh Hòa' , -- DiaChi - nvarchar(50)
          '032187898'  -- Sdt - char(10)
        )
INSERT INTO dbo.Luong
        ( SttLuong ,
          IDNhanVien ,
          Luong ,
          Thang ,
          NgayCong ,
          SoNgayLamViec ,
          PhuCap
        )
VALUES  ( '20' , -- SttLuong - char(2)
          'NV20' , -- IDNhanVien - char(4)
          4200000 , -- Luong - numeric
          1 , -- Thang - int
          26 , -- NgayCong - int
          28 , -- SoNgayLamViec - int
          NULL  -- PhuCap - numeric
        )
INSERT INTO dbo.Luong
        ( SttLuong ,
          IDNhanVien ,
          Luong ,
          Thang ,
          NgayCong ,
          SoNgayLamViec ,
          PhuCap
        )
VALUES  ( '22' , -- SttLuong - char(2)
          'NV22' , -- IDNhanVien - char(4)
          2300000 , -- Luong - numeric
          1 , -- Thang - int
          26 , -- NgayCong - int
          28 , -- SoNgayLamViec - int
          NULL  -- PhuCap - numeric
        )
		
        INSERT INTO dbo.DonHang-
                ( STT ,
                  MaDonHang ,
             MaMon ,
                  SoLuong ,
                  GhiChu
                )
        VALUES  ( 0 , -- STT - int
                  '' , -- MaDonHang - char(4)
                  '' , -- MaMon - char(4)
                  0 , -- SoLuong - int
                  N''  -- GhiChu - nvarchar(30)
                )
SELECT YEAR(GETDATE())-YEAR(NgaySinh) FROM dbo.NhanVien
