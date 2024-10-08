﻿--CREATE DATABASE QUANLYPHONGKHAM_TIEMCHUNG

CREATE TABLE BENHNHAN 
(
	MaBN CHAR(10) NOT NULL PRIMARY KEY,
	HoTen NVARCHAR(50),
	NgaySinh DATE,
	GioiTinh NVARCHAR(3) CHECK (GioiTinh IN ('Nam', N'Nữ')),
	DiaChi NVARCHAR(90),
	SoDienThoai CHAR(10) CHECK (LEN(SoDienThoai) = 10 AND SoDienThoai LIKE '[0-9]%') UNIQUE (SoDienThoai),
)
CREATE TABLE NHANVIEN
(
	MaNV CHAR(10) NOT NULL PRIMARY KEY,
	HoTen NVARCHAR(50),
	GioiTinh NVARCHAR(3) CHECK (GioiTinh IN ('Nam', N'Nữ')),
	ChucVu NVARCHAR(30),
	DiaChi NVARCHAR(90),
	SoDienThoai CHAR(10) CHECK (LEN(SoDienThoai) = 10 AND SoDienThoai LIKE '[0-9]%') UNIQUE (SoDienThoai),
)


CREATE TABLE NHACUNGCAP
(
	MaNCC CHAR(10) NOT NULL PRIMARY KEY,
	TenNCC NVARCHAR(50),
	DiaChi NVARCHAR(60),
	SoDienThoai CHAR(10) CHECK (LEN(SoDienThoai) = 10 AND SoDienThoai LIKE '[0-9]%') UNIQUE (SoDienThoai),
)

CREATE TABLE LOAIVACINE
(
	MaLoai CHAR(10) NOT NULL PRIMARY KEY,
	TenLoai NVARCHAR(50),
)

CREATE TABLE VACCINE
(
	MaVC CHAR(10) NOT NULL PRIMARY KEY ,
	MaLoai CHAR(10),
	FOREIGN KEY(MaLoai) REFERENCES LOAIVACINE(MaLoai),
	TenVC NVARCHAR(50),
	NgaySX DATE ,
	HanSuDung DATE,
	SoLuongTon INT CHECK (SoLuongTon >= 0),
	Gia INT CHECK (Gia >= 0) DEFAULT 0,
	CHECK (HanSuDung > NgaySX)  
)

CREATE TABLE PHIEUNHAP
(
	MaPN CHAR(10) NOT NULL PRIMARY KEY,
	NgayNhap DATE,
	MaNCC CHAR(10) NOT NULL ,
	FOREIGN KEY(MaNCC) REFERENCES NHACUNGCAP(MaNCC),
)

CREATE TABLE CHITIETPHIEUNHAP
(
	MaPN CHAR(10) NOT NULL ,
	MaVC CHAR(10) NOT NULL ,
	PRIMARY KEY(MaPN,MaVC),
	FOREIGN KEY(MaPN) REFERENCES PHIEUNHAP(MaPN),
	FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),
	SoLuong INT ,
	DonGia FLOAT,
)

CREATE TABLE HOADON
(
	MaHD CHAR(10) NOT NULL PRIMARY KEY ,
	NgayLap DATE,
	MaBN CHAR(10) NOT NULL,
	FOREIGN KEY(MaBN) REFERENCES BENHNHAN(MaBN),
	MaNV CHAR(10) NOT NULL,
	FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV),
	TongTien FLOAT CHECK (TongTien >= 0),
)

CREATE TABLE CHITIETHOADON
(
	MaHD CHAR(10) NOT NULL,
	MaVC CHAR(10) NOT NULL,
	PRIMARY KEY(MaHD,MaVC),
	FOREIGN KEY(MaHD) REFERENCES HOADON(MaHD),
	FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),
	SOLUONG INT,
	DONGIA FLOAT,
)

CREATE TABLE GHINHANTIEMCHUNG
(
	MaGN CHAR(10) NOT NULL PRIMARY KEY,
	MaBN CHAR(10) NOT NULL ,
	FOREIGN KEY(MaBN) REFERENCES BENHNHAN(MaBN),
	MaVC CHAR(10) NOT NULL,
	FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),
	NgayTiem DATE,
	MaNV CHAR(10) NOT NULL,
	FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV),
)

CREATE TABLE LICHTIEM 
(
	MaLT CHAR(10) NOT NULL PRIMARY KEY,
	MaBN CHAR(10) NOT NULL ,
	FOREIGN KEY(MaBN) REFERENCES BENHNHAN(MaBN),
	MaVC CHAR(10) NOT NULL ,
	FOREIGN KEY(MaVC) REFERENCES VACCINE(MaVC),
	NgayHenTiem	DATE,
	TrangThai NVARCHAR(15),
)
