# Hệ Thống Quản Lý Quán Cà Phê (QuanLyQuanCafe)

Dự án này là ứng dụng Windows Forms chuyên nghiệp được phát triển trên nền tảng **.NET 8** sử dụng thư viện **Guna.UI2.WinForms** cho giao diện người dùng hiện đại và **Entity Framework Core 8** với cơ sở dữ liệu **SQL Server (LocalDB)**. 

Kiến trúc ứng dụng tuân thủ nghiêm ngặt **Kiến trúc 4 tầng (BCE - Boundary Control Entity)** đảm bảo khả năng mở rộng, bảo trì và kiểm thử dễ dàng.

---

## ☕ Tính Năng Nổi Bật

1. **Đăng nhập & Phân quyền thông minh (Security)**:
   - Hỗ trợ 3 vai trò chính: **Admin**, **Nhân viên**, **Khách hàng**.
   - Phân quyền động trên giao diện (Ẩn/Hiện các chức năng tương ứng với vai trò).
2. **Quản lý Thực Đơn (Gallery/Cards & CRUD)**:
   - Hiển thị danh sách món nước đẹp mắt dạng lưới, phân loại theo nhóm (Cà phê, Trà, Bánh, Khác).
   - Quản lý thêm/sửa/xóa thực đơn chuyên nghiệp cho Admin.
3. **Sơ Đồ Bàn Phục Vụ (Interactive Table Map)**:
   - Trực quan hóa danh sách bàn theo màu sắc trạng thái (Trống - xanh lá, Đang phục vụ - nâu đậm, Chờ thanh toán - cam).
4. **Quy Trình Đặt Món & Giỏ Hàng (Ordering Flow)**:
   - Giao diện đặt món tiện lợi, tự động tính tiền trực tiếp, cập nhật giỏ hàng trực quan.
5. **Quản Lý & Xử Lý Đơn Hàng (Order Processing)**:
   - Nhân viên tiếp nhận đơn, thực hiện và cập nhật trạng thái đơn (Chờ xử lý -> Đang phục vụ -> Hoàn thành -> Đã hủy).
6. **Thanh Toán & Hóa Đơn (Billing & Invoicing)**:
   - Thanh toán hóa đơn tức thì cho bàn, hỗ trợ các phương thức: Tiền mặt, Chuyển khoản, Ví điện tử Momo. Tự động sinh mã giao dịch duy nhất.
7. **Thống Kê Doanh Thu (Drawing2D Reports)**:
   - Vẽ biểu đồ cột 2D chuyên nghiệp bằng `System.Drawing.Drawing2D` (Gradient màu sắc, anti-aliasing) thống kê doanh thu theo thời gian.
8. **Quản Lý Tài Khoản Người Dùng (User Management)**:
   - Admin quản lý thông tin tài khoản, đặt trạng thái hoạt động hoặc khóa tài khoản thay vì xóa vật lý.

---

## 🛠️ Công Nghệ Sử Dụng

- **Framework**: .NET 8 (Windows Forms)
- **UI Components**: Guna.UI2.WinForms (Phiên bản NuGet mới nhất)
- **OR Mapping**: Entity Framework Core 8 (SQL Server Provider)
- **Database**: SQL Server (LocalDB) phục vụ chạy thử nghiệm lập tức.

---

## 📂 Kiến Trúc Dự Án (BCE)

Dự án được tổ chức thành 4 phân lớp chính:
- **`Domain` (Entity)**: Chứa các định nghĩa thực thể nghiệp vụ (`Entities.cs`) và các kiểu liệt kê trạng thái (`Enums.cs`).
- **`Infrastructure` (Infrastructure)**: Chứa cấu hình kết nối DB (`AppDbContext.cs`), cơ chế khởi tạo dữ liệu mẫu (`DbSeeder.cs`), và các lớp Repository truy cập dữ liệu (`Repositories.cs`).
- **`Application` (Control / Use Case)**: Chứa logic điều phối nghiệp vụ chính của từng chức năng độc lập (Use Cases).
- **`Presentation` (Boundary)**: Chứa các Form giao diện kế thừa chuẩn kéo thả `.Designer.cs` của Visual Studio.

---

## 🔑 Tài Khoản Thử Nghiệm

Ứng dụng tự động nạp dữ liệu mẫu khi khởi chạy lần đầu. Bạn có thể sử dụng các tài khoản sau để đăng nhập:

| Tên Đăng Nhập | Mật Khẩu | Vai Trò |
| :--- | :--- | :--- |
| **admin** | `admin123` | **Quản trị viên (Admin)** |
| **nhanvien** | `nv123` | **Nhân viên phục vụ** |
| **khach** | `kh123` | **Khách hàng** |

---

## 🚀 Hướng Dẫn Cấu Hình Và Chạy Ứng Dụng

### 1. Yêu cầu hệ thống
- **Visual Studio 2022** (hỗ trợ .NET 8 SDK).
- **LocalDB** (thường được đi kèm khi cài đặt Visual Studio với gói phát triển .NET Desktop).

### 2. Các bước khởi chạy

#### Cách 1: Sử dụng Visual Studio 2022
1. Mở dự án bằng Visual Studio 2022.
2. Đảm bảo các gói NuGet đã được khôi phục thành công (Restore NuGet Packages).
3. Nhấp nút **Start / Run** (hoặc nhấn `F5`) để build và chạy ứng dụng.
4. Ở lần chạy đầu tiên, hệ thống sẽ tự động khởi tạo cơ sở dữ liệu `QuanLyQuanCafe` và nạp dữ liệu mẫu. Quá trình này diễn ra hoàn toàn tự động.

#### Cách 2: Sử dụng dòng lệnh (Terminal/CMD/PowerShell)
Nếu bạn đang ở thư mục cha (`WindownForm_v2`), hãy chạy lệnh sau:
```bash
dotnet run --project QuanLyQuanCafe
```

Nếu bạn đang đứng trực tiếp tại thư mục dự án (`QuanLyQuanCafe`), hãy chạy lệnh:
```bash
dotnet run
```

> [!TIP]
> Nếu bạn muốn chuyển đổi sang cơ sở dữ liệu SQL Server đầy đủ, hãy chỉnh sửa Connection String trong file [appsettings.json](file:///e:/DTHU/WindownForm_v2/QuanLyQuanCafe/appsettings.json).

