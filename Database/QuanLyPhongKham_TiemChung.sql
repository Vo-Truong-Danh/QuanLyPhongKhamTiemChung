<<<<<<< HEAD
CREATE DATABASE QUANLYPHONGKHAM_TIEMCHUNG
ON  
PRIMARY  
(  
    NAME = QLPK_MDF,  
    FILENAME = 'D:\db_main\qlpk.mdf',  
    SIZE = 10MB,  
    MAXSIZE = 100MB,  
    FILEGROWTH = 5MB  
),  
FILEGROUP SecondaryFiles  
(  
    NAME = QLPK_NDF,  
    FILENAME = 'D:\db_main\qlpk.ndf',  
    SIZE = 10MB,  
    MAXSIZE = 100MB,  
    FILEGROWTH = 5MB  
)  
LOG ON  
(  
    NAME = QLPK_LOG,  
    FILENAME = 'D:\db_log\qlpk.ldf',  
    SIZE = 5MB,  
    MAXSIZE = 50MB,  
    FILEGROWTH = 1MB  
);  
GO


=======
CREATE DATABASE QUANLYPHONGKHAM_TIEMCHUNG;
GO

>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
USE QUANLYPHONGKHAM_TIEMCHUNG;
GO

CREATE TABLE BENHNHAN 
(
    MaBN CHAR(5) PRIMARY KEY,
    HoTen NVARCHAR(50),
    NgaySinh DATE,
    GioiTinh NVARCHAR(3) CHECK (GioiTinh IN ('Nam', N'Nữ')),
    DiaChi NVARCHAR(90),
    SoDienThoai CHAR(10) CHECK (LEN(SoDienThoai) = 10 AND SoDienThoai LIKE '[0-9]%')
);

CREATE TABLE NHANVIEN
(
    MaNV CHAR(5) PRIMARY KEY,
    HoTen NVARCHAR(50),
    GioiTinh NVARCHAR(3) CHECK (GioiTinh IN ('Nam', N'Nữ')),
    ChucVu NVARCHAR(30),
    DiaChi NVARCHAR(90),
    SoDienThoai CHAR(10) CHECK (LEN(SoDienThoai) = 10 AND SoDienThoai LIKE '[0-9]%'),
    Pass VARCHAR(30) NOT NULL DEFAULT '123',
    Quyen INT NOT NULL
);

CREATE TABLE NHACUNGCAP
(
    MaNCC CHAR(6) PRIMARY KEY,
    TenNCC NVARCHAR(200),
    DiaChi NVARCHAR(200),
    SoDienThoai CHAR(10) CHECK (LEN(SoDienThoai) = 10 AND SoDienThoai LIKE '[0-9]%')
);

CREATE TABLE LOAIVACCINE
(
    MaLoai CHAR(5) PRIMARY KEY,
    TenLoai NVARCHAR(50),
    SoMui INT DEFAULT 1
);

CREATE TABLE VACCINE
(
    MaVC CHAR(5) PRIMARY KEY,
    MaLoai CHAR(5),
    FOREIGN KEY(MaLoai) REFERENCES LOAIVACCINE(MaLoai),
    TenVC NVARCHAR(50),
    NgaySX DATE,
    HanSuDung DATE,
    SoLuongTon INT CHECK (SoLuongTon >= 0) DEFAULT 0,
    Gia INT CHECK (Gia >= 0) DEFAULT 0,
    CHECK (HanSuDung > NgaySX),
    XuatXu NVARCHAR(50) DEFAULT 'Chưa Xác Định'
);

CREATE TABLE PHIEUNHAP
(
    MaPN CHAR(5) PRIMARY KEY,
	MaNV CHAR(5) ,
    FOREIGN KEY(MANV) REFERENCES NHANVIEN(MaNV),
    NgayNhap DATE DEFAULT GETDATE(),
    MaNCC CHAR(6) NOT NULL,
	TongTien INT DEFAULT 0 ,
    FOREIGN KEY(MaNCC) REFERENCES NHACUNGCAP(MaNCC)
);

CREATE TABLE CHITIETPHIEUNHAP
(
    MaPN CHAR(5) NOT NULL,
    MaVC CHAR(5) NOT NULL,
    PRIMARY KEY(MaPN,MaVC),
    FOREIGN KEY(MaPN) REFERENCES PHIEUNHAP(MaPN),
    FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),
    SoLuong INT,
    DonGia FLOAT
);

CREATE TABLE HOADON
(
    MaHD CHAR(5) PRIMARY KEY,
    NgayLap DATE DEFAULT GETDATE(),
    MaBN CHAR(5) NOT NULL,
    FOREIGN KEY(MaBN) REFERENCES BENHNHAN(MaBN),
    MaNV CHAR(5) NOT NULL,
    FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV),
    TongTien FLOAT CHECK (TongTien >= 0) DEFAULT 0
);

CREATE TABLE CHITIETHOADON
(
    MaHD CHAR(5) NOT NULL,
    MaVC CHAR(5) NOT NULL,
    PRIMARY KEY(MaHD,MaVC),
    FOREIGN KEY(MaHD) REFERENCES HOADON(MaHD),
    FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),
    SOLUONG INT DEFAULT 0,
    DONGIA FLOAT DEFAULT 0
);

CREATE TABLE LICHTIEM 
(
    MaLT CHAR(5) NOT NULL,
    MaHD CHAR(5) NOT NULL,
    MaBN CHAR(5),
    MaVC CHAR(5),
    NgayHenTiem DATE,
    TrangThai NVARCHAR(15),
    PRIMARY KEY (MaLT, MaHD), 
    FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD),  
    FOREIGN KEY (MaBN) REFERENCES BENHNHAN(MaBN), 
    FOREIGN KEY (MaVC) REFERENCES VACCINE(MaVC)
);

CREATE TABLE GHINHANTIEMCHUNG
(
    MaBN CHAR(5) NOT NULL,
    FOREIGN KEY(MaBN) REFERENCES BENHNHAN(MaBN),
    MaVC CHAR(5) NOT NULL,
    FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),
    MaNV CHAR(5) NOT NULL,
    FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV),
    MaLT CHAR(5) NOT NULL,
    MaHD CHAR(5) NOT NULL,
    FOREIGN KEY (MaLT, MaHD) REFERENCES LICHTIEM(MaLT, MaHD),
    NgayTiem DATE,
    PRIMARY KEY(MaBN, MaVC, MaLT, MaNV),
    TinhTrangSucKhoe NVARCHAR(50)
);
GO
-----------------------------------------------------------------------
--------------------------------TRIGER---------------------------------
-----------------------------------------------------------------------

-- =============================================
-- Trigger: Tính tổng tiền cho phiếu nhập
-- Mô tả: Tự động tính tổng tiền của phiếu nhập khi có sự thay đổi trong bảng CHITIETPHIEUNHAP (INSERT, UPDATE).
-- =============================================
GO
CREATE TRIGGER TG_TinhTongTienPN
ON CHITIETPHIEUNHAP
FOR INSERT, UPDATE
AS
BEGIN
	UPDATE PHIEUNHAP
    SET TongTien = (
        SELECT SUM(SOLUONG * DONGIA) 
        FROM CHITIETPHIEUNHAP 
        WHERE MaPN IN (SELECT MaPN FROM inserted)
    )
    WHERE MaPN IN (SELECT MaPN FROM inserted);
END

-- =============================================
-- Trigger: Lấy giá cho chi tiết hóa đơn từ vaccine
-- Mô tả: Cập nhật giá trong bảng CHITIETHOADON từ bảng VACCINE khi có sự thay đổi trong bảng CHITIETHOADON (INSERT, UPDATE).
-- =============================================
GO 
CREATE TRIGGER TG_LAYDONGIACHOCTHD
ON CHITIETHOADON
FOR INSERT, UPDATE
AS
BEGIN
	UPDATE CHITIETHOADON
	SET CHITIETHOADON.DONGIA = VC.Gia
	FROM VACCINE VC
	WHERE VC.MaVC = CHITIETHOADON.MaVC
END

-- =============================================
-- Trigger: Tính tổng tiền cho hóa đơn
-- Mô tả: Tự động tính tổng tiền của hóa đơn khi có sự thay đổi trong bảng CHITIETHOADON (INSERT, UPDATE).
-- =============================================
GO
CREATE TRIGGER TG_TINHTONGTIEN
ON CHITIETHOADON
FOR INSERT, UPDATE
AS
BEGIN
    UPDATE HOADON
    SET TongTien = (
        SELECT SUM(SOLUONG * DONGIA) 
        FROM CHITIETHOADON 
        WHERE MaHD IN (SELECT MaHD FROM inserted)
    )
    WHERE MaHD IN (SELECT MaHD FROM inserted);
END

-- =============================================
-- Trigger: Tạo lịch tiêm khi có hóa đơn
-- Mô tả: Tự động tạo lịch tiêm khi có thêm hóa đơn vào bảng HOADON.
<<<<<<< HEAD
-- =============================================\
CREATE TRIGGER TR_MaLT_AutoGen
ON LICHTIEM
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaLT CHAR(5);
 
    SELECT @NewMaLT = 'LT' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaLT, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
    FROM LICHTIEM;

    INSERT INTO LICHTIEM (MaLT, MaHD, MaBN, MaVC, NgayHenTiem, TrangThai)
    SELECT @NewMaLT, MaHD, MaBN, MaVC, NgayHenTiem, TrangThai
    FROM INSERTED;
END;
GO

=======
-- =============================================
GO 
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
CREATE TRIGGER TG_TAOLICHTIEMKHITHEMHOADON
ON HOADON
FOR INSERT
AS
BEGIN
	INSERT INTO LICHTIEM([MaHD], [MaBN], [TrangThai])
	SELECT i.MaHD, i.MaBN, N'Chưa tiêm'
    FROM INSERTED i;
END

-- =============================================
-- Trigger: Thêm mã vaccine vào lịch tiêm khi có chi tiết hóa đơn
-- Mô tả: Tự động thêm mã vaccine vào lịch tiêm khi có chi tiết hóa đơn.
-- =============================================
GO 
CREATE TRIGGER TG_THEMMAVCVAOLICHTIEM
ON CHITIETHOADON
FOR INSERT
AS
BEGIN
    UPDATE LICHTIEM
    SET LICHTIEM.MaVC = i.MaVC
    FROM LICHTIEM l
    JOIN INSERTED i ON l.MaHD = i.MaHD;
END
GO

-- =============================================
-- Trigger: Cộng số lượng tồn trong vaccine
-- Mô tả: Cập nhật số lượng tồn của vaccine sau khi có thêm phiếu nhập vào bảng CHITIETPHIEUNHAP.
-- =============================================
GO
CREATE TRIGGER TG_CONGSOLUONGTONCUAVACCINE
ON CHITIETPHIEUNHAP
FOR INSERT
AS
BEGIN
    UPDATE V
    SET SoLuongTon = ISNULL((SELECT SUM(CT.SoLuong) 
                              FROM CHITIETPHIEUNHAP CT
                              WHERE CT.MaVC = I.MaVC), 0) 
                          - ISNULL((SELECT SUM(SOLUONG) 
                                     FROM CHITIETHOADON 
                                     WHERE MaVC = I.MaVC), 0)
    FROM VACCINE V
    JOIN inserted I ON V.MaVC = I.MaVC;
END

-- =============================================
-- Trigger: Cập nhật trạng thái lịch tiêm sau khi thêm ghi nhận tiêm chủng
-- Mô tả: Cập nhật trạng thái của lịch tiêm sau khi thêm ghi nhận tiêm chủng vào bảng GHINHANTIEMCHUNG.
-- =============================================
GO
CREATE TRIGGER TG_CAPNHAPTRANGTHAILICHTIEM
ON GHINHANTIEMCHUNG
FOR INSERT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM inserted i JOIN LICHTIEM LT ON LT.MaLT = I.MaLT WHERE i.MaVC = LT.MaVC AND LT.MaBN =i.MaBN AND LT.MaVC =I.MaVC)
    BEGIN
        PRINT N'Dữ liệu không hợp lệ! Không khớp với lịch tiêm.';
        ROLLBACK TRAN
    END;
	UPDATE LICHTIEM
	SET TrangThai = N'Đã tiêm'
	WHERE MaLT = (SELECT MaLT FROM inserted) AND MaVC = (SELECT MaVC FROM inserted ) AND MaBN = (SELECT MaBN FROM inserted)
END

-- =============================================
-- Trigger: Kiểm tra số lượng vaccine trước khi thêm/cập nhật chi tiết hóa đơn
-- Mô tả: Kiểm tra số lượng vaccine còn lại trước khi thêm/cập nhật chi tiết hóa đơn.
-- =============================================
GO
CREATE TRIGGER TG_KiemTraSoLuongVaccine
ON CHITIETHOADON
FOR INSERT
AS
BEGIN
    IF EXISTS (
        SELECT *
        FROM inserted I
        JOIN VACCINE V ON I.MaVC = V.MaVC
        WHERE I.SOLUONG > V.SoLuongTon
    )
    BEGIN 
        PRINT N'Số lượng Vaccine còn lại không đủ';
        ROLLBACK TRANSACTION;
        RETURN;
    END
    UPDATE V
    SET SoLuongTon = (
        (SELECT ISNULL(SUM(CT.SoLuong), 0) 
         FROM CHITIETPHIEUNHAP CT 
         WHERE CT.MaVC = I.MaVC) 
        - (SELECT ISNULL(SUM(HD.SOLUONG), 0) 
           FROM CHITIETHOADON HD 
           WHERE HD.MaVC = I.MaVC)
    )
    FROM VACCINE V
    JOIN (
        SELECT MaVC, SUM(SOLUONG) AS TongSoLuong
        FROM inserted
        GROUP BY MaVC
    ) I ON I.MaVC = V.MaVC;
END
GO

<<<<<<< HEAD
=======

--===================================Thống kê==============================================
	
--Thống kê nhập hàng theo tháng
select YEAR(NgayNhap),MONTH(NgayNhap) AS N'Tháng Lập' , SUM(TongTien) from PHIEUNHAP group by YEAR(NgayNhap),MONTH(NgayNhap) order by YEAR(NgayNhap) , MONTH(NgayNhap) 
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)

--===================================Thống kê==============================================
	
--Thống kê nhập hàng theo tháng 
Select Concat(Month(NgayNhap),'-',Year(NgayNhap)) as ThangNam, Sum(TongTien) as TongTien From PhieuNhap Group By Year(NgayNhap),Month(NgayNhap)Order By Year(NgayNhap),Month(NgayNhap)

--Thống kê doanh thu bán hàng theo tháng
SELECT CONCAT(MONTH(NgayLap), '-', YEAR(NgayLap)) AS ThangNam, SUM(TongTien) AS TongTien FROM HOADON GROUP BY YEAR(NgayLap), MONTH(NgayLap)ORDER BY YEAR(NgayLap), MONTH(NgayLap)

--Thống kê số lượng vaccine đã tiêm
select VACCINE.TenVC , sum(CTHD.SOLUONG) as SoLuong from VACCINE join CHITIETHOADON CTHD on CTHD.MaVC = VACCINE.MaVC Group by TenVC

----------------------------------------------------------------------
--------------------------Procedures----------------------------------
----------------------------------------------------------------------

-- =============================================
-- Procedure: Thêm bệnh nhân mới
-- =============================================
CREATE PROCEDURE sp_ThemBenhNhan
    @MaBN CHAR(5),
    @HoTen NVARCHAR(50),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(3),
    @DiaChi NVARCHAR(90),
    @SoDienThoai CHAR(10)
AS
BEGIN
    -- Kiểm tra mã bệnh nhân đã tồn tại
    IF EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
<<<<<<< HEAD
        Print N'Mã bệnh nhân đã tồn tại.';
=======
        RAISERROR(N'Mã bệnh nhân đã tồn tại.', 16, 1);
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
        RETURN;
    END

    -- Thêm mới bệnh nhân
    INSERT INTO BENHNHAN (MaBN, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai)
    VALUES (@MaBN, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai);
END;
GO
<<<<<<< HEAD
sp_ThemBenhNhan 'BN025', N'Nguyễn Văn An', '2003-01-15', N'Nam', N'12 Nguyễn Trãi, Quận 1, TP.HCM', '0912345678'
-- =============================================
-- Procedure: Cập nhật thông tin bệnh nhân
-- =============================================
CREATE PROCEDURE sp_CapNhatBenhNhan
    @MaBN CHAR(5),
    @HoTen NVARCHAR(50),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(3),
    @DiaChi NVARCHAR(90),
    @SoDienThoai CHAR(10)
AS
BEGIN
    -- Kiểm tra mã bệnh nhân tồn tại
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        Print N'Mã bệnh nhân không tồn tại.';
        RETURN;
    END

    -- Cập nhật thông tin bệnh nhân
    UPDATE BENHNHAN
    SET HoTen = @HoTen,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        DiaChi = @DiaChi,
        SoDienThoai = @SoDienThoai
    WHERE MaBN = @MaBN;
END;
GO

-- =============================================
-- Procedure: Xóa bệnh nhân
-- =============================================
CREATE PROCEDURE sp_XoaBenhNhan
    @MaBN CHAR(5)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        Print N'Mã bệnh nhân không tồn tại.';
        RETURN;
    END
	ELSE
	BEGIN
		Print N'Không thể xóa.';
	END
    -- Xóa bệnh nhân
    DELETE FROM BENHNHAN
    WHERE MaBN = @MaBN;
END;
GO
drop proc sp_ThemHoaDon
sp_XoaBenhNhan 'BN001'

-- =============================================
=======

-- =============================================
-- Procedure: Cập nhật thông tin bệnh nhân
-- =============================================
CREATE PROCEDURE sp_CapNhatBenhNhan
    @MaBN CHAR(5),
    @HoTen NVARCHAR(50),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(3),
    @DiaChi NVARCHAR(90),
    @SoDienThoai CHAR(10)
AS
BEGIN
    -- Kiểm tra mã bệnh nhân tồn tại
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        RAISERROR(N'Mã bệnh nhân không tồn tại.', 16, 1);
        RETURN;
    END

    -- Cập nhật thông tin bệnh nhân
    UPDATE BENHNHAN
    SET HoTen = @HoTen,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        DiaChi = @DiaChi,
        SoDienThoai = @SoDienThoai
    WHERE MaBN = @MaBN;
END;
GO

-- =============================================
-- Procedure: Xóa bệnh nhân
-- =============================================
CREATE PROCEDURE sp_XoaBenhNhan
    @MaBN CHAR(5)
AS
BEGIN
    -- Kiểm tra mã bệnh nhân tồn tại
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        RAISERROR(N'Mã bệnh nhân không tồn tại.', 16, 1);
        RETURN;
    END

    -- Xóa bệnh nhân
    DELETE FROM BENHNHAN
    WHERE MaBN = @MaBN;
END;
GO

-- =============================================
-- Procedure: Thêm lịch tiêm
-- =============================================
CREATE PROCEDURE sp_ThemLichTiem
    @MaLT CHAR(5),
    @MaHD CHAR(5),
    @MaBN CHAR(5),
    @MaVC CHAR(5),
    @NgayHenTiem DATE,
    @TrangThai NVARCHAR(15)
AS
BEGIN
    -- Kiểm tra mã lịch tiêm đã tồn tại
    IF EXISTS (SELECT * FROM LICHTIEM WHERE MaLT = @MaLT)
    BEGIN
        RAISERROR(N'Mã lịch tiêm đã tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra mã bệnh nhân và vaccine tồn tại
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        RAISERROR(N'Mã bệnh nhân không tồn tại.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM VACCINE WHERE MaVC = @MaVC)
    BEGIN
        RAISERROR(N'Mã vaccine không tồn tại.', 16, 1);
        RETURN;
    END

    -- Thêm lịch tiêm
    INSERT INTO LICHTIEM (MaLT, MaHD, MaBN, MaVC, NgayHenTiem, TrangThai)
    VALUES (@MaLT, @MaHD, @MaBN, @MaVC, @NgayHenTiem, @TrangThai);
END;
GO

-- =============================================
-- Procedure: Cập nhật trạng thái lịch tiêm
-- =============================================
CREATE PROCEDURE sp_CapNhatTrangThaiLichTiem
    @MaLT CHAR(5),
    @MaHD CHAR(5),
    @TrangThai NVARCHAR(15)
AS
BEGIN
    -- Kiểm tra mã lịch tiêm tồn tại
    IF NOT EXISTS (SELECT * FROM LICHTIEM WHERE MaLT = @MaLT AND MaHD = @MaHD)
    BEGIN
        RAISERROR(N'Lịch tiêm không tồn tại.', 16, 1);
        RETURN;
    END

    -- Cập nhật trạng thái lịch tiêm
    UPDATE LICHTIEM
    SET TrangThai = @TrangThai
    WHERE MaLT = @MaLT AND MaHD = @MaHD;
END;
GO

-- =============================================
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- Procedure: Thêm hóa đơn
-- =============================================
CREATE PROCEDURE sp_ThemHoaDon
    @MaHD CHAR(5),
    @NgayLap DATE,
    @MaBN CHAR(5),
<<<<<<< HEAD
    @MaNV CHAR(5)
AS
BEGIN
    IF EXISTS (SELECT * FROM HOADON WHERE MaHD = @MaHD)
    BEGIN
        Print N'Mã hóa đơn đã tồn tại.';
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        Print N'Mã bệnh nhân không tồn tại.';
=======
    @MaNV CHAR(5),
    @TongTien FLOAT
AS
BEGIN
    -- Kiểm tra mã hóa đơn đã tồn tại
    IF EXISTS (SELECT * FROM HOADON WHERE MaHD = @MaHD)
    BEGIN
        RAISERROR(N'Mã hóa đơn đã tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra mã bệnh nhân và nhân viên tồn tại
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        RAISERROR(N'Mã bệnh nhân không tồn tại.', 16, 1);
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM NHANVIEN WHERE MaNV = @MaNV)
    BEGIN
<<<<<<< HEAD
        Print N'Mã nhân viên không tồn tại.';
        RETURN;
    END

    INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV)
    VALUES (@MaHD, @NgayLap, @MaBN, @MaNV);
END;
GO

sp_ThemHoaDon 'HD045', '2022-01-05', 'BN088', 'NV001'
=======
        RAISERROR(N'Mã nhân viên không tồn tại.', 16, 1);
        RETURN;
    END

    -- Thêm hóa đơn
    INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV, TongTien)
    VALUES (@MaHD, @NgayLap, @MaBN, @MaNV, @TongTien);
END;
GO

>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- =============================================
-- Procedure: Thêm chi tiết hóa đơn
-- =============================================
CREATE PROCEDURE sp_ThemChiTietHoaDon
    @MaHD CHAR(5),
    @MaVC CHAR(5),
<<<<<<< HEAD
    @SoLuong INT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM HOADON WHERE MaHD = @MaHD)
    BEGIN
        Print N'Mã hóa đơn không tồn tại.';
=======
    @SoLuong INT,
    @DonGia FLOAT
AS
BEGIN
    -- Kiểm tra mã hóa đơn và vaccine tồn tại
    IF NOT EXISTS (SELECT * FROM HOADON WHERE MaHD = @MaHD)
    BEGIN
        RAISERROR(N'Mã hóa đơn không tồn tại.', 16, 1);
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM VACCINE WHERE MaVC = @MaVC)
    BEGIN
<<<<<<< HEAD
        Print N'Mã vaccine không tồn tại.';
=======
        RAISERROR(N'Mã vaccine không tồn tại.', 16, 1);
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
        RETURN;
    END

    -- Thêm chi tiết hóa đơn
<<<<<<< HEAD
    INSERT INTO CHITIETHOADON (MaHD, MaVC, SoLuong)
    VALUES (@MaHD, @MaVC, @SoLuong);
END;
GO

sp_ThemChiTietHoaDon 'HD0056', 'VC001', 2
=======
    INSERT INTO CHITIETHOADON (MaHD, MaVC, SoLuong, DonGia)
    VALUES (@MaHD, @MaVC, @SoLuong, @DonGia);
END;
GO

>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- =============================================
-- Procedure: Lấy thông tin bệnh nhân theo mã
-- =============================================
CREATE PROCEDURE sp_LayThongTinBenhNhan
    @MaBN CHAR(5)
AS
BEGIN
<<<<<<< HEAD
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        Print N'Mã bệnh nhân không tồn tại.';
        RETURN;
    END

=======
    -- Kiểm tra mã bệnh nhân tồn tại
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        RAISERROR(N'Mã bệnh nhân không tồn tại.', 16, 1);
        RETURN;
    END

    -- Lấy thông tin bệnh nhân
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
    SELECT * FROM BENHNHAN
    WHERE MaBN = @MaBN;
END;
GO

<<<<<<< HEAD
sp_LayThongTinBenhNhan 'BN001'
=======
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- =============================================
-- Procedure: Thống kê số lượng vaccine còn lại
-- =============================================
CREATE PROCEDURE sp_ThongKeSoLuongVaccine
AS
BEGIN
    SELECT TenVC, SoLuongTon
    FROM VACCINE
    ORDER BY TenVC;
END;
GO

<<<<<<< HEAD
sp_ThongKeSoLuongVaccine
=======
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- =============================================
-- Procedure: Thống kê lịch tiêm theo bệnh nhân
-- =============================================
CREATE PROCEDURE sp_ThongKeLichTiemTheoBenhNhan
    @MaBN CHAR(5)
AS
BEGIN
<<<<<<< HEAD
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        Print N'Mã bệnh nhân không tồn tại.';
=======
    -- Kiểm tra mã bệnh nhân tồn tại
    IF NOT EXISTS (SELECT * FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        RAISERROR(N'Mã bệnh nhân không tồn tại.', 16, 1);
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
        RETURN;
    END

    -- Thống kê lịch tiêm
    SELECT LT.MaLT, LT.NgayHenTiem, LT.TrangThai, VC.TenVC
    FROM LICHTIEM LT
    JOIN VACCINE VC ON LT.MaVC = VC.MaVC
    WHERE LT.MaBN = @MaBN;
END;
GO

<<<<<<< HEAD
sp_ThongKeLichTiemTheoBenhNhan 'BN555'
=======
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- =============================================
-- Procedure: Thống kê doanh thu
-- =============================================
CREATE PROCEDURE sp_ThongKeDoanhThu
AS
BEGIN
    SELECT FORMAT(NgayLap, 'yyyy-MM') AS Thang, SUM(TongTien) AS DoanhThu
    FROM HOADON
    GROUP BY FORMAT(NgayLap, 'yyyy-MM')
    ORDER BY Thang;
END;
GO
<<<<<<< HEAD

sp_ThongKeDoanhThu
=======
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- Thống kê hàm
-- 1. sp_ThemBenhNhan: Thêm bệnh nhân mới.
-- 2. sp_CapNhatBenhNhan: Cập nhật thông tin bệnh nhân.
-- 3. sp_XoaBenhNhan: Xóa bệnh nhân.
-- 4. sp_ThemLichTiem: Thêm lịch tiêm.
-- 5. sp_CapNhatTrangThaiLichTiem: Cập nhật trạng thái lịch tiêm.
-- 6. sp_ThemHoaDon: Thêm hóa đơn.
-- 7. sp_ThemChiTietHoaDon: Thêm chi tiết hóa đơn.
-- 8. sp_LayThongTinBenhNhan: Lấy thông tin bệnh nhân theo mã.
-- 9. sp_ThongKeSoLuongVaccine: Thống kê số lượng vaccine còn lại.
-- 10. sp_ThongKeLichTiemTheoBenhNhan: Thống kê lịch tiêm theo bệnh nhân.
-- 11. sp_ThongKeDoanhThu: Thống kê doanh thu.

-----------------------------------------------------------------------
--------------------------------FUNCTION-------------------------------
-----------------------------------------------------------------------

<<<<<<< HEAD
=======
-- Bệnh nhân 
-- Tạo mã tự động
CREATE FUNCTION dbo.TaoMaTuDong_BenhNhan()
RETURNS CHAR(5)
AS
BEGIN
    DECLARE @NewMaBN CHAR(5);

    SELECT @NewMaBN = 'BN' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaBN, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
    FROM BENHNHAN;

    RETURN @NewMaBN;
END;
GO
-- Nhân viên
-- Tạo mã tự động
CREATE FUNCTION dbo.TaoMaTuDong_NhanVien()
RETURNS CHAR(5)
AS
BEGIN
    DECLARE @NewMaNV CHAR(5);

    SELECT @NewMaNV = 'NV' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaNV, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
    FROM NHANVIEN;

    RETURN @NewMaNV;
END;
GO
-- Nhà cung cấp
-- Tạo mã tự động
CREATE FUNCTION dbo.TaoMaTuDong_NhanVien()
RETURNS CHAR(5)
AS
BEGIN
    DECLARE @NewMaNV CHAR(5);

    SELECT @NewMaNV = 'NV' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaNV, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
    FROM NHANVIEN;

    RETURN @NewMaNV;
END;
GO
-- Loại vaccine
-- Tạo mã tự động
CREATE FUNCTION dbo.TaoMaTuDong_LoaiVaccine()
RETURNS CHAR(5)
AS
BEGIN
    DECLARE @NewMaLoai CHAR(5);

    SELECT @NewMaLoai = 'LV' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaLoai, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
    FROM LOAIVACCINE;

    RETURN @NewMaLoai;
END;
GO
-- Vaccine
-- Tạo mã tự động
CREATE FUNCTION dbo.TaoMaTuDong_LoaiVaccine()
RETURNS CHAR(5)
AS
BEGIN
    DECLARE @NewMaLoai CHAR(5);

    SELECT @NewMaLoai = 'LV' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaLoai, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
    FROM LOAIVACCINE;

    RETURN @NewMaLoai;
END;
GO
-- Hóa đơn
-- Tạo mã tự động
CREATE FUNCTION dbo.TaoMaTuDong_HoaDon()
RETURNS CHAR(5)
AS
BEGIN
    DECLARE @NewMaHD CHAR(5);

    SELECT @NewMaHD = 'HD' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaHD, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
    FROM HOADON;

    RETURN @NewMaHD;
END;
GO
-- Phiếu nhập
-- Tạo mã tự động
CREATE FUNCTION dbo.TaoMaTuDong_PhieuNhap()
RETURNS CHAR(5)
AS
BEGIN
    DECLARE @NewMaPN CHAR(5);

    SELECT @NewMaPN = 'PN' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaPN, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
    FROM PHIEUNHAP;

    RETURN @NewMaPN;
END;
GO
-- Lịch tiêm
-- Tạo mã tự động
CREATE FUNCTION dbo.TaoMaTuDong_LichTiem()
RETURNS CHAR(5)
AS
BEGIN
    DECLARE @NewMaLT CHAR(5);

    SELECT @NewMaLT = 'LT' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaLT, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
    FROM LICHTIEM;

    RETURN @NewMaLT;
END;
GO

>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- =============================================
-- Function: Lấy số lượng vaccine còn lại
-- =============================================
CREATE FUNCTION fn_LaySoLuongVaccine (@MaVC CHAR(5))
RETURNS INT
AS
BEGIN
    DECLARE @SoLuong INT;
    SELECT @SoLuong = SoLuongTon
    FROM VACCINE
    WHERE MaVC = @MaVC;
    
    RETURN @SoLuong;
END;
GO

<<<<<<< HEAD
Declare @kq INT;
set @kq = [dbo].fn_LaySoLuongVaccine('VC001')
print @kq
=======
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- =============================================
-- Function: Kiểm tra sự tồn tại của bệnh nhân
-- =============================================
CREATE FUNCTION fn_KiemTraBenhNhan (@MaBN CHAR(5))
RETURNS BIT
AS
BEGIN
<<<<<<< HEAD
    DECLARE @kt BIT;
    IF EXISTS (SELECT 1 FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        SET @kt = 1;
    END
    ELSE
    BEGIN
        SET @kt = 0;
    END

    RETURN @kt;
END;
GO

Declare @kq BIT;
set @kq = [dbo].fn_KiemTraBenhNhan('BN066')
if @kq=0
	print N'Bệnh nhân không tồn tại'
else
	print N'Tồn tại'
=======
    DECLARE @IsExist BIT;
    IF EXISTS (SELECT 1 FROM BENHNHAN WHERE MaBN = @MaBN)
    BEGIN
        SET @IsExist = 1;
    END
    ELSE
    BEGIN
        SET @IsExist = 0;
    END

    RETURN @IsExist;
END;
GO

>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- =============================================
-- Function: Kiểm tra sự tồn tại của lịch tiêm
-- =============================================
CREATE FUNCTION fn_KiemTraLichTiem (@MaLT CHAR(5))
RETURNS BIT
AS
BEGIN
<<<<<<< HEAD
    DECLARE @kt BIT;
    IF EXISTS (SELECT 1 FROM LICHTIEM WHERE MaLT = @MaLT)
    BEGIN
        SET @kt = 1;
    END
    ELSE
    BEGIN
        SET @kt = 0;
    END

    RETURN @kt;
=======
    DECLARE @IsExist BIT;
    IF EXISTS (SELECT 1 FROM LICHTIEM WHERE MaLT = @MaLT)
    BEGIN
        SET @IsExist = 1;
    END
    ELSE
    BEGIN
        SET @IsExist = 0;
    END

    RETURN @IsExist;
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
END;
GO

-- =============================================
-- Function: Tính tổng tiền của hóa đơn
-- =============================================
<<<<<<< HEAD
CREATE FUNCTION fn_TinhTongTienCuaBenhNhan (@MaBN CHAR(5))
=======
CREATE FUNCTION fn_TinhTongTienHoaDon (@MaHD CHAR(5))
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
RETURNS FLOAT
AS
BEGIN
    DECLARE @TongTien FLOAT;
<<<<<<< HEAD
    SELECT @TongTien = SUM(TongTien)
    FROM HOADON
    WHERE MaBN = @MaBN;
=======
    SELECT @TongTien = SUM(SoLuong * DonGia)
    FROM CHITIETHOADON
    WHERE MaHD = @MaHD;
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
    
    RETURN @TongTien;
END;
GO

<<<<<<< HEAD
Declare @TongTien Float;
set @TongTien = [dbo].fn_TinhTongTienCuaBenhNhan('BN001')
print Convert(int,@TongTien)
=======
-- =============================================
-- Function: Kiểm tra tính hợp lệ của số điện thoại
-- =============================================
CREATE FUNCTION fn_KiemTraSoDienThoai (@SoDienThoai CHAR(10))
RETURNS BIT
AS
BEGIN
    DECLARE @IsValid BIT;
    IF LEN(@SoDienThoai) = 10 AND @SoDienThoai LIKE '[0-9]%' 
    BEGIN
        SET @IsValid = 1;
    END
    ELSE
    BEGIN
        SET @IsValid = 0;
    END

    RETURN @IsValid;
END;
GO
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)

-- =============================================
-- Function: Kiểm tra sự tồn tại của vaccine
-- =============================================
CREATE FUNCTION fn_KiemTraVaccine (@MaVC CHAR(5))
RETURNS BIT
AS
BEGIN
<<<<<<< HEAD
    DECLARE @kt BIT;
    IF EXISTS (SELECT 1 FROM VACCINE WHERE MaVC = @MaVC)
    BEGIN
        SET @kt = 1;
    END
    ELSE
    BEGIN
        SET @kt = 0;
    END

    RETURN @kt;
=======
    DECLARE @IsExist BIT;
    IF EXISTS (SELECT 1 FROM VACCINE WHERE MaVC = @MaVC)
    BEGIN
        SET @IsExist = 1;
    END
    ELSE
    BEGIN
        SET @IsExist = 0;
    END

    RETURN @IsExist;
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
END;
GO

-- =============================================
-- Thống kê hàm
-- 1. fn_LaySoLuongVaccine: Lấy số lượng vaccine còn lại.
-- 2. fn_KiemTraBenhNhan: Kiểm tra sự tồn tại của bệnh nhân.
-- 3. fn_KiemTraLichTiem: Kiểm tra sự tồn tại của lịch tiêm.
-- 4. fn_TinhTongTienHoaDon: Tính tổng tiền của hóa đơn.
<<<<<<< HEAD
=======
-- 5. fn_KiemTraSoDienThoai: Kiểm tra tính hợp lệ của số điện thoại.
>>>>>>> parent of 73c7e19 (Update QuanLyPhongKham_TiemChung.sql)
-- 6. fn_KiemTraVaccine: Kiểm tra sự tồn tại của vaccine.
-- =============================================

