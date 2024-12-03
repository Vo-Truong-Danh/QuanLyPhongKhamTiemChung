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
--( '2022-04-01', 'NCC001')
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

USE QUANLYPHONGKHAM_TIEMCHUNG;
GO

INSERT INTO BENHNHAN(MaBN, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai) VALUES 
('BN001', N'Nguyễn Văn An', '2003-01-15', N'Nam', N'12 Nguyễn Trãi, Quận 1, TP.HCM', '0912345678'),
('BN002', N'Trần Thị Bình', '2002-08-22', N'Nữ', N'45 Lê Văn Sỹ, Quận 3, TP.HCM', '0987654321'),
('BN003', N'Lê Văn Cường', '2001-05-10', N'Nam', N'78 Pasteur, Quận 1, TP.HCM', '0901234567'),
('BN004', N'Phạm Thị Diệu', '2000-12-03', N'Nữ', N'101 CMT8, Quận 10, TP.HCM', '0987654320'),
('BN005', N'Hoàng Văn Em', '1999-09-18', N'Nam', N'123/45 Trần Hưng Đạo, Quận 5, TP.HCM', '0912345679'),
('BN006', N'Vũ Thị Hoa', '1998-06-25', N'Nữ', N'678/90 Nguyễn Đình Chiểu, Quận 3, TP.HCM', '0987654319'),
('BN007', N'Đặng Văn Hùng', '1997-03-12', N'Nam', N'1000/123 Cách Mạng Tháng 8, Quận 10, TP.HCM', '0901234568'),
('BN008', N'Bùi Thị Lan', '1996-11-05', N'Nữ', N'15/20 Lê Lai, Quận 1, TP.HCM', '0987654318'),
('BN009', N'Ngô Văn Minh', '1995-08-20', N'Nam', N'456/78 Nguyễn Thị Minh Khai, Quận 3, TP.HCM', '0912345680'),
('BN010', N'Trương Thị Nga', '1994-05-07', N'Nữ', N'789/1011 Điện Biên Phủ, Quận Bình Thạnh, TP.HCM', '0987654317'),
('BN011', N'Lý Văn Phong', '1993-12-01', N'Nam', N'12/34 Nguyễn Văn Cừ, Quận 5, TP.HCM', '0901234569'),
('BN012', N'Phan Thị Quỳnh', '1992-09-16', N'Nữ', N'567/89 Nguyễn Hữu Cảnh, Quận Bình Thạnh, TP.HCM', '0987654316'),
('BN013', N'Võ Văn Sơn', '1991-06-23', N'Nam', N'1001/1234 Xa Lộ Hà Nội, Quận 2, TP.HCM', '0912345681'),
('BN014', N'Đỗ Thị Thảo', '1990-03-10', N'Nữ', N'15/20/30 Nguyễn Thị Thập, Quận 7, TP.HCM', '0987654315'),
('BN015', N'Trần Văn Trung', '1989-11-03', N'Nam', N'456/78/90 Phạm Văn Đồng, Quận Thủ Đức, TP.HCM', '0901234570'),
('BN016', N'Hồ Thị Vân', '1988-08-18', N'Nữ', N'789/101/123 Kha Vạn Cân, Quận Thủ Đức, TP.HCM', '0987654314'),
('BN017', N'Lâm Văn Xuân', '1987-05-05', N'Nam', N'12/34/56 Man Thiện, Quận 9, TP.HCM', '0912345682'),
('BN018', N'Huỳnh Thị Yến', '1986-12-21', N'Nữ', N'567/89/101 Lã Xuân Oai, Quận 9, TP.HCM', '0987654313'),
('BN019', N'Phùng Văn Dương', '1985-09-08', N'Nam', N'1001/123/456 Tô Ngọc Vân, Quận 12, TP.HCM', '0901234571'),
('BN020', N'Chu Thị Giang', '1984-06-15', N'Nữ', N'15/20/30/45 Quang Trung, Quận Gò Vấp, TP.HCM', '0987654312'),
('BN021', N'Vương Văn Hải', '1983-03-02', N'Nam', N'456/78/90/101 Nguyễn Oanh, Quận Gò Vấp, TP.HCM', '0912345683'),
('BN022', N'Lê Thị Kiều', '1982-10-27', N'Nữ', N'789/101/123/456 Phan Huy Ích, Quận Gò Vấp, TP.HCM', '0987654311'),
('BN023', N'Đinh Văn Long', '1981-07-14', N'Nam', N'12/34/56/78 Nguyễn Văn Lượng, Quận Gò Vấp, TP.HCM', '0901234572'),
('BN024', N'Mai Thị Mỹ', '1980-04-01', N'Nữ', N'567/89/101/123 Lê Đức Thọ, Quận Gò Vấp, TP.HCM', '0987654310');

INSERT INTO NHANVIEN(MaNV, HoTen,Pass, Quyen) VALUES 
('admin',N'Lê Bá Chiến','1',0);
INSERT INTO NHANVIEN(MaNV, HoTen, GioiTinh, ChucVu, DiaChi, SoDienThoai, Pass, Quyen) VALUES 
('NV001', N'Trần Thị Thu', N'Nữ', N'Bác sĩ', N'15/20 Lê Lai, Quận 1, TP.HCM', '0987654322', 'pass001', 1),
('NV002', N'Nguyễn Văn Nam', N'Nam', N'Y tá', N'456/78 Nguyễn Thị Minh Khai, Quận 3, TP.HCM', '0912345684', 'pass002', 0),
('NV003', N'Phạm Thị Mai', N'Nữ', N'Dược sĩ', N'789/1011 Dien Bien Phu, Quận Bình Thạnh, TP.HCM', '0901234573', 'pass003', 1),
('NV004', N'Lê Văn Đức', N'Nam', N'Kỹ thuật viên', N'12/34 Nguyễn Văn Cừ, Quận 5, TP.HCM', '0987654323', 'pass004', 0),
('NV005', N'Vũ Thị Hà', N'Nữ', N'Bác sĩ', N'567/89 Nguyễn Hữu Cảnh, Quận Bình Thạnh, TP.HCM', '0912345685', 'pass005', 1),
('NV006', N'Đặng Văn Hào', N'Nam', N'Y tá', N'1001/1234 Xa Lộ Hà Nội, Quận 2, TP.HCM', '0901234574', 'pass006', 0),
('NV007', N'Bùi Thị Linh', N'Nữ', N'Điều dưỡng', N'15/20/30 Nguyễn Thị Thập, Quận 7, TP.HCM', '0987654324', 'pass007', 1),
('NV008', N'Ngô Văn Toàn', N'Nam', N'Bác sĩ', N'456/78/90 Phạm Văn Đồng, Quận Thủ Đức, TP.HCM', '0912345686', 'pass008', 0),
('NV009', N'Trương Thị Dung', N'Nữ', N'Y tá', N'789/101/123 Kha Vạn Cân, Quận Thủ Đức, TP.HCM', '0901234575', 'pass009', 1),
('NV010', N'Lý Văn Thành', N'Nam', N'Dược sĩ', N'12/34/56 Man Thiện, Quận 9, TP.HCM', '0987654325', 'pass010', 0);


INSERT INTO NHACUNGCAP(MaNCC, TenNCC, DiaChi, SoDienThoai) VALUES 
('NCC001', N'Công ty Cổ phần Dược phẩm TW 20', N'Đường số 1, Q. Bình Tân, TP. HCM', '0283811111'),
('NCC002', N'Công ty Cổ phần Traphaco', N'Khu công nghiệp Thạch Thất, huyện Thạch Thất, TP. Hà Nội', '0243365111'),
('NCC003', N'Công ty Cổ phần Dược Hậu Giang', N'Trần Phú, Q. 5, TP. HCM', '0283924111'),
('NCC004', N'Công ty Cổ phần Dược phẩm Imexpharm', N'Hoàng Quốc Việt, Q. Cầu Giấy, TP. Hà Nội', '0243759111'),
('NCC005', N'Công ty Cổ phần Dược phẩm OPC', N'Nguyễn Văn Linh, Q. 7, TP. HCM', '0285411111'),
('NCC006', N'Công ty Cổ phần Dược phẩm Hà Tây', N'Quang Trung, Q. Hà Đông, TP. Hà Nội', '0243351111'),
('NCC007', N'Công ty TNHH Dược phẩm US Pharma USA', N'Đường số 2, Q. Bình Tân, TP. HCM', '0286264111'),
('NCC008', N'Công ty Cổ phần Pymepharco', N'Đường 19/5, Q. Bình Thạnh, TP. HCM', '0283840111'),
('NCC009', N'Công ty Cổ phần Dược phẩm Domesco', N'Cộng Hòa, Q. Tân Bình, TP. HCM', '0283842101'),
('NCC010', N'Công ty Cổ phần SPM', N'Lê Hồng Phong, Q. 5, TP. HCM', '0283925111');
-- Chèn dữ liệu vào bảng LOAIVACCINE
INSERT INTO LOAIVACCINE(MaLoai, TenLoai, SoMui) VALUES
('LV001', N'Vacxin Viêm gan B', 3), 
('LV002', N'Vacxin Bạch hầu-Ho gà-Uốn ván', 5),    
('LV003', N'Vacxin Sởi-Quai bị-Rubella', 2),   
('LV004', N'Vacxin Viêm não Nhật Bản', 3),       
('LV005', N'Vacxin Rotavirus', 2), 
('LV006', N'Vacxin Thủy đậu', 2),   
('LV007', N'Vacxin Viêm phổi', 4),    
('LV008', N'Vacxin Cúm', 1),
('LV009', N'Vacxin HPV', 3), 
('LV010', N'Vacxin Phòng dại', 5);    

-- Chèn dữ liệu vào bảng VACCINE
INSERT INTO VACCINE(MaVC, MaLoai, TenVC, NgaySX, HanSuDung, Gia, XuatXu) VALUES
('VC001', 'LV001', N'Engerix-B', '2022-02-01', '2025-02-01', 180000, N'Bỉ'),
('VC002', 'LV001', N'Hepavax-Gene', '2022-03-15', '2024-03-15', 120000, N'Hàn Quốc'),
('VC003', 'LV002', N'Infanrix-IPV', '2022-04-01', '2025-04-01', 150000, N'Mỹ'),
('VC004', 'LV002', N'Pentaxim', '2022-05-10', '2024-05-10', 80000, N'Pháp'),
('VC005', 'LV002', N'Adacel', '2022-06-22', '2025-06-22', 200000, N'Mỹ'),
('VC006', 'LV003', N'M-M-R II', '2022-07-15', '2024-07-15', 160000, N'Mỹ'),
('VC007', 'LV003', N'Priorix', '2022-08-01', '2025-08-01', 130000, N'Bỉ'),
('VC008', 'LV004', N'JE-VAX', '2022-09-10', '2024-09-10', 100000, N'Nhật Bản'),
('VC009', 'LV004', N'Ixiaro', '2022-10-22', '2025-10-22', 90000, N'Áo'),
('VC010', 'LV004', N'Encepur', '2022-11-15', '2024-11-15', 180000, N'Đức'),
('VC011', 'LV005', N'Rotarix', '2022-12-01', '2025-12-01', 220000, N'Bỉ'),
('VC012', 'LV005', N'RotaTeq', '2023-01-10', '2024-01-10', 170000, N'Mỹ'),
('VC013', 'LV006', N'Varilrix', '2023-02-22', '2025-02-22', 190000, N'Bỉ'),
('VC014', 'LV006', N'Varivax', '2023-03-15', '2024-03-15', 250000, N'Mỹ'),
('VC015', 'LV007', N'Prevenar 13', '2023-04-01', '2025-04-01', 280000, N'Mỹ'),
('VC016', 'LV007', N'Synflorix', '2023-05-10', '2024-05-10', 230000, N'Bỉ'),
('VC017', 'LV008', N'Influvac', '2023-06-22', '2025-06-22', 160000, N'Hà Lan'),
('VC018', 'LV008', N'Vaxigrip', '2023-07-15', '2024-07-15', 180000, N'Pháp'),
('VC019', 'LV009', N'Gardasil', '2023-08-01', '2025-08-01', 260000, N'Mỹ'),
('VC020', 'LV009', N'Cervarix', '2023-09-10', '2024-09-10', 270000, N'Bỉ'),
('VC021', 'LV010', N'Verorab', '2023-10-22', '2025-10-22', 240000, N'Pháp'),
('VC022', 'LV010', N'Rabipur', '2023-11-15', '2024-11-15', 170000, N'Đức'),
('VC023', 'LV001', N'Euvax-B', '2023-12-01', '2025-12-01', 190000, N'Hàn Quốc'),
('VC024', 'LV002', N'Boostrix', '2024-01-10', '2025-01-10', 270000, N'Bỉ'),
('VC025', 'LV007', N'Pneumovax 23', '2024-02-22', '2025-02-22', 290000, N'Mỹ');

-- Thêm dữ liệu mới vào bảng LOAIVACCINE
INSERT INTO LOAIVACCINE(MaLoai, TenLoai, SoMui) VALUES
('LV011', N'Vacxin Viêm gan A', 2),
('LV012', N'Vacxin Phế cầu', 4),
('LV013', N'Vacxin Thương hàn', 1),
('LV014', N'Vacxin Viêm màng não', 2),
('LV015', N'Vacxin Covid-19', 2);

-- Thêm dữ liệu mới vào bảng VACCINE
INSERT INTO VACCINE(MaVC, MaLoai, TenVC, NgaySX, HanSuDung, Gia, XuatXu) VALUES
-- Thêm vaccine Viêm gan B mới
('VC026', 'LV001', N'Heberbiovac-HB', '2024-01-15', '2026-01-15', 165000, N'Cuba'),
('VC027', 'LV001', N'Shanvac-B', '2024-02-01', '2026-02-01', 155000, N'Ấn Độ'),
('VC028', 'LV001', N'Bio-Hep-B', '2024-02-15', '2026-02-15', 175000, N'Hàn Quốc'),

-- Thêm vaccine DPT (Bạch hầu-Ho gà-Uốn ván) mới
('VC029', 'LV002', N'Tripacel', '2024-01-20', '2026-01-20', 320000, N'Canada'),
('VC030', 'LV002', N'Daptacel', '2024-02-10', '2026-02-10', 310000, N'Mỹ'),
('VC031', 'LV002', N'Infanrix Hexa', '2024-02-25', '2026-02-25', 450000, N'Bỉ'),

-- Thêm vaccine MMR (Sởi-Quai bị-Rubella) mới
('VC032', 'LV003', N'Trimovax', '2024-01-25', '2026-01-25', 280000, N'Pháp'),
('VC033', 'LV003', N'MeaslesRub', '2024-02-05', '2026-02-05', 260000, N'Ấn Độ'),
('VC034', 'LV003', N'MMR-II Japan', '2024-02-20', '2026-02-20', 290000, N'Nhật Bản'),

-- Thêm vaccine Viêm não Nhật Bản mới
('VC035', 'LV004', N'Biken JE', '2024-01-10', '2026-01-10', 420000, N'Nhật Bản'),
('VC036', 'LV004', N'IMOJEV', '2024-02-08', '2026-02-08', 400000, N'Thái Lan'),
('VC037', 'LV004', N'CD.JEVAX', '2024-02-28', '2026-02-28', 380000, N'Trung Quốc'),

-- Thêm vaccine Rotavirus mới
('VC038', 'LV005', N'Rotasiil', '2024-01-12', '2026-01-12', 350000, N'Ấn Độ'),
('VC039', 'LV005', N'Rotavac', '2024-02-15', '2026-02-15', 340000, N'Ấn Độ'),

-- Thêm vaccine Thủy đậu mới
('VC040', 'LV006', N'Okavax', '2024-01-18', '2026-01-18', 420000, N'Nhật Bản'),
('VC041', 'LV006', N'Vari-L', '2024-02-22', '2026-02-22', 400000, N'Hàn Quốc'),

-- Thêm vaccine Viêm phổi mới
('VC042', 'LV007', N'Pneumococcal PS', '2024-01-14', '2026-01-14', 520000, N'Hàn Quốc'),
('VC043', 'LV007', N'PCV13', '2024-02-18', '2026-02-18', 550000, N'Mỹ'),

-- Thêm vaccine Cúm mới
('VC044', 'LV008', N'FluQuadri', '2024-01-16', '2025-01-16', 320000, N'Pháp'),
('VC045', 'LV008', N'Fluarix Tetra', '2024-02-20', '2025-02-20', 340000, N'Bỉ'),
('VC046', 'LV008', N'Inflexal V', '2024-03-01', '2025-03-01', 330000, N'Thụy Sĩ'),

-- Thêm vaccine HPV mới
('VC047', 'LV009', N'Gardasil 9', '2024-01-22', '2026-01-22', 850000, N'Mỹ'),
('VC048', 'LV009', N'Cecolin', '2024-02-25', '2026-02-25', 750000, N'Trung Quốc'),

-- Thêm vaccine Phòng dại mới
('VC049', 'LV010', N'Abhayrab', '2024-01-24', '2026-01-24', 280000, N'Ấn Độ'),
('VC050', 'LV010', N'Speeda', '2024-02-28', '2026-02-28', 300000, N'Thái Lan'),

-- Thêm vaccine Viêm gan A mới
('VC051', 'LV011', N'Havrix', '2024-01-05', '2026-01-05', 450000, N'Bỉ'),
('VC052', 'LV011', N'Avaxim', '2024-02-08', '2026-02-08', 420000, N'Pháp'),
('VC053', 'LV011', N'Epaxal', '2024-02-28', '2026-02-28', 440000, N'Thụy Sĩ'),

-- Thêm vaccine Phế cầu mới
('VC054', 'LV012', N'Pneumoforce', '2024-01-10', '2026-01-10', 380000, N'Ấn Độ'),
('VC055', 'LV012', N'Prevnar20', '2024-02-12', '2026-02-12', 620000, N'Mỹ'),
('VC056', 'LV012', N'Pneumosil', '2024-02-25', '2026-02-25', 400000, N'Ấn Độ'),

-- Thêm vaccine Thương hàn mới
('VC057', 'LV013', N'Typhim Vi', '2024-01-15', '2026-01-15', 320000, N'Pháp'),
('VC058', 'LV013', N'Typbar', '2024-02-18', '2026-02-18', 300000, N'Ấn Độ'),
('VC059', 'LV013', N'Typherix', '2024-02-28', '2026-02-28', 310000, N'Bỉ'),

-- Thêm vaccine Viêm màng não mới
('VC060', 'LV014', N'Menactra', '2024-01-20', '2026-01-20', 850000, N'Mỹ'),
('VC061', 'LV014', N'Nimenrix', '2024-02-22', '2026-02-22', 820000, N'Bỉ'),
('VC062', 'LV014', N'MenQuadfi', '2024-03-01', '2026-03-01', 840000, N'Pháp'),

-- Thêm vaccine Covid-19
('VC063', 'LV015', N'Pfizer-BioNTech', '2024-01-25', '2025-01-25', 520000, N'Mỹ/Đức'),
('VC064', 'LV015', N'Moderna', '2024-02-25', '2025-02-25', 540000, N'Mỹ'),
('VC065', 'LV015', N'AstraZeneca', '2024-03-05', '2025-03-05', 480000, N'Anh/Thụy Điển');

INSERT INTO VACCINE(MaVC, MaLoai, TenVC, NgaySX, HanSuDung, Gia, XuatXu) VALUES
-- Thêm vaccine Viêm gan B (LV001)
('VC066', 'LV001', N'GenHevac B', '2024-01-05', '2026-01-05', 185000, N'Pháp'),
('VC067', 'LV001', N'Regevac B', '2024-01-15', '2026-01-15', 175000, N'Cuba'),
('VC068', 'LV001', N'Hepavax-Gene Pro', '2024-02-01', '2026-02-01', 195000, N'Hàn Quốc'),
('VC069', 'LV001', N'Euvax B Pediatric', '2024-02-15', '2026-02-15', 180000, N'Hàn Quốc'),
('VC070', 'LV001', N'Bio-Hep-B Plus', '2024-03-01', '2026-03-01', 190000, N'Ấn Độ'),
('VC071', 'LV002', N'Pentacel', '2024-01-10', '2026-01-10', 460000, N'Canada'),
('VC072', 'LV002', N'Quadracel', '2024-01-20', '2026-01-20', 440000, N'Mỹ'),
('VC073', 'LV002', N'Hexaxim', '2024-02-05', '2026-02-05', 480000, N'Pháp'),
('VC074', 'LV002', N'Hexyon', '2024-02-20', '2026-02-20', 470000, N'Pháp'),
('VC075', 'LV002', N'Vaxelis', '2024-03-05', '2026-03-05', 490000, N'Mỹ'),
('VC076', 'LV003', N'MMR-RIT', '2024-01-08', '2026-01-08', 270000, N'Bỉ'),
('VC077', 'LV003', N'Priorix Tetra', '2024-01-18', '2026-01-18', 290000, N'Bỉ'),
('VC078', 'LV003', N'ProQuad', '2024-02-03', '2026-02-03', 285000, N'Mỹ'),
('VC079', 'LV003', N'Trimovax Merieux', '2024-02-18', '2026-02-18', 275000, N'Pháp'),
('VC080', 'LV003', N'MeaslesMumps', '2024-03-03', '2026-03-03', 265000, N'Ấn Độ'),
('VC081', 'LV004', N'JEBIK V', '2024-01-12', '2026-01-12', 410000, N'Nhật Bản'),
('VC082', 'LV004', N'Japanese E', '2024-01-22', '2026-01-22', 390000, N'Hàn Quốc'),
('VC083', 'LV004', N'JE-ADVAX', '2024-02-07', '2026-02-07', 430000, N'Australia'),
('VC084', 'LV004', N'JEVAC', '2024-02-22', '2026-02-22', 400000, N'Việt Nam'),
('VC085', 'LV004', N'JEEV', '2024-03-07', '2026-03-07', 420000, N'Ấn Độ'),
('VC086', 'LV005', N'Rotavac 5D', '2024-01-14', '2026-01-14', 360000, N'Ấn Độ'),
('VC087', 'LV005', N'Rotavin-M1', '2024-01-24', '2026-01-24', 340000, N'Việt Nam'),
('VC088', 'LV005', N'RotaShield', '2024-02-09', '2026-02-09', 370000, N'Mỹ'),
('VC089', 'LV005', N'Rotarix Oral', '2024-02-24', '2026-02-24', 350000, N'Bỉ'),
('VC090', 'LV005', N'RotaTeq Oral', '2024-03-09', '2026-03-09', 365000, N'Mỹ'),
('VC091', 'LV006', N'Varicella-K', '2024-01-16', '2026-01-16', 410000, N'Hàn Quốc'),
('VC092', 'LV006', N'V-ZOS', '2024-01-26', '2026-01-26', 430000, N'Nhật Bản'),
('VC093', 'LV006', N'VarZos', '2024-02-11', '2026-02-11', 420000, N'Ấn Độ'),
('VC094', 'LV006', N'Variped', '2024-02-26', '2026-02-26', 440000, N'Pháp'),
('VC095', 'LV006', N'Varcivax', '2024-03-11', '2026-03-11', 425000, N'Bỉ'),
('VC096', 'LV007', N'Pneumo 23', '2024-01-18', '2026-01-18', 540000, N'Pháp'),
('VC097', 'LV007', N'PneumoMax', '2024-01-28', '2026-01-28', 530000, N'Ấn Độ'),
('VC098', 'LV007', N'Prevenar 15', '2024-02-13', '2026-02-13', 560000, N'Mỹ'),
('VC099', 'LV007', N'Pneumovax Plus', '2024-02-28', '2026-02-28', 550000, N'Mỹ'),
('VC100', 'LV007', N'PneumoSafe', '2024-03-13', '2026-03-13', 545000, N'Hàn Quốc'),
('VC101', 'LV008', N'FluMist', '2024-01-20', '2025-01-20', 350000, N'Mỹ'),
('VC102', 'LV008', N'Flucelvax', '2024-02-01', '2025-02-01', 345000, N'Thụy Sĩ'),
('VC103', 'LV008', N'Afluria', '2024-02-15', '2025-02-15', 335000, N'Australia'),
('VC104', 'LV008', N'FluLaval', '2024-03-01', '2025-03-01', 340000, N'Canada'),
('VC105', 'LV008', N'Fluzone HD', '2024-03-15', '2025-03-15', 360000, N'Mỹ'),
('VC106', 'LV009', N'HPV-16', '2024-01-22', '2026-01-22', 800000, N'Trung Quốc'),
('VC107', 'LV009', N'Gardasil Plus', '2024-02-05', '2026-02-05', 880000, N'Mỹ'),
('VC108', 'LV009', N'Cervarix Pro', '2024-02-20', '2026-02-20', 820000, N'Bỉ'),
('VC109', 'LV009', N'HPV-Prevent', '2024-03-05', '2026-03-05', 840000, N'Ấn Độ'),
('VC110', 'LV009', N'VacciHPV', '2024-03-20', '2026-03-20', 860000, N'Hàn Quốc'),
('VC111', 'LV010', N'RabAvert', '2024-01-24', '2026-01-24', 290000, N'Đức'),
('VC112', 'LV010', N'RabiShield', '2024-02-07', '2026-02-07', 285000, N'Ấn Độ'),
('VC113', 'LV010', N'RabiGen', '2024-02-22', '2026-02-22', 295000, N'Thụy Sĩ'),
('VC114', 'LV010', N'RabiVax', '2024-03-07', '2026-03-07', 280000, N'Việt Nam'),
('VC115', 'LV010', N'RabiPur Plus', '2024-03-22', '2026-03-22', 310000, N'Đức'),
('VC116', 'LV011', N'Healive', '2024-01-26', '2026-01-26', 430000, N'Trung Quốc'),
('VC117', 'LV011', N'Avaxim Pediatric', '2024-02-09', '2026-02-09', 445000, N'Pháp'),
('VC118', 'LV011', N'Havrix Junior', '2024-02-24', '2026-02-24', 460000, N'Bỉ'),
('VC119', 'LV011', N'Vaqta', '2024-03-09', '2026-03-09', 450000, N'Mỹ'),
('VC120', 'LV011', N'HepA-Vax', '2024-03-24', '2026-03-24', 440000, N'Hàn Quốc');

-- Lưu ý cập nhật MaNCC tương ứng với bảng NHACUNGCAP
INSERT INTO PHIEUNHAP(MaPN,MaNV,NgayNhap, MaNCC) VALUES
('PN001','NV001' ,'2022-04-02', 'NCC002'),
('PN002','NV003', '2022-04-05', 'NCC003'),
('PN003','NV005', '2022-04-08', 'NCC004'),
('PN004','NV001', '2022-04-12', 'NCC005'),
('PN005','NV001', '2022-04-15', 'NCC006'),
('PN006','NV007', '2022-04-19', 'NCC007'),
('PN007','NV001', '2022-04-22', 'NCC008'),
('PN008','NV003', '2022-04-26', 'NCC009'),
('PN009','NV003', '2022-04-29', 'NCC001'),
('PN010','NV005', '2022-05-02', 'NCC002'),
('PN011','NV007', '2022-05-05', 'NCC003'),
('PN012','NV009', '2022-05-09', 'NCC004'),
('PN013','NV002', '2022-05-12', 'NCC005'),
('PN014','NV005', '2022-05-16', 'NCC006'),
('PN015','NV002', '2022-05-19', 'NCC007'),
('PN016','NV001', '2022-05-23', 'NCC008'),
('PN017','NV001', '2022-05-26', 'NCC009'),
('PN018','NV004', '2022-05-30', 'NCC001'),
('PN019','NV006', '2022-06-02', 'NCC002'),
('PN020','NV002', '2022-06-06', 'NCC003'),
('PN021','NV008', '2022-06-09', 'NCC004'),
('PN022','NV008', '2022-06-13', 'NCC005'),
('PN023','NV001', '2022-06-16', 'NCC006'),
('PN024','NV009', '2022-06-20', 'NCC007'),
('PN025','NV001', '2022-06-23', 'NCC008');


INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN001', 'VC001', 10, 150000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN001', 'VC002', 5, 100000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN002', 'VC002', 15, 100000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN002', 'VC004', 7, 80000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN003', 'VC003', 20, 120000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN003', 'VC006', 3, 200000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN004', 'VC004', 12, 80000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN004', 'VC008', 10, 130000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN005', 'VC005', 8, 180000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN005', 'VC010', 5, 90000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN006', 'VC006', 10, 200000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN006', 'VC012', 8, 220000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN007', 'VC007', 15, 160000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN007', 'VC014', 6, 190000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN008', 'VC008', 20, 130000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN008', 'VC016', 4, 280000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN009', 'VC009', 12, 100000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN009', 'VC018', 9, 160000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN010', 'VC010', 8, 90000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN010', 'VC020', 6, 260000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN011', 'VC011', 10, 180000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN011', 'VC022', 7, 240000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN012', 'VC012', 15, 220000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN012', 'VC024', 5, 190000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN013', 'VC013', 20, 170000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN013', 'VC001', 12, 150000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN014', 'VC014', 12, 190000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN014', 'VC003', 10, 120000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN015', 'VC015', 8, 250000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN016', 'VC016', 10, 280000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN017', 'VC017', 15, 230000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN018', 'VC018', 20, 160000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN019', 'VC019', 12, 180000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN020', 'VC020', 8, 260000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN021', 'VC021', 10, 270000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN022', 'VC022', 15, 240000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN023', 'VC023', 20, 170000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN024', 'VC024', 12, 190000);
INSERT INTO CHITIETPHIEUNHAP (MaPN, MaVC, SoLuong, DonGia) VALUES ('PN025', 'VC025', 8, 270000);

INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD001', '2022-01-05', 'BN001', 'NV001');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD002', '2022-06-06', 'BN002', 'NV002');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD003', '2022-04-07', 'BN003', 'NV003');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD004', '2022-09-08', 'BN004', 'NV004');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD005', '2022-02-09', 'BN005', 'NV005');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD006', '2022-05-12', 'BN006', 'NV006');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD007', '2022-09-13', 'BN007', 'NV007');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD008', '2022-10-14', 'BN008', 'NV008');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD009', '2022-02-15', 'BN009', 'NV009');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD010', '2022-03-16', 'BN010', 'NV010');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD011', '2022-04-19', 'BN011', 'NV001');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD012', '2022-11-20', 'BN012', 'NV002');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD013', '2022-02-21', 'BN013', 'NV003');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD014', '2022-06-22', 'BN014', 'NV004');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD015', '2022-04-23', 'BN015', 'NV005');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD016', '2022-03-26', 'BN016', 'NV006');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD017', '2022-08-27', 'BN017', 'NV007');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD018', '2022-10-28', 'BN018', 'NV008');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD019', '2022-12-29', 'BN019', 'NV009');
INSERT INTO HOADON (MaHD, NgayLap, MaBN, MaNV) VALUES 
('HD020', '2022-04-30', 'BN020', 'NV010');


INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD001', 'VC001', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD002', 'VC003', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD003', 'VC005', 3);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD004', 'VC007', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD005', 'VC009', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD006', 'VC011', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD007', 'VC013', 3);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD008', 'VC015', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD009', 'VC017', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD010', 'VC019', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD011', 'VC021', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD012', 'VC023', 3);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD013', 'VC002', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD014', 'VC004', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD015', 'VC006', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD016', 'VC008', 3);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD017', 'VC010', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD018', 'VC012', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD019', 'VC014', 3);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD020', 'VC016', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD001', 'VC003', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD002', 'VC005', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD003', 'VC007', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD004', 'VC009', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD005', 'VC011', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD006', 'VC013', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD007', 'VC015', 3);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD008', 'VC017', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD009', 'VC019', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD010', 'VC021', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD011', 'VC023', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD012', 'VC001', 3);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD013', 'VC003', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD014', 'VC005', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD015', 'VC007', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD016', 'VC009', 3);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD017', 'VC011', 1);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD018', 'VC013', 2);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD019', 'VC015', 3);
INSERT INTO CHITIETHOADON (MaHD, MaVC, SOLUONG) VALUES ('HD020', 'VC017', 1);

INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN020', 'VC017', 'NV001', 'LT020', 'HD020', '2024-02-15', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN019', 'VC015', 'NV002', 'LT019', 'HD019', '2024-03-18', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN018', 'VC013', 'NV003', 'LT018', 'HD018', '2024-04-25', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN017', 'VC011', 'NV004', 'LT017', 'HD017', '2024-05-12', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN016', 'VC009', 'NV005', 'LT016', 'HD016', '2024-06-20', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN015', 'VC007', 'NV006', 'LT015', 'HD015', '2024-07-03', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN014', 'VC005', 'NV007', 'LT014', 'HD014', '2024-08-14', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN013', 'VC003', 'NV008', 'LT013', 'HD013', '2024-09-09', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN012', 'VC001', 'NV009', 'LT012', 'HD012', '2024-10-22', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN011', 'VC023', 'NV010', 'LT011', 'HD011', '2024-11-11', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN010', 'VC021', 'NV001', 'LT010', 'HD010', '2024-01-08', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN009', 'VC019', 'NV002', 'LT009', 'HD009', '2024-12-04', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN008', 'VC017', 'NV003', 'LT008', 'HD008', '2024-02-10', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN007', 'VC015', 'NV004', 'LT007', 'HD007', '2024-03-21', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN006', 'VC013', 'NV005', 'LT006', 'HD006', '2024-04-15', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN005', 'VC011', 'NV006', 'LT005', 'HD005', '2024-05-25', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN004', 'VC009', 'NV007', 'LT004', 'HD004', '2024-06-11', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN003', 'VC007', 'NV008', 'LT003', 'HD003', '2024-07-28', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN002', 'VC005', 'NV009', 'LT002', 'HD002', '2024-08-05', N'Khỏe mạnh');
INSERT INTO GHINHANTIEMCHUNG (MaBN, MaVC, MaNV, MaLT, MaHD, NgayTiem, TinhTrangSucKhoe) VALUES
('BN001', 'VC003', 'NV010', 'LT001', 'HD001', '2024-09-18', N'Khỏe mạnh');


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


