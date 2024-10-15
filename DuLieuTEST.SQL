---------------------------------------------------------------------------------------
--------------------------------Mẫu insert Dữ Liệu-------------------------------------
---------------------------------------------------------------------------------------

---- Thêm dữ liệu vào bảng BENHNHAN -- MÃ BỆNH NHÂN KHÔNG THÊM ( TỰ TẠO )
--INSERT INTO BENHNHAN( HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai) VALUES
--( N'Nguyễn Văn Xe', '2002-05-11', N'Nam', N'123 Lê Lợi, Quận 1, TP.HCM', '0921203519')
---- Thêm dữ liệu vào bảng NHANVIEN -- MÃ NHÂN VIÊN KHÔNG THÊM ( TỰ TẠO )
--INSERT INTO NHANVIEN( HoTen, GioiTinh, ChucVu, DiaChi, SoDienThoai) VALUES
--(N'Nguyễn Thị Phương', N'Nữ', N'Bác sĩ', N'123 Lê Lợi, Quận 1, TP.HCM', '0956789012')
---- Thêm dữ liệu vào bảng NHACUNGCAP -- MÃ NHÀ CUNG CẤP KHÔNG THÊM ( TỰ TẠO )
--INSERT INTO NHACUNGCAP(TenNCC, DiaChi, SoDienThoai) VALUES
--( NN'Công ty Cổ phần Dược phẩm A', N'123 Lê Lợi, Quận 1, TP.HCM', '0978901234')
---- Thêm dữ liệu vào bảng LOAIVACINE -- MÃ LOẠI KHÔNG THÊM ( TỰ TẠO )
--INSERT INTO LOAIVACCINE(TenLoai) VALUES
--( N'Vacxin Sởi')
---- Thêm dữ liệu vào bảng VACCINE -- MÃ VACCINE KHÔNG THÊM ( TỰ TẠO ) VÀ SỐ LƯỢNG TỰ CẬP NHẬT TỪ CHITIETPHIEUNHAP
--INSERT INTO VACCINE(MaLoai, TenVC, NgaySX, HanSuDung, Gia) VALUES
--('LV001', N'Vacxin Sởi MMR II', '2022-01-01', '2024-01-01', 150000)
---- Thêm dữ liệu vào bảng PHIEUNHAP -- MÃ PHIẾU NHẬP KHÔNG THÊM ( TỰ TẠO )
--INSERT INTO PHIEUNHAP(NgayNhap, MaNCC) VALUES
--( '2022-04-01', 'NCC01')
---- Thêm dữ liệu vào bảng CHITIETPHIEUNHAP
--INSERT INTO CHITIETPHIEUNHAP(MaPN, MaVC, SoLuong, DonGia) VALUES
--('PN004', 'VC001', 10, 120000)
---- Thêm dữ liệu vào bảng HOADON -- MÃHD KHÔNG THÊM( TỰ TẠO ) VÀ KHÔNG THÊM TONGTIEN ( TỰ TÍNH TỰ CHITIETHOADON )
--INSERT INTO HOADON( NgayLap, MaBN, MaNV) VALUES
--('2022-04-05', 'BN002', 'NV001')
---- Thêm dữ liệu vào bảng CHITIETHOADON --đơn giá tự lấy từ gia vaccine
--INSERT INTO CHITIETHOADON(MaHD, MaVC, SOLUONG) VALUES
--('HD024', 'VC001', 49)
---- Thêm dữ liệu vào bảng GHINHANTIEMCHUNG
--INSERT INTO GHINHANTIEMCHUNG( MaBN, MaVC, MaNV, MaLT,MaHD, NgayTiem,TinhTrangSucKhoe) VALUES
--('BN002', 'VC001', 'NV001', 'LT011','HD012', '2022-04-12','Khoẻ mạnh')
---- Thêm dữ liệu vào bảng TAIKHOAN
--INSERT INTO TAIKHOAN(UserName, Pass, ChucVu) VALUES
--('admin', 'admin123', 1)

-----------------------------DATA------------------------------------

INSERT INTO BENHNHAN( HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai) VALUES
( N'Nguyễn Văn An', '2003-01-15', N'Nam', N'12 Nguyễn Trãi, Quận 1, TP.HCM', '0912345678'),
( N'Trần Thị Bình', '2002-08-22', N'Nữ', N'45 Lê Văn Sỹ, Quận 3, TP.HCM', '0987654321'),
( N'Lê Văn Cường', '2001-05-10', N'Nam', N'78 Pasteur, Quận 1, TP.HCM', '0901234567'),
( N'Phạm Thị Diệu', '2000-12-03', N'Nữ', N'101 CMT8, Quận 10, TP.HCM', '0987654320'),
( N'Hoàng Văn Em', '1999-09-18', N'Nam', N'123/45 Trần Hưng Đạo, Quận 5, TP.HCM', '0912345679'),
( N'Vũ Thị Hoa', '1998-06-25', N'Nữ', N'678/90 Nguyễn Đình Chiểu, Quận 3, TP.HCM', '0987654319'),
( N'Đặng Văn Hùng', '1997-03-12', N'Nam', N'1000/123 Cách Mạng Tháng 8, Quận 10, TP.HCM', '0901234568'),
( N'Bùi Thị Lan', '1996-11-05', N'Nữ', N'15/20 Lê Lai, Quận 1, TP.HCM', '0987654318'),
( N'Ngô Văn Minh', '1995-08-20', N'Nam', N'456/78 Nguyễn Thị Minh Khai, Quận 3, TP.HCM', '0912345680'),
( N'Trương Thị Nga', '1994-05-07', N'Nữ', N'789/1011 Dien Bien Phu, Quận Bình Thạnh, TP.HCM', '0987654317'),
( N'Lý Văn Phong', '1993-12-01', N'Nam', N'12/34 Nguyễn Văn Cừ, Quận 5, TP.HCM', '0901234569'),
( N'Phan Thị Quỳnh', '1992-09-16', N'Nữ', N'567/89 Nguyễn Hữu Cảnh, Quận Bình Thạnh, TP.HCM', '0987654316'),
( N'Võ Văn Sơn', '1991-06-23', N'Nam', N'1001/1234 Xa Lộ Hà Nội, Quận 2, TP.HCM', '0912345681'),
( N'Đỗ Thị Thảo', '1990-03-10', N'Nữ', N'15/20/30 Nguyễn Thị Thập, Quận 7, TP.HCM', '0987654315'),
( N'Trần Văn Trung', '1989-11-03', N'Nam', N'456/78/90 Phạm Văn Đồng, Quận Thủ Đức, TP.HCM', '0901234570'),
( N'Hồ Thị Vân', '1988-08-18', N'Nữ', N'789/101/123 Kha Vạn Cân, Quận Thủ Đức, TP.HCM', '0987654314'),
( N'Lâm Văn Xuân', '1987-05-05', N'Nam', N'12/34/56 Man Thiện, Quận 9, TP.HCM', '0912345682'),
( N'Huỳnh Thị Yến', '1986-12-21', N'Nữ', N'567/89/101 Lã Xuân Oai, Quận 9, TP.HCM', '0987654313'),
( N'Phùng Văn Dương', '1985-09-08', N'Nam', N'1001/123/456 Tô Ngọc Vân, Quận 12, TP.HCM', '0901234571'),
( N'Chu Thị Giang', '1984-06-15', N'Nữ', N'15/20/30/45 Quang Trung, Quận Gò Vấp, TP.HCM', '0987654312'),
( N'Vương Văn Hải', '1983-03-02', N'Nam', N'456/78/90/101 Nguyễn Oanh, Quận Gò Vấp, TP.HCM', '0912345683'),
( N'Lê Thị Kiều', '1982-10-27', N'Nữ', N'789/101/123/456 Phan Huy Ích, Quận Gò Vấp, TP.HCM', '0987654311'),
( N'Đinh Văn Long', '1981-07-14', N'Nam', N'12/34/56/78 Nguyễn Văn Lượng, Quận Gò Vấp, TP.HCM', '0901234572'),
( N'Mai Thị Mỹ', '1980-04-01', N'Nữ', N'567/89/101/123 Lê Đức Thọ, Quận Gò Vấp, TP.HCM', '0987654310');

INSERT INTO NHANVIEN( HoTen, GioiTinh, ChucVu, DiaChi, SoDienThoai) VALUES
(N'Trần Thị Thu', N'Nữ', N'Bác sĩ', N'15/20 Lê Lai, Quận 1, TP.HCM', '0987654322'),
(N'Nguyễn Văn Nam', N'Nam', N'Y tá', N'456/78 Nguyễn Thị Minh Khai, Quận 3, TP.HCM', '0912345684'),
(N'Phạm Thị Mai', N'Nữ', N'Dược sĩ', N'789/1011 Dien Bien Phu, Quận Bình Thạnh, TP.HCM', '0901234573'),
(N'Lê Văn Đức', N'Nam', N'Kỹ thuật viên', N'12/34 Nguyễn Văn Cừ, Quận 5, TP.HCM', '0987654323'),
(N'Vũ Thị Hà', N'Nữ', N'Bác sĩ', N'567/89 Nguyễn Hữu Cảnh, Quận Bình Thạnh, TP.HCM', '0912345685'),
(N'Đặng Văn Hào', N'Nam', N'Y tá', N'1001/1234 Xa Lộ Hà Nội, Quận 2, TP.HCM', '0901234574'),
(N'Bùi Thị Linh', N'Nữ', N'Điều dưỡng', N'15/20/30 Nguyễn Thị Thập, Quận 7, TP.HCM', '0987654324'),
(N'Ngô Văn Toàn', N'Nam', N'Bác sĩ', N'456/78/90 Phạm Văn Đồng, Quận Thủ Đức, TP.HCM', '0912345686'),
(N'Trương Thị Dung', N'Nữ', N'Y tá', N'789/101/123 Kha Vạn Cân, Quận Thủ Đức, TP.HCM', '0901234575'),
(N'Lý Văn Thành', N'Nam', N'Dược sĩ', N'12/34/56 Man Thiện, Quận 9, TP.HCM', '0987654325');

INSERT INTO NHACUNGCAP(TenNCC, DiaChi, SoDienThoai) VALUES
(N'Công ty Cổ phần Dược phẩm TW 20 ',N'Đường số 1, Q. Bình Tân, TP. HCM', '0283811111'),
(N'Công ty Cổ phần Traphaco', N'Khu công nghiệp Thạch Thất, huyện Thạch Thất, TP. Hà Nội', '0243365111'),
(N'Công ty Cổ phần Dược Hậu Giang', N'Trần Phú, Q. 5, TP. HCM', '0283924111'),
(N'Công ty Cổ phần Dược phẩm Imexpharm', N'Hoàng Quốc Việt, Q. Cầu Giấy, TP. Hà Nội', '0243759111'),
(N'Công ty Cổ phần Dược phẩm OPC', N'Nguyễn Văn Linh, Q. 7, TP. HCM', '0285411111'),
(N'Công ty Cổ phần Dược phẩm Hà Tây', N'Quang Trung, Q. Hà Đông, TP. Hà Nội', '0243351111'),
(N'Công ty TNHH Dược phẩm US Pharma USA', N'Đường số 2, Q. Bình Tân, TP. HCM', '0286264111'),
(N'Công ty Cổ phần Pymepharco', N'Đường 19/5, Q. Bình Thạnh, TP. HCM', '0283840111'),
(N'Công ty Cổ phần Dược phẩm Domesco', N'Cộng Hòa, Q. Tân Bình, TP. HCM', '0283842101'),
(N'Công ty Cổ phần SPM', N'Lê Hồng Phong, Q. 5, TP. HCM', '0283925111');

INSERT INTO LOAIVACCINE(TenLoai) VALUES
( N'Vacxin Viêm gan B'),
( N'Vacxin Bạch hầu'),
( N'Vacxin Uốn ván'),
( N'Vacxin Ho gà'),
( N'Vacxin Viêm não Nhật Bản'),
( N'Vacxin Rotavirus'),
( N'Vacxin Thủy đậu'),
( N'Vacxin Sởi - Quai bị - Rubella'),
( N'Vacxin Viêm phổi'),
( N'Vacxin Cúm');

-- Lưu ý cập nhật MaLoai tương ứng với bảng LOAIVACCINE
INSERT INTO VACCINE(MaLoai, TenVC, NgaySX, HanSuDung, Gia) VALUES
('LV001', N'Vacxin Sởi M-M-R II', '2022-02-01', '2025-02-01', 180000),
('LV002', N'Vacxin Viêm gan B – Engerix-B', '2022-03-15', '2024-03-15', 120000),
('LV003', N'Vacxin Bạch hầu – Vaxitec', '2022-04-01', '2025-04-01', 150000),
('LV004', N'Vacxin Uốn ván – Tetatus', '2022-05-10', '2024-05-10', 80000),
('LV005', N'Vacxin Ho gà – Infanrix hexa', '2022-06-22', '2025-06-22', 200000),
('LV001', N'Vacxin Sởi Priorix', '2022-07-15', '2024-07-15', 160000),
('LV002', N'Vacxin Viêm gan B – Hepavax-Gene', '2022-08-01', '2025-08-01', 130000),
('LV003', N'Vacxin Bạch hầu – DTwP', '2022-09-10', '2024-09-10', 100000),
('LV004', N'Vacxin Uốn ván – Adacel', '2022-10-22', '2025-10-22', 90000),
('LV005', N'Vacxin Ho gà – Boostrix', '2022-11-15', '2024-11-15', 180000),
('LV006', N'Vacxin Viêm não Nhật Bản – JE-VAX', '2022-12-01', '2025-12-01', 220000),
('LV007', N'Vacxin Rotavirus – Rotarix', '2023-01-10', '2024-01-10', 170000),
('LV008', N'Vacxin Thủy đậu – Varilrix', '2023-02-22', '2025-02-22', 190000),
('LV009', N'Vacxin Sởi - Quai bị - Rubella – MMR', '2023-03-15', '2024-03-15', 250000),
('LV010', N'Vacxin Viêm phổi – Prevenar 13', '2023-04-01', '2025-04-01', 280000),
('LV006', N'Vacxin Viêm não Nhật Bản – Ixiaro', '2023-05-10', '2024-05-10', 230000),
('LV007', N'Vacxin Rotavirus – Rotateq', '2023-06-22', '2025-06-22', 160000),
('LV008', N'Vacxin Thủy đậu – Varivax', '2023-07-15', '2024-07-15', 180000),
('LV009', N'Vacxin Sởi - Quai bị - Rubella – Priorix-Tetra', '2023-08-01', '2025-08-01', 260000),
('LV010', N'Vacxin Viêm phổi – Synflorix', '2023-09-10', '2024-09-10', 270000),
('LV006', N'Vacxin Viêm não Nhật Bản – Encepur', '2023-10-22', '2025-10-22', 240000),
('LV007', N'Vacxin Rotavirus – RotaTeq', '2023-11-15', '2024-11-15', 170000),
('LV008', N'Vacxin Thủy đậu – Varilrix', '2023-12-01', '2025-12-01', 190000),
('LV009', N'Vacxin Sởi - Quai bị - Rubella – ProQuad', '2024-01-10', '2025-01-10', 270000),
('LV010', N'Vacxin Viêm phổi – Vaxneumo', '2024-02-22', '2025-02-22', 290000);


-- Lưu ý cập nhật MaNCC tương ứng với bảng NHACUNGCAP
INSERT INTO PHIEUNHAP(NgayNhap, MaNCC) VALUES
('2022-04-02', 'NCC02'),
('2022-04-05', 'NCC03'),
('2022-04-08', 'NCC04'),
('2022-04-12', 'NCC05'),
('2022-04-15', 'NCC06'),
('2022-04-19', 'NCC07'),
('2022-04-22', 'NCC08'),
('2022-04-26', 'NCC09'),
('2022-04-29', 'NCC01'),
('2022-05-02', 'NCC02'),
('2022-05-05', 'NCC03'),
('2022-05-09', 'NCC04'),
('2022-05-12', 'NCC05'),
('2022-05-16', 'NCC06'),
('2022-05-19', 'NCC07'),
('2022-05-23', 'NCC08'),
('2022-05-26', 'NCC09'),
('2022-05-30', 'NCC01'),
('2022-06-02', 'NCC02'),
('2022-06-06', 'NCC03'),
('2022-06-09', 'NCC04'),
('2022-06-13', 'NCC05'),
('2022-06-16', 'NCC06'),
('2022-06-20', 'NCC07'),
('2022-06-23', 'NCC08');

-- Lưu ý cập nhật MaPN và MaVC tương ứng với bảng PHIEUNHAP và VACCINE
INSERT INTO CHITIETPHIEUNHAP(MaPN, MaVC, SoLuong, DonGia) VALUES
('PN001', 'VC001', 10, 150000),
('PN001', 'VC002', 5, 100000),
('PN002', 'VC002', 15, 100000),
('PN002', 'VC004', 7, 80000),
('PN003', 'VC003', 20, 120000),
('PN003', 'VC006', 3, 200000),
('PN004', 'VC004', 12, 80000),
('PN004', 'VC008', 10, 130000),
('PN005', 'VC005', 8, 180000),
('PN005', 'VC010', 5, 90000),
('PN006', 'VC006', 10, 200000),
('PN006', 'VC012', 8, 220000),
('PN007', 'VC007', 15, 160000),
('PN007', 'VC014', 6, 190000),
('PN008', 'VC008', 20, 130000),
('PN008', 'VC016', 4, 280000),
('PN009', 'VC009', 12, 100000),
('PN009', 'VC018', 9, 160000),
('PN010', 'VC010', 8, 90000),
('PN010', 'VC020', 6, 260000),
('PN011', 'VC011', 10, 180000),
('PN011', 'VC022', 7, 240000),
('PN012', 'VC012', 15, 220000),
('PN012', 'VC024', 5, 190000),
('PN013', 'VC013', 20, 170000),
('PN013', 'VC001', 12, 150000),
('PN014', 'VC014', 12, 190000),
('PN014', 'VC003', 10, 120000),
('PN015', 'VC015', 8, 250000),
('PN016', 'VC016', 10, 280000),
('PN017', 'VC017', 15, 230000),
('PN018', 'VC018', 20, 160000),
('PN019', 'VC019', 12, 180000),
('PN020', 'VC020', 8, 260000),
('PN021', 'VC021', 10, 270000),
('PN022', 'VC022', 15, 240000),
('PN023', 'VC023', 20, 170000),
('PN024', 'VC024', 12, 190000),
('PN025', 'VC025', 8, 270000);

-- Lưu ý cập nhật MaBN và MaNV tương ứng với bảng BENHNHAN và NHANVIEN
INSERT INTO HOADON( NgayLap, MaBN, MaNV) VALUES
('2022-04-05', 'BN001', 'NV001'),
('2022-04-06', 'BN002', 'NV002'),
('2022-04-07', 'BN003', 'NV003'),
('2022-04-08', 'BN004', 'NV004'),
('2022-04-09', 'BN005', 'NV005'),
('2022-04-12', 'BN006', 'NV006'),
('2022-04-13', 'BN007', 'NV007'),
('2022-04-14', 'BN008', 'NV008'),
('2022-04-15', 'BN009', 'NV009'),
('2022-04-16', 'BN010', 'NV010'),
('2022-04-19', 'BN011', 'NV001'),
('2022-04-20', 'BN012', 'NV002'),
('2022-04-21', 'BN013', 'NV003'),
('2022-04-22', 'BN014', 'NV004'),
('2022-04-23', 'BN015', 'NV005'),
('2022-04-26', 'BN016', 'NV006'),
('2022-04-27', 'BN017', 'NV007'),
('2022-04-28', 'BN018', 'NV008'),
('2022-04-29', 'BN019', 'NV009'),
('2022-04-30', 'BN020', 'NV010');

-- Lưu ý cập nhật MaHD và MaVC tương ứng với bảng HOADON và VACCINE
INSERT INTO CHITIETHOADON(MaHD, MaVC, SOLUONG) VALUES
('HD001', 'VC001', 2),
('HD002', 'VC003', 1),
('HD003', 'VC005', 3),
('HD004', 'VC007', 2),
('HD005', 'VC009', 1),
('HD006', 'VC011', 2),
('HD007', 'VC013', 3),
('HD008', 'VC015', 1),
('HD009', 'VC017', 2),
('HD010', 'VC019', 1),
('HD011', 'VC021', 2),
('HD012', 'VC023', 3),
('HD013', 'VC002', 1),
('HD014', 'VC004', 2),
('HD015', 'VC006', 1),
('HD016', 'VC008', 3),
('HD017', 'VC010', 2),
('HD018', 'VC012', 1),
('HD019', 'VC014', 3),
('HD020', 'VC016', 2),
('HD001', 'VC003', 1),
('HD002', 'VC005', 2),
('HD003', 'VC007', 1),
('HD004', 'VC009', 2),
('HD005', 'VC011', 1),
('HD006', 'VC013', 2),
('HD007', 'VC015', 3),
('HD008', 'VC017', 1),
('HD009', 'VC019', 2),
('HD010', 'VC021', 1),
('HD011', 'VC023', 2),
('HD012', 'VC001', 3),
('HD013', 'VC003', 2),
('HD014', 'VC005', 1),
('HD015', 'VC007', 2),
('HD016', 'VC009', 3),
('HD017', 'VC011', 1),
('HD018', 'VC013', 2),
('HD019', 'VC015', 3),
('HD020', 'VC017', 1);

INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN020', 'VC017', 'NV001', 'LT001', 'HD020', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN019', 'VC015', 'NV002', 'LT002', 'HD019', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN018', 'VC013', 'NV003', 'LT003', 'HD018', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN017', 'VC011', 'NV004', 'LT004', 'HD017', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN016', 'VC009', 'NV005', 'LT005', 'HD016', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN015', 'VC007', 'NV006', 'LT006', 'HD015', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN014', 'VC005', 'NV007', 'LT007', 'HD014', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN013', 'VC003', 'NV008', 'LT008', 'HD013', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN012', 'VC001', 'NV009', 'LT009', 'HD012', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN011', 'VC023', 'NV010', 'LT010', 'HD011', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN010', 'VC021', 'NV001', 'LT011', 'HD010', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN009', 'VC019', 'NV002', 'LT012', 'HD009', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN008', 'VC017', 'NV003', 'LT013', 'HD008', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN007', 'VC015', 'NV004', 'LT014', 'HD007', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN006', 'VC013', 'NV005', 'LT015', 'HD006', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN005', 'VC011', 'NV006', 'LT016', 'HD005', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN004', 'VC009', 'NV007', 'LT017', 'HD004', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN003', 'VC007', 'NV008', 'LT018', 'HD003', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN002', 'VC005', 'NV009', 'LT019', 'HD002', NULL, N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN001', 'VC003', 'NV010', 'LT020', 'HD001', NULL, N'Khỏe mạnh');

INSERT INTO TAIKHOAN(UserName, Pass, ChucVu) VALUES
('admin', 'admin123', 1),
('user1', '123', 2);



--select * from BENHNHAN
--select * from NHANVIEN
--select * from NHACUNGCAP
--select * from LOAIVACCINE
--select * from VACCINE
--select * from PHIEUNHAP
--select * from CHITIETPHIEUNHAP
--select * from HOADON
--select * from CHITIETHOADON
--select * from LICHTIEM
--select * from GHINHANTIEMCHUNG
--select * from TAIKHOAN