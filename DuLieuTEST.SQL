-- Thêm dữ liệu vào bảng BENHNHAN
INSERT INTO BENHNHAN(MaBN, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai) VALUES
('BN01', N'Nguyễn Văn An', '2002-05-10', N'Nam', N'123 Lê Lợi, Quận 1, TP.HCM', '0901234567'),
('BN02', N'Trần Thị Bình', '1999-12-20', N'Nữ', N'456 Nguyễn Trãi, Quận 5, TP.HCM', '0912345678'),
('BN03', N'Lê Văn Cường', '2001-08-15', N'Nam', N'789 Pasteur, Quận 3, TP.HCM', '0923456789'),
('BN04', N'Phạm Thị Dung', '2000-04-05', N'Nữ', N'1001 CMT8, Quận 10, TP.HCM', '0934567890'),
('BN05', N'Hoàng Văn Em', '1998-09-25', N'Nam', N'1234 Cách Mạng Tháng 8, Quận 1, TP.HCM', '0945678901');

-- Thêm dữ liệu vào bảng NHANVIEN
INSERT INTO NHANVIEN(MaNV, HoTen, GioiTinh, ChucVu, DiaChi, SoDienThoai) VALUES
('NV01', N'Nguyễn Thị Phương', N'Nữ', N'Bác sĩ', N'123 Lê Lợi, Quận 1, TP.HCM', '0956789012'),
('NV02', N'Trần Văn Giang', N'Nam', N'Y tá', N'456 Nguyễn Trãi, Quận 5, TP.HCM', '0967890123');

-- Thêm dữ liệu vào bảng NHACUNGCAP
INSERT INTO NHACUNGCAP(MaNCC, TenNCC, DiaChi, SoDienThoai) VALUES
('NCC01', N'Công ty Cổ phần Dược phẩm A', N'123 Lê Lợi, Quận 1, TP.HCM', '0978901234'),
('NCC02', N'Công ty TNHH Dược phẩm B', N'456 Nguyễn Trãi, Quận 5, TP.HCM', '0989012345');

-- Thêm dữ liệu vào bảng LOAIVACINE
INSERT INTO LOAIVACINE(MaLoai, TenLoai) VALUES
('LV01', N'Vacxin Sởi'),
('LV02', N'Vacxin Viêm gan B');

-- Thêm dữ liệu vào bảng VACCINE
INSERT INTO VACCINE(MaVC, MaLoai, TenVC, NgaySX, HanSuDung, SoLuongTon, Gia) VALUES
('VC01', 'LV01', N'Vacxin Sởi MMR II', '2022-01-01', '2024-01-01', 0, 150000),
('VC02', 'LV02', N'Vacxin Viêm gan B Engerix-B', '2022-03-01', '2024-03-01', 0, 200000),
('VC03', 'LV01', N'Vacxin Sởi Priorix', '2022-05-01', '2024-05-01', 0, 175000);


-- Thêm dữ liệu vào bảng PHIEUNHAP
INSERT INTO PHIEUNHAP(MaPN, NgayNhap, MaNCC) VALUES
('PN01', '2022-04-01', 'NCC01'),
('PN02', '2022-06-01', 'NCC02');

-- Thêm dữ liệu vào bảng CHITIETPHIEUNHAP
INSERT INTO CHITIETPHIEUNHAP(MaPN, MaVC, SoLuong, DonGia) VALUES
('PN01', 'VC01', 50, 120000),
('PN01', 'VC02', 20, 170000),
('PN02', 'VC03', 30, 140000);

-- Thêm dữ liệu vào bảng HOADON
INSERT INTO HOADON(MaHD, NgayLap, MaBN, MaNV, TongTien) VALUES
('HD01', '2022-04-05', 'BN01', 'NV01', 0),
('HD02', '2022-06-05', 'BN02', 'NV02', 0);

-- Thêm dữ liệu vào bảng CHITIETHOADON
INSERT INTO CHITIETHOADON(MaHD, MaVC, SOLUONG, DONGIA) VALUES
('HD01', 'VC01', 1, 150000),
('HD02', 'VC02', 1, 200000);

-- Thêm dữ liệu vào bảng LICHTIEM
INSERT INTO LICHTIEM(MaLT, MaBN, MaVC, NgayHenTiem, TrangThai) VALUES
('LT01', 'BN01', 'VC01', '2022-04-12', N'Đã tiêm'),
('LT02', 'BN02', 'VC02', '2022-06-12', N'Chưa tiêm');

-- Thêm dữ liệu vào bảng GHINHANTIEMCHUNG
INSERT INTO GHINHANTIEMCHUNG(MaGN, MaBN, MaVC, NgayTiem, MaNV, MaLT) VALUES
('GN01', 'BN01', 'VC01', '2022-04-12', 'NV01', 'LT01');

-- Thêm dữ liệu vào bảng TAIKHOAN
INSERT INTO TAIKHOAN(UserName, Pass, ChucVu) VALUES
('admin', 'admin123', 1),
('nhanvien', 'nhanvien', 2);