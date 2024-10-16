--CREATE DATABASE QUANLYPHONGKHAM_TIEMCHUNG

CREATE TABLE BENHNHAN 
(
	MaBN CHAR(5) PRIMARY KEY,
	HoTen NVARCHAR(50),
	NgaySinh DATE,
	GioiTinh NVARCHAR(3) CHECK (GioiTinh IN ('Nam', N'Nữ')),
	DiaChi NVARCHAR(90),
	SoDienThoai CHAR(10) CHECK (LEN(SoDienThoai) = 10 AND SoDienThoai LIKE '[0-9]%'),
)
CREATE TABLE NHANVIEN
(
	MaNV CHAR(5) PRIMARY KEY,
	HoTen NVARCHAR(50),
	GioiTinh NVARCHAR(3) CHECK (GioiTinh IN ('Nam', N'Nữ')),
	ChucVu NVARCHAR(30),
	DiaChi NVARCHAR(90),
	SoDienThoai CHAR(10) CHECK (LEN(SoDienThoai) = 10 AND SoDienThoai LIKE '[0-9]%'),
)


CREATE TABLE NHACUNGCAP
(
	MaNCC CHAR(5) PRIMARY KEY,
	TenNCC NVARCHAR(200),
	DiaChi NVARCHAR(200),
	SoDienThoai CHAR(10) CHECK (LEN(SoDienThoai) = 10 AND SoDienThoai LIKE '[0-9]%'),
)

CREATE TABLE LOAIVACCINE
(
	MaLoai CHAR(5) PRIMARY KEY,
	TenLoai NVARCHAR(50),
)

CREATE TABLE VACCINE
(
	MaVC CHAR(5) PRIMARY KEY ,
	MaLoai CHAR(5),
	FOREIGN KEY(MaLoai) REFERENCES LOAIVACCINE(MaLoai),
	TenVC NVARCHAR(50),
	NgaySX DATE ,
	HanSuDung DATE,
	SoLuongTon INT CHECK (SoLuongTon >= 0) DEFAULT 0,
	Gia INT CHECK (Gia >= 0) DEFAULT 0,
	CHECK (HanSuDung > NgaySX)  
)

CREATE TABLE PHIEUNHAP
(
	MaPN CHAR(5) PRIMARY KEY,
	NgayNhap DATE,
	MaNCC CHAR(5) NOT NULL ,
	FOREIGN KEY(MaNCC) REFERENCES NHACUNGCAP(MaNCC),
)

CREATE TABLE CHITIETPHIEUNHAP
(
	MaPN CHAR(5) NOT NULL ,
	MaVC CHAR(5) NOT NULL ,
	PRIMARY KEY(MaPN,MaVC),
	FOREIGN KEY(MaPN) REFERENCES PHIEUNHAP(MaPN),
	FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),
	SoLuong INT ,
	DonGia FLOAT,
)

CREATE TABLE HOADON
(
	MaHD CHAR(5) PRIMARY KEY ,
	NgayLap DATE,
	MaBN CHAR(5) NOT NULL,
	FOREIGN KEY(MaBN) REFERENCES BENHNHAN(MaBN),
	MaNV CHAR(5) NOT NULL,
	FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV),
	TongTien FLOAT CHECK (TongTien >= 0) DEFAULT 0,
)

CREATE TABLE CHITIETHOADON
(
	MaHD CHAR(5) NOT NULL,
	MaVC CHAR(5) NOT NULL,
	PRIMARY KEY(MaHD,MaVC),
	FOREIGN KEY(MaHD) REFERENCES HOADON(MaHD),
	FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),
	SOLUONG INT DEFAULT 0,
	DONGIA FLOAT DEFAULT 0,
)
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
	PRIMARY KEY(MaBN, MaVC, MaLT,MaNV),
	TinhTrangSucKhoe NVARCHAR(50),
);



CREATE TABLE TAIKHOAN
(
	UserName VARCHAR(15) PRIMARY KEY,
	DisplayName NVARCHAR(30),
	Pass VARCHAR(30) NOT NULL DEFAULT 2,
	ChucVu INT NOT NULL,
)
-------------------------------------------------------------------------------
--------------------------------Tạo_Mã_Tự_Động---------------------------------
-------------------------------------------------------------------------------

-- Tạo bảng lưu trữ giá trị mã cuối cùng
CREATE TABLE MaBN_Counter (MaBN INT);
CREATE TABLE MaNV_Counter (MaNV INT);
CREATE TABLE MaNCC_Counter (MaNCC INT);
CREATE TABLE MaLoaiVC_Counter (MaLoaiVC INT);
CREATE TABLE MaVC_Counter (MaVC INT);
CREATE TABLE MaPN_Counter (MaPN INT);
CREATE TABLE MaHD_Counter (MaHD INT);
CREATE TABLE MaLT_Counter (MaLT INT);

-- Khởi tạo giá trị ban đầu cho các bảng counter
INSERT INTO MaBN_Counter (MaBN) VALUES (0);
INSERT INTO MaNV_Counter (MaNV) VALUES (0);
INSERT INTO MaNCC_Counter (MaNCC) VALUES (0);
INSERT INTO MaLoaiVC_Counter (MaLoaiVC) VALUES (0);
INSERT INTO MaVC_Counter (MaVC) VALUES (0);
INSERT INTO MaPN_Counter (MaPN) VALUES (0);
INSERT INTO MaHD_Counter (MaHD) VALUES (0);
INSERT INTO MaLT_Counter (MaLT) VALUES (0);


-- Tạo trigger cho bảng BENHNHAN
-- Batch 1: Tạo Trigger cho bảng BENHNHAN
CREATE TRIGGER TR_MaBN_AutoGen
ON BENHNHAN
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaBN VARCHAR(10);
    DECLARE @CurrentCounter INT;

    -- Lấy giá trị mã cuối cùng
    SELECT @CurrentCounter = MaBN FROM MaBN_Counter;

    -- Kiểm tra nếu counter là null
    IF @CurrentCounter IS NULL
    BEGIN
        PRINT N'Giá trị counter không được khởi tạo';
        RETURN;
    END

    -- Tạo mã mới
    SET @NewMaBN = 'BN' + RIGHT('000' + CAST(@CurrentCounter + 1 AS VARCHAR(3)), 3);

    -- Cập nhật giá trị mã cuối cùng
    UPDATE MaBN_Counter SET MaBN = @CurrentCounter + 1;

    -- Chèn vào bảng BENHNHAN với mã tự động
    INSERT INTO BENHNHAN (MaBN, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai)
    SELECT @NewMaBN, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai
    FROM INSERTED;
END;
GO
CREATE TRIGGER TR_MaNV_AutoGen
ON NHANVIEN
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaNV VARCHAR(10);
    DECLARE @CurrentCounter INT;

    -- Lấy giá trị mã cuối cùng
    SELECT @CurrentCounter = MaNV FROM MaNV_Counter;

    -- Tạo mã mới
    SET @NewMaNV = 'NV' + RIGHT('000' + CAST(@CurrentCounter + 1 AS VARCHAR(3)), 3);

    -- Cập nhật giá trị mã cuối cùng
    UPDATE MaNV_Counter SET MaNV = @CurrentCounter + 1;

    -- Chèn vào bảng NHANVIEN với mã tự động
    INSERT INTO NHANVIEN (MaNV, HoTen, GioiTinh, ChucVu, DiaChi, SoDienThoai)
    SELECT @NewMaNV, HoTen, GioiTinh, ChucVu, DiaChi, SoDienThoai
    FROM INSERTED;
END;
GO
CREATE TRIGGER TR_MaNCC_AutoGen
ON NHACUNGCAP
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaNCC VARCHAR(10);
    DECLARE @CurrentCounter INT;

    -- Lấy giá trị mã cuối cùng
    SELECT @CurrentCounter = MaNCC FROM MaNCC_Counter;

    -- Tạo mã mới
    SET @NewMaNCC = 'NCC' + RIGHT('00' + CAST(@CurrentCounter + 1 AS VARCHAR(2)), 2);

    -- Cập nhật giá trị mã cuối cùng
    UPDATE MaNCC_Counter SET MaNCC = @CurrentCounter + 1;

    -- Chèn vào bảng NHACUNGCAP với mã tự động
    INSERT INTO NHACUNGCAP (MaNCC, TenNCC, DiaChi, SoDienThoai)
    SELECT @NewMaNCC, TenNCC, DiaChi, SoDienThoai
    FROM INSERTED;
END;
GO
CREATE TRIGGER TR_MaLoaiVC_AutoGen
ON LOAIVACCINE
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaLoaiVC VARCHAR(10);
    DECLARE @CurrentCounter INT;

    -- Lấy giá trị mã cuối cùng
    SELECT @CurrentCounter = MaLoaiVC FROM MaLoaiVC_Counter;

    -- Tạo mã mới
    SET @NewMaLoaiVC = 'LV' + RIGHT('000' + CAST(@CurrentCounter + 1 AS VARCHAR(3)), 3);

    -- Cập nhật giá trị mã cuối cùng
    UPDATE MaLoaiVC_Counter SET MaLoaiVC = @CurrentCounter + 1;

    -- Chèn vào bảng LOAIVACCINE với mã tự động
    INSERT INTO LOAIVACCINE (MaLoai, TenLoai)
    SELECT @NewMaLoaiVC, TenLoai
    FROM INSERTED;
END;
GO

-- Tạo trigger cho bảng VACCINE
CREATE TRIGGER TR_MaVC_AutoGen
ON VACCINE
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaVC VARCHAR(10);
    DECLARE @CurrentCounter INT;

    -- Lấy giá trị mã cuối cùng
    SELECT @CurrentCounter = MaVC FROM MaVC_Counter;

    -- Tạo mã mới
    SET @NewMaVC = 'VC' + RIGHT('000' + CAST(@CurrentCounter + 1 AS VARCHAR(3)), 3);

    -- Cập nhật giá trị mã cuối cùng
    UPDATE MaVC_Counter SET MaVC = @CurrentCounter + 1;

    -- Chèn vào bảng VACCINE với mã tự động
    INSERT INTO VACCINE (MaVC, MaLoai, TenVC, NgaySX, HanSuDung, SoLuongTon, Gia)
    SELECT @NewMaVC, MaLoai, TenVC, NgaySX, HanSuDung, SoLuongTon, Gia
    FROM INSERTED;
END;
GO


-- Tạo trigger cho bảng PHIEUNHAP
CREATE TRIGGER TR_MaPN_AutoGen
ON PHIEUNHAP
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaPN VARCHAR(10);
    DECLARE @CurrentCounter INT;

    -- Lấy giá trị mã cuối cùng
    SELECT @CurrentCounter = MaPN FROM MaPN_Counter;

    -- Tạo mã mới
    SET @NewMaPN = 'PN' + RIGHT('000' + CAST(@CurrentCounter + 1 AS VARCHAR(3)), 3);

    -- Cập nhật giá trị mã cuối cùng
    UPDATE MaPN_Counter SET MaPN = @CurrentCounter + 1;

    -- Chèn vào bảng PHIEUNHAP với mã tự động
    INSERT INTO PHIEUNHAP (MaPN, NgayNhap, MaNCC)
    SELECT @NewMaPN, NgayNhap, MaNCC
    FROM INSERTED;
END;
GO

-- Tạo trigger cho bảng HOADON
CREATE TRIGGER TR_MaHD_AutoGen
ON HOADON
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaHD VARCHAR(10);
    DECLARE @CurrentCounter INT;

    -- Lấy giá trị mã cuối cùng
    SELECT @CurrentCounter = MaHD FROM MaHD_Counter;

    -- Tạo mã mới
    SET @NewMaHD = 'HD' + RIGHT('000' + CAST(@CurrentCounter + 1 AS VARCHAR(3)), 3);

    -- Cập nhật giá trị mã cuối cùng
    UPDATE MaHD_Counter SET MaHD = @CurrentCounter + 1;

    -- Chèn vào bảng HOADON với mã tự động
    INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV, TongTien)
    SELECT @NewMaHD, NgayLap, MaBN, MaNV, TongTien
    FROM INSERTED;
END;
GO


-- Tạo trigger cho bảng LICHTIEM
CREATE TRIGGER TR_MaLT_AutoGen
ON LICHTIEM
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewMaLT VARCHAR(10);
    DECLARE @CurrentCounter INT;

    -- Lấy giá trị mã cuối cùng
    SELECT @CurrentCounter = MaLT FROM MaLT_Counter;

    -- Tạo mã mới
    SET @NewMaLT = 'LT' + RIGHT('000' + CAST(@CurrentCounter + 1 AS VARCHAR(3)), 3);

    -- Cập nhật giá trị mã cuối cùng
    UPDATE MaLT_Counter SET MaLT = @CurrentCounter + 1;

    -- Chèn vào bảng LICHTIEM với mã tự động
    INSERT INTO LICHTIEM (MaLT, MaHD, MaBN, MaVC, NgayHenTiem, TrangThai)
    SELECT @NewMaLT, MaHD, MaBN, MaVC, NgayHenTiem, TrangThai
    FROM INSERTED;
END;
GO

-----------------------------------------------------------------------
--------------------------------TRIGER---------------------------------
-----------------------------------------------------------------------

--LẤY GIÁ CHOCHITIETHOADON TỪ VACCINE
GO 
CREATE TRIGGER TG_LAYDONGIACHOCTHD
ON CHITIETHOADON
FOR INSERT,UPDATE
AS
BEGIN
	UPDATE CHITIETHOADON
	SET CHITIETHOADON.DONGIA = VC.Gia
	FROM VACCINE VC
	WHERE VC.MaVC = CHITIETHOADON.MaVC
END
-- tự tính tổng tiền hoá đơn 
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


--TỰ TẠO LỊCH TIÊM KHI CÓ HOÁ ĐƠN
GO 
CREATE TRIGGER TG_TAOLICHTIEMKHITHEMHOADON
ON HOADON
FOR INSERT
AS
BEGIN
	INSERT INTO LICHTIEM([MaHD], [MaBN], [TrangThai])
	SELECT i.MaHD, i.MaBN, N'Chưa tiêm'
    FROM INSERTED i;
END

--TỰ Thêm MÃ VACCINE vào LỊCH TIÊM KHI Thêm chi tiết hoá đơn
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


--Cộng số lượng tồn trong vaccine
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

--Sau khi thêm GHINHANTIEMCHUNG, cập nhật TrangThai trong bảng LICHTIEM.
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

-- Kiểm tra số lượng vaccine trước khi thêm/cập nhật CHITIETHOADON.
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

CREATE CLUSTERED INDEX IX_MaBN_Counter ON dbo.MaBN_Counter (MaBN);
CREATE CLUSTERED INDEX IX_MaNV_Counter ON dbo.MaNV_Counter (MaNV);
CREATE CLUSTERED INDEX IX_MaNCC_Counter ON dbo.MaNCC_Counter (MaNCC);
CREATE CLUSTERED INDEX IX_MaLoaiVC_Counter ON dbo.MaLoaiVC_Counter (MaLoaiVC);
CREATE CLUSTERED INDEX IX_MaVC_Counter ON dbo.MaVC_Counter (MaVC);
CREATE CLUSTERED INDEX IX_MaPN_Counter ON dbo.MaPN_Counter (MaPN);
CREATE CLUSTERED INDEX IX_MaHD_Counter ON dbo.MaHD_Counter (MaHD);
CREATE CLUSTERED INDEX IX_MaLT_Counter ON dbo.MaLT_Counter (MaLT);


----------------------------------------------------------------------
--------------------------Procedures----------------------------------
----------------------------------------------------------------------

--ThemLichTiem(@MaLT, @MaVC,@MaBN @NgayHenTiem)
--GO
--CREATE PROC PR_ThemLichTiem @MaLT CHAR(5), @MaVC CHAR(5),@MaNV CHAR(5),@MaBN CHAR(5), @NgayHenTiem DATE
--AS
--	IF EXISTS (SELECT * FROM LICHTIEM WHERE MaLT= @MaLT)
--		BEGIN
--			PRINT N'Mã lịch tiêm đã tồn tại'
--		END
--	ELSE IF NOT EXISTS ( SELECT * FROM LICHTIEM WHERE MaBN = @MaBN and MaVC =@MaVC )
--		BEGIN
--			PRINT N'Dử liệu không đúng'
--		END
--	ELSE
--		BEGIN 
--			INSERT INTO LICHTIEM([MaLT], [MaBN], [MaVC], [NgayHenTiem], [TrangThai]) VALUES(@MaLT,@MaBN,@MaVC,@NgayHenTiem,'Chưa tiêm')
--		END
	
--exec PR_ThemLichTiem 'LT001','VC0006','NV0001','BN0002','2023-12-02'

--select * from LICHTIEM
	


