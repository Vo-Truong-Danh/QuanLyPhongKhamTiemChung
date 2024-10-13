# 🏥 Hệ thống quản lý phòng khám tiêm chủng

## 🌟 Giới thiệu
**Hệ thống quản lý phòng khám tiêm chủng** là một hệ thống toàn diện giúp quản lý các quy trình tiêm chủng của phòng khám, từ quản lý bệnh nhân, lịch tiêm, kho vaccine cho đến hóa đơn và nhà cung cấp. Dự án này giúp phòng khám tự động hóa các quy trình thủ công, tăng cường độ chính xác và tiết kiệm thời gian cho nhân viên y tế. 🏥💉

> **"Chăm sóc sức khỏe là nền tảng của cuộc sống."**  
> - _Sứ mệnh của chúng tôi là đảm bảo việc quản lý tiêm chủng dễ dàng, chính xác và hiệu quả._

## 🖼️ Sơ đồ ERD
Dưới đây là sơ đồ ERD (Entity Relationship Diagram) mô tả cấu trúc cơ sở dữ liệu của hệ thống:

![Sơ đồ ERD](https://github.com/user-attachments/assets/18eac9bb-ae18-47ed-9f5f-4f06f3e9c28e)


## ⚙️ Tính năng
- 👨‍⚕️ **Quản lý bệnh nhân**: Lưu trữ và quản lý thông tin bệnh nhân, lịch sử tiêm chủng và lịch hẹn.
- 💉 **Quản lý kho vaccine**: Theo dõi tồn kho vaccine, ngày hết hạn và thông tin nhà cung cấp.
- 👩‍⚕️ **Quản lý nhân viên**: Duy trì hồ sơ của nhân viên phòng khám và vai trò của họ.
- 📅 **Lên lịch tiêm chủng**: Lên lịch và quản lý các buổi tiêm chủng của bệnh nhân.
- 🧾 **Quản lý hóa đơn**: Tự động tạo và quản lý hóa đơn sau dịch vụ tiêm chủng.
- 🏢 **Quản lý nhà cung cấp**: Theo dõi thông tin nhà cung cấp vaccine và các đợt nhập hàng.

## 🗄️ Cấu trúc cơ sở dữ liệu
- **BENHNHAN (Bệnh nhân)**: Lưu trữ thông tin bệnh nhân như họ tên, ngày sinh, giới tính, và số điện thoại.
- **NHANVIEN (Nhân viên)**: Lưu trữ thông tin nhân viên như tên, chức vụ và thông tin liên hệ.
- **NHACUNGCAP (Nhà cung cấp)**: Quản lý thông tin các nhà cung cấp vaccine, bao gồm tên nhà cung cấp, địa chỉ và số điện thoại.
- **VACCINE**: Lưu trữ các thông tin về vaccine, bao gồm loại vaccine, ngày sản xuất, hạn sử dụng và số lượng tồn kho.
- **LOAIVACINE (Loại vaccine)**: Lưu trữ các loại vaccine mà phòng khám sử dụng.
- **PHIEUNHAP (Phiếu nhập)**: Ghi nhận thông tin các đợt nhập vaccine, bao gồm ngày nhập và nhà cung cấp.

- **CHITIETPHIEUNHAP (Chi tiết phiếu nhập)**: Chi tiết về vaccine được nhập trong mỗi phiếu nhập, bao gồm số lượng và đơn giá.

- **HOADON (Hóa đơn)**: Lưu trữ thông tin về hóa đơn tiêm chủng của bệnh nhân, bao gồm ngày lập, bệnh nhân, nhân viên phụ trách và tổng tiền.

- **CHITIETHOADON (Chi tiết hóa đơn)**: Chi tiết về các vaccine đã được cung cấp trong mỗi hóa đơn, bao gồm số lượng và đơn giá.

- **GHINHANTIEMCHUNG (Ghi nhận tiêm chủng)**: Quản lý các mũi tiêm đã thực hiện cho bệnh nhân, bao gồm thông tin bệnh nhân, vaccine và ngày tiêm.

- **LICHTIEM (Lịch tiêm)**: Quản lý lịch hẹn tiêm chủng của bệnh nhân, bao gồm thông tin về bệnh nhân, vaccine, ngày hẹn tiêm và trạng thái tiêm chủng.

- **TAIKHOAN (Tài khoản)**: Quản lý tài khoản đăng nhập của người dùng hệ thống, bao gồm tên người dùng, mật khẩu và chức vụ.


## 🚀 Bắt đầu

### 📋 Yêu cầu
- 🖥️ Microsoft SQL Server hoặc hệ quản trị cơ sở dữ liệu quan hệ tương tự.
- 🧑‍💻 Framework hoặc ngôn ngữ lập trình để xây dựng giao diện C#.
  
### ⬇️ Cài đặt
- Bước 1: Tải mã nguồn từ kho GitHub:
 
        git clone https://github.com/Vo-Truong-Danh/QuanLyPhongKhamTiemChung.git

- Bước 2: Cấu hình cơ sở dữ liệu theo sơ đồ ERD.
- Bước 3: Thiết lập kết nối cơ sở dữ liệu và chạy ứng dụng.
### ✉️ Liên hệ
        Coming Soon 
## 👥 Đóng góp
Chúng tôi hoan nghênh mọi ý kiến đóng góp từ cộng đồng. Bạn có thể:
- Tạo pull request nếu có các cải tiến, tối ưu hệ thống.
- Thảo luận các tính năng mới hoặc vấn đề trong phần **Issues** của dự án.

🔗 [GitHub Repository]( https://github.com/Vo-Truong-Danh/QuanLyPhongKhamTiemChung)  
