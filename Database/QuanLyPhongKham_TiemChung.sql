USE master
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QUANLYPHONGKHAM_TIEMCHUNG')
BEGIN
	CREATE DATABASE QUANLYPHONGKHAM_TIEMCHUNG;
END;
GO
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

CREATE TABLE LOAIBENH
(
    MaLoai CHAR(5) PRIMARY KEY,
    TenLoai NVARCHAR(50),
    SoMui INT DEFAULT 1
);


CREATE TABLE VACCINE
(
    MaVC CHAR(5) PRIMARY KEY,        
    MaLoai CHAR(5),                   
    FOREIGN KEY(MaLoai) REFERENCES LOAIBENH(MaLoai),
    TenVC NVARCHAR(50),              
    XuatXu NVARCHAR(50) DEFAULT 'Chưa Xác Định', 
	Gia int default 0,
    SoLuongTon INT CHECK (SoLuongTon >= 0) DEFAULT 0 
);

CREATE TABLE LOVACCINE
(
    MaLo CHAR(5) not null,         
	PRIMARY KEY(MaLo,MaVC),
    MaVC CHAR(5),                   
    FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),
    NgaySX DATE,                      
    HanSuDung DATE,                   
    SoLuong INT CHECK (SoLuong >= 0)  
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
    MaLo CHAR(5) NOT NULL,         
    PRIMARY KEY(MaPN, MaVC, MaLo),  
    FOREIGN KEY(MaPN) REFERENCES PHIEUNHAP(MaPN),  
    FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),    
    FOREIGN KEY(MaLo,MaVC) REFERENCES LOVACCINE(MaLo,MaVC),  
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
    TinhTrangSucKhoe NVARCHAR(50),  
    MaLo CHAR(5),                 
    FOREIGN KEY(MaLo,MaVC) REFERENCES LOVACCINE(MaLo,MaVC)  
);
GO



-----------------------------------------------------------------------
--------------------------------TRIGER---------------------------------
-----------------------------------------------------------------------
-- chuyen thanh đã tiêm
GO
CREATE TRIGGER TG_CAPNHAPTRANGTHAILICHTIEM
ON GHINHANTIEMCHUNG
FOR INSERT
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM inserted i JOIN LICHTIEM LT ON LT.MaLT = I.MaLT WHERE i.MaVC = LT.MaVC AND LT.MaBN =i.MaBN AND LT.MaVC =I.MaVC)
    BEGIN
        PRINT N'Dữ liệu không hợp lệ! Không khớp với lịch tiêm.';
        rollback tran -- c3 bắt lỗi thêm không thành công
    END;
	UPDATE LICHTIEM
	SET TrangThai = N'Đã tiêm'
	WHERE MaLT = (SELECT MaLT FROM inserted) AND MaVC = (SELECT MaVC FROM inserted ) AND MaBN = (SELECT MaBN FROM inserted)
END

--Tinh tong tien cho phieu nhap 
GO
CREATE TRIGGER TG_TinhTongTienPN
ON CHITIETPHIEUNHAP
FOR INSERT,UPDATE
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

--INSERT INTO NHANVIEN(MaNV, HoTen,Pass, Quyen) VALUES 
--('NV001',N'Lê Bá Chiến','1',0);
--INSERT INTO LOAIBENH(MaLoai, TenLoai, SoMui) VALUES
--('LV001', N'Vacxin Viêm gan B', 3)
--INSERT INTO VACCINE(MaVC, MaLoai, TenVC, NgaySX, HanSuDung, Gia, XuatXu) VALUES
--('VC001', 'LV001', N'Engerix-B', '2022-02-01', '2025-02-01', 180000, N'Bỉ')
--INSERT INTO NHACUNGCAP(MaNCC, TenNCC, DiaChi, SoDienThoai) VALUES 
--('NCC001', N'Công ty ', N'Đường số 1', '0283811111')
--INSERT INTO PHIEUNHAP(MaPN,MaNV,NgayNhap, MaNCC) VALUES
--('PN005','NV001' ,'2022-04-02', 'NCC001')

--select * from PHIEUNHAP Where MaPN = 'PN001'
--INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) 
--VALUES ('PN005', 'VC001', 19, 150000);

--LẤY GIÁ CHO CHITIETHOADON TỪ VACCINE
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


 --tự tính tổng tiền hoá đơn 
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
GO
----TỰ TẠO LỊCH TIÊM 
--CREATE TRIGGER TR_MaLT_AutoGen
--ON LICHTIEM
--INSTEAD OF INSERT
--AS
--BEGIN
--    DECLARE @NewMaLT CHAR(5);
    
--    -- Tạo mã mới dựa trên số lượng hiện tại trong bảng LICHTIEM
--    SELECT @NewMaLT = 'LT' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaLT, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
--    FROM LICHTIEM;

--    -- Chèn vào bảng LICHTIEM với mã tự động
--    INSERT INTO LICHTIEM (MaLT, MaHD, MaBN, MaVC, NgayHenTiem, TrangThai)
--    SELECT @NewMaLT, MaHD, MaBN, MaVC, NgayHenTiem, TrangThai
--    FROM INSERTED;
--END;

--TỰ Thêm MÃ VACCINE vào LỊCH TIÊM KHI Thêm chi tiết hoá đơn
GO
CREATE TRIGGER TG_THEMLICHTIEM
ON CHITIETHOADON
FOR INSERT
AS
BEGIN
    DECLARE @NewMaLT CHAR(5);
    
    -- Tạo mã mới LT
    SELECT @NewMaLT = 'LT' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaLT, 3, 3) AS INT)), 0) + 1 AS VARCHAR(3)), 3)
    FROM LICHTIEM;

    -- Tạo lịch tiêm cho từng chi tiết hóa đơn
    INSERT INTO LICHTIEM (MaLT, MaHD, MaBN, MaVC, NgayHenTiem, TrangThai)
    SELECT 
        @NewMaLT,
        i.MaHD,
        h.MaBN,
        i.MaVC,
        GETDATE(), 
        N'Chưa tiêm'
    FROM 
        INSERTED i
    JOIN 
        HOADON h ON i.MaHD = h.MaHD;
END;
GO

--Cộng số lượng tồn trong vaccine ctpn
CREATE TRIGGER TG_CONGSOLUONGTONCUAVACCINE
ON CHITIETPHIEUNHAP
FOR INSERT
AS
BEGIN
    UPDATE V
    SET SoLuongTon =  ISNULL((SELECT SUM(CT.SoLuong) 
                              FROM CHITIETPHIEUNHAP CT
                              WHERE CT.MaVC = I.MaVC), 0) 
    FROM VACCINE V
    JOIN inserted I ON V.MaVC = I.MaVC;
END
GO
--- trừ tồn kho khi thêm chitiethoadon
CREATE TRIGGER TG_TRUTONKHOCHITIETHOADON
ON CHITIETHOADON
AFTER INSERT
AS
BEGIN
	UPDATE V
    SET SoLuongTon = V.SoLuongTon - I.SoLuong
    FROM VACCINE V
    JOIN inserted I ON V.MaVC = I.MaVC;
END;

--INSERT INTO PHIEUNHAP(MaPN,MaNV,NgayNhap, MaNCC) VALUES
--('PN004','NV001' ,'2022-04-02', 'NCC001')

--select * from VACCINE Where MaVC = 'VC001'

--INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) 
--VALUES ('PN004', 'VC001', 19, 150000);

----kIEM TRA SO LUONG MUI TRUOC KHI TIEM
--CREATE TRIGGER tg_KTSoluongdatiem
--ON CHITIETHOADON
--FOR INSERT
--AS
--BEGIN
--    DECLARE @MaBN NVARCHAR(6), @MaVC NVARCHAR(6), @SoLuong INT, @SoMui INT, @TongSoLuong INT;

--    -- Lấy thông tin từ bảng `inserted`
--    SELECT 
--        @MaBN = HD.MaBN,
--        @MaVC = i.MaVC,
--        @SoLuong = i.SOLUONG
--    FROM 
--        inserted i
--        JOIN HOADON HD ON i.MaHD = HD.MaHD;

--    -- Tính tổng số lượng đã tiêm cho loại vaccine này
--    SELECT 
--        @TongSoLuong = ISNULL(SUM(CTHD.SOLUONG),0)
--    FROM 
--        CHITIETHOADON CTHD
--        JOIN HOADON HD ON CTHD.MaHD = HD.MaHD
--    WHERE 
--        HD.MaBN = @MaBN AND CTHD.MaVC = @MaVC;

--    -- Lấy số mũi tối đa cho loại vaccine
--    SELECT 
--        @SoMui = LC.SOMUI
--    FROM 
--        LOAIBENH LC
--        JOIN VACCINE VC ON VC.MaLoai = LC.MaLoai
--    WHERE 
--        VC.MaVC = @MaVC;

--    -- Kiểm tra số lượng
--    IF ((@SoLuong + @TongSoLuong) > @SoMui)
--    BEGIN
--        PRINT N'Bạn đã tiêm đủ số lượng mũi cho loại Vaccine này.';
--        rollback tran -- c3 bắt lỗi thêm không thành côngSACTION;
--    END
--    ELSE
--    BEGIN
--        PRINT N'Đã thêm thành công hóa đơn cho bạn.';
--    END
--END;


--INSERT INTO BENHNHAN(MaBN, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai) VALUES 
--('BN001', N'Nguyễn Văn An', '2003-01-15', N'Nam', N'12 Nguyễn Trãi, Quận 1, TP.HCM', '0912345678')
--INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
--('HD004', '2022-01-05', 'BN001', 'NV001');

--select * from LOAIBENH where MaLoai = 'LV001'
--select * from VACCINE where MaVC = 'VC001'

--INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD003', 'VC001', 1);


--========================Thủ tục==========================================================

--thong ke so tien da nhap vaccine theo thang
GO
create proc pro_thongkenhaphang as
begin 
     SELECT CONCAT(MONTH(NgayNhap), '/', YEAR(NgayNhap)) AS ThangNam, SUM(TongTien) AS TongTien
            FROM PHIEUNHAP
            GROUP BY YEAR(NgayNhap), MONTH(NgayNhap)
            ORDER BY YEAR(NgayNhap), MONTH(NgayNhap)       
end;

-- thong ke so luong vaccine đã được tiêm theo loại
go
create proc pro_thongkesoluongtheoloai as
begin 
	select LVC.TenLoai , sum(CTHD.SOLUONG) as SoLuong from VACCINE 
	join CHITIETHOADON CTHD on CTHD.MaVC = VACCINE.MaVC 
	join LOAIBENH LVC on LVC.MaLoai = VACCINE.MaLoai
	Group by LVC.TenLoai
end;

EXEC pro_thongkenhaphang

-- kiemtra tinh trang ton kho
go
create proc pro_tinhtrangvacine @mavc char(6) as
begin
	DECLARE @soluongton int;
	select @soluongton = ISNULL(SoLuongTon,0)
	from VACCINE 
	where MaVC = @mavc
	IF (@soluongton < 2)
    BEGIN
        PRINT CONCAT(N'Vaccine của bạn gần như đã hết, hãy nhập hàng đi nhé! Nó chỉ còn: ', @soluongton);
    END
    ELSE IF (@soluongton < 10)
    BEGIN
        PRINT CONCAT(N'Vaccine của bạn sắp hết, hãy nhập hàng đi nhé! Nó chỉ còn: ', @soluongton);
    END
    ELSE
    BEGIN
        PRINT CONCAT(N'Vaccine của bạn vẫn còn đủ! Nó còn: ', @soluongton);
    END
END;

--INSERT INTO VACCINE(MaVC, MaLoai, TenVC, NgaySX, HanSuDung, Gia, XuatXu) VALUES
--('VC002', 'LV001', N'Engerix-C', '2022-02-01', '2025-02-01', 180000, N'Bỉ')
--INSERT INTO VACCINE(MaVC, MaLoai, TenVC, NgaySX, HanSuDung, Gia, XuatXu) VALUES
--('VC003', 'LV001', N'Engerix-C', '2022-02-01', '2025-02-01', 180000, N'Bỉ')
--INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) 
--VALUES ('PN001', 'VC002', 7, 150000);
--INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) 
--VALUES ('PN001', 'VC003', 1, 150000);

--exec pro_tinhtrangvacine 'VC001'
--exec pro_tinhtrangvacine 'VC002'
--exec pro_tinhtrangvacine 'VC003'
GO
-- thêm vc
CREATE PROCEDURE pro_them_vaccine 
    @MaVC CHAR(6), 
    @MaLoai CHAR(6), 
    @TenVC NVARCHAR(100), 
    @Gia INT, 
    @XuatXu NVARCHAR(100)
AS
BEGIN
    begin try
		INSERT INTO VACCINE (MaVC, MaLoai, TenVC, Gia, XuatXu)
		VALUES (@MaVC, @MaLoai, @TenVC, @Gia, @XuatXu)
	end try
	begin catch	
		rollback tran -- c3 bắt lỗi thêm không thành công --bat lỗi ở c# báo không thanh công
	end catch
END;
GO
--EXEC pro_them_vaccine @MaVC = 'VC923', @MaLoai = 'LV001', @TenVC = N'Engerix-B', @NgaySX = '2022-02-01', 
--	@HanSuDung = '2025-02-01', 
--    @Gia = 180000, 
--    @XuatXu = N'Bỉ';

--cap nhật thông tin vaccine
CREATE PROCEDURE pro_capnhat_vaccine
    @MaVC CHAR(6),
    @MaLoai CHAR(6),
    @TenVC NVARCHAR(100),
    @Gia INT,
    @XuatXu NVARCHAR(100)
AS
BEGIN
    BEGIN TRY
        UPDATE VACCINE
        SET MaLoai = @MaLoai,
            TenVC = @TenVC,
            Gia = @Gia,
            XuatXu = @XuatXu
        WHERE MaVC = @MaVC;
    END TRY
    BEGIN CATCH
        rollback tran -- c3 bắt lỗi thêm không thành công --c# bắt lỗi và sẽ được thông báo ra
    END CATCH;
END;
GO
-- xoá vaccine
CREATE PROCEDURE pro_xoa_vaccine
    @MaVC CHAR(6)
AS
BEGIN
    BEGIN TRY
        DELETE FROM VACCINE
        WHERE MaVC = @MaVC;
    END TRY
    BEGIN CATCH
		rollback tran -- c3 bắt lỗi thêm không thành côngSACTION; -- c# bắt lỗi không thành công
    END CATCH;
END;

--EXEC pro_xoa_vaccine 'VC'

-------------------------------------------LoạiVACINE---------------------
--thêm loại vaccine
GO
CREATE PROCEDURE pro_them_LOAIBENH 
    @MaLoai CHAR(6), 
    @TenLoai NVARCHAR(100), 
    @SoMui INT
AS
BEGIN
    begin try
        INSERT INTO LOAIBENH (MaLoai, TenLoai, SoMui)
        VALUES (@MaLoai, @TenLoai, @SoMui);
    end try
    BEGIN CATCH
		rollback tran -- c3 bắt lỗi thêm không thành công -- c# báo khi thêm khôgn thành công
    END CATCH 
END;
GO
--EXEC pro_them_LOAIBENH 
--    @MaLoai = 'LV001', 
--    @TenLoai = N'Vacxin Viêm gan A', 
--    @SoMui = 2;

--Cap nhat loại vaccine 
CREATE PROCEDURE pro_capnhat_LOAIBENH 
    @MaLoai CHAR(6), 
    @TenLoai NVARCHAR(100), 
    @SoMui INT
AS
BEGIN
    begin try
        update LOAIBENH
		set MaLoai = @MaLoai,
			TenLoai = @TenLoai,
			SoMui = @SoMui
		where MaLoai = @MaLoai
    end try
    BEGIN CATCH
		rollback tran -- c3 bắt lỗi thêm không thành công -- c# báo khi thêm khôgn thành công
    END CATCH 
END;
GO
--Xoá loại vaccine
CREATE PROCEDURE pro_xoa_LOAIBENH
    @MaLoai CHAR(6)
AS
BEGIN
    BEGIN TRY
        DELETE FROM LOAIBENH
        WHERE MaLoai = @MaLoai;
    END TRY
    BEGIN CATCH
		rollback tran -- c3 bắt lỗi thêm không thành côngSACTION; -- c# bắt lỗi không thành công
    END CATCH;
END;

-----------------------------Phiêu nhập------------------------
-- thêm phieu nhap 
GO
CREATE PROCEDURE pro_them_phieunhap 
    @MaPN CHAR(6), 
    @MaNV CHAR(6), 
    @NgayNhap DATE, 
    @MaNCC CHAR(6)
AS
BEGIN
    BEGIN TRY
        INSERT INTO PHIEUNHAP (MaPN, MaNV, NgayNhap, MaNCC)
        VALUES (@MaPN, @MaNV, @NgayNhap, @MaNCC);
    END TRY
    BEGIN CATCH
		rollback tran -- c3 bắt lỗi thêm không thành công
    END CATCH
END;

--EXEC pro_them_phieunhap 'PN001', 'NV001', '2022-04-02', 'NCC001';

GO
--------------------------LO_vaccine------------------------
-- them Lo vaccine
CREATE PROCEDURE pro_them_lovacine 
    @MaLo CHAR(6), 
    @MaVC CHAR(6), 
	@nsx date,
    @hsd date, 
    @soluong INT
AS
BEGIN
    BEGIN TRY
		INSERT INTO LOVACCINE([MaLo], [MaVC], [NgaySX], [HanSuDung], [SoLuong])
		VALUES (@MaLo,@MaVC,@nsx,@hsd,@soluong);
    END TRY
    BEGIN CATCH
        rollback tran -- c3 bắt lỗi thêm không thành công
    END CATCH
END;

--EXEC pro_them_lovacine 'ML002', 'VC023', '2024-12-06', '2026-12-06', '1'

-------------------chitiet phieunhap-----------------
-- them chi tiet phieu nhap 
GO
CREATE PROCEDURE pro_them_chitietphieunhap 
    @MaPN CHAR(6), 
    @MaVC CHAR(6), 
	@MaLo CHAR(6),
    @SoLuong INT, 
    @DonGia INT
AS
BEGIN
    BEGIN TRY
		INSERT INTO CHITIETPHIEUNHAP ([MaPN], [MaVC], [MaLo], [SoLuong], [DonGia])
		VALUES (@MaPN, @MaVC,@MaLo, @SoLuong, @DonGia);
    END TRY
    BEGIN CATCH
        rollback tran -- c3 bắt lỗi thêm không thành công
    END CATCH
END;
GO

--EXEC pro_them_chitietphieunhap 'PN011', 'VC018', 'ML001', '1', '180000'

--EXEC pro_them_chitietphieunhap 'PN006', 'VC003', 10, 150000;


----------------------NHÀ CUNG CẤP ----------------------------------
-- thêm nhà cung cấp
CREATE PROc pro_them_nhacungcap
    @MaNCC CHAR(6), 
    @TenNCC NVARCHAR(200), 
    @DiaChi NVARCHAR(200), 
    @SoDienThoai CHAR(10)
AS
BEGIN
    BEGIN TRY
        INSERT INTO NHACUNGCAP (MaNCC, TenNCC, DiaChi, SoDienThoai)
        VALUES (@MaNCC, @TenNCC, @DiaChi, @SoDienThoai);
    END TRY
    BEGIN CATCH
		rollback tran -- c3 bắt lỗi thêm không thành công
    END CATCH
END;
GO
-- cap nhat nha cung cấp
CREATE PROc pro_caonhat_nhacungcap
    @MaNCC CHAR(6), 
    @TenNCC NVARCHAR(200), 
    @DiaChi NVARCHAR(200), 
    @SoDienThoai CHAR(10)
AS
BEGIN
    BEGIN TRY
        UPDATE NHACUNGCAP
		SET MaNCC = @MaNCC,
			TenNCC = @TenNCC,
			DiaChi = @DiaChi,
			SoDienThoai = @SoDienThoai
		where MaNCC = @MaNCC
    END TRY
    BEGIN CATCH
		rollback tran -- c3 bắt lỗi thêm không thành công
    END CATCH
END;

GO

--Xoá loại nhà cung cấp
CREATE PROCEDURE pro_xoa_nhacungcap
    @MaNCC CHAR(6)
AS
BEGIN
    BEGIN TRY
        DELETE FROM NHACUNGCAP
        WHERE MaNCC = @MaNCC;
    END TRY
    BEGIN CATCH
		rollback tran -- c3 bắt lỗi thêm không thành công
    END CATCH;
END;
-- test

----kIEM TRA SO LUONG MUI TRUOC KHI TIEM
--CREATE TRIGGER tg_KTSoluongdatiem
--ON CHITIETHOADON
--FOR INSERT
--AS
--BEGIN
--    DECLARE @MaBN NVARCHAR(6), @MaVC NVARCHAR(6), @SoLuong INT, @SoMui INT, @TongSoLuong INT;

--    SELECT 
--        @MaBN = HD.MaBN,
--        @MaVC = i.MaVC,
--        @SoLuong = i.SOLUONG
--    FROM 
--        inserted i
--        JOIN HOADON HD ON i.MaHD = HD.MaHD;

--    -- Tính tổng số lượng đã tiêm cho loại vaccine này
--    SELECT 
--        @TongSoLuong = ISNULL(SUM(CTHD.SOLUONG),0)
--    FROM 
--        CHITIETHOADON CTHD
--        JOIN HOADON HD ON CTHD.MaHD = HD.MaHD
--    WHERE 
--        HD.MaBN = @MaBN AND CTHD.MaVC = @MaVC;

--    -- Lấy số mũi tối đa cho loại vaccine
--    SELECT 
--        @SoMui = LC.SOMUI
--    FROM 
--        LOAIBENH LC
--        JOIN VACCINE VC ON VC.MaLoai = LC.MaLoai
--    WHERE 
--        VC.MaVC = @MaVC;

--    -- Kiểm tra số lượng
--    IF ((@SoLuong + @TongSoLuong) > @SoMui)
--    BEGIN
--        PRINT N'Bạn đã tiêm đủ số lượng mũi cho loại Vaccine này.';
--        rollback tran -- c3 bắt lỗi thêm không thành côngSACTION;
--    END
--    ELSE
--    BEGIN
--        PRINT N'Đã thêm thành công hóa đơn cho bạn.';
--    END
--END;


--INSERT INTO BENHNHAN(MaBN, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai) VALUES 
--('BN001', N'Nguyễn Văn An', '2003-01-15', N'Nam', N'12 Nguyễn Trãi, Quận 1, TP.HCM', '0912345678')
--INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
--('HD004', '2022-01-05', 'BN001', 'NV001');

--select * from LOAIBENH where MaLoai = 'LV001'
--select * from VACCINE where MaVC = 'VC001'

--INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD003', 'VC001', 1);