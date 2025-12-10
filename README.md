# LAB 4 NT106.Q14 - Lập trình Sockets trong C#

Bài tập trên GitHub để nộp cho giáo viên lớp NT106.Q14 UIT VNUHCM 2025

- Lớp học: NT106.Q14
- Giáo viên hướng dẫn: ThS. Lê Minh Khánh Hội

## THÔNG TIN CÁC THÀNH VIÊN
| Tên thành viên   |      MSSV      |
|------------------|:--------------:|
| Nguyễn Nhật Anh  |   24520112     |
| Nguyễn Hoàng Anh  |   24520102     |
| Huỳnh Hoàng Tứ Văn |   24521977     |
| Trần Huy Vũ  |   24522043     |
| Lê Nguyễn Phương Vy   |   24522056     |

## Phần mềm cần thiết

* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

## Hướng dẫn cài đặt

### 1. Tải và cài đặt các phần mềm cần thiết

### 2. Cài đầy đủ thành phần cho VS2022
#### Workloads:
  
   * ".NET desktop development"
   * "Data storage and processing"

### 3. Tạo bản sao của repository NT106-LAB4
```bash
git clone https://github.com/SPdream99/NT106-LAB4/
cd "NT106-LAB4\Lab4"
start Lab4.slnx
```

### 4. Build và chạy Lab04
* Set project (Bài) muốn chạy thành Startup Project
* Debug -> Start Debugging

### 5. Sử dụng ứng dụng
Từ Lab04, chọn bài muốn test

| Bài | Tên Project | Mô tả và Công cụ chính |
| :--- | :--- | :--- |
| **Bài 1** | **GetHTML** | **HTTP GET cơ bản:** Lấy và hiển thị toàn bộ mã nguồn HTML của một URL bất kỳ. **Sử dụng:** `WebRequest` và `WebResponse`|
| **Bài 2** | **DownloadWebPage** | **Tải File:** Download nội dung trang web từ URL và lưu thành file HTML cục bộ. **Sử dụng:** `WebClient` và phương thức `DownloadFile`|
| **Bài 3** | **SimpleWebBrowser** | **Trình duyệt cơ bản:** Triển khai các tính năng xem nội dung website, tải file HTML, và tải tài nguyên (Resource - ví dụ: hình ảnh) của trang. **Sử dụng:** Control `WebView2` và thư viện `HTMLAgilityPack`|
| **Bài 4** | **TicketManager_v4** | **Data Scraping (Trích xuất dữ liệu):** Xây dựng ứng dụng trích xuất (draw) thông tin phim từ một website đặt vé (`https://betacinemas.vn/phim.htm`). Dữ liệu tóm tắt được lưu trữ dưới dạng JSON file|
| **Bài 5** | **LoginAPI** | **HTTP POST (Xác thực):** Thực hiện kết nối HTTP POST để đăng nhập vào ứng dụng Web qua API (`https://nt106.uitiot.vn/auth/token`). Trích xuất và in ra **access token** và **token type** từ phản hồi JSON|
| **Bài 6** | **GetCurrentUser** | **HTTP GET (Sử dụng JWT):** Lấy thông tin người dùng hiện tại sau khi đăng nhập. **Sử dụng:** Token đã thu được ở Bài 5 để xác thực (dưới dạng **Bearer Token** trong Headers `Authorization`)|
| **Bài 7** | **HomNayAnGi_v4** | **Ứng dụng tích hợp API:** Xây dựng ứng dụng Quản lý món ăn dựa trên hệ thống API có sẵn. Bao gồm các chức năng: Đăng ký/Đăng nhập, Thêm/Xóa món ăn, Hiển thị danh sách (có phân trang), và **Chọn ngẫu nhiên món ăn** (trong danh sách cá nhân hoặc cộng đồng)|

## Tài liệu tham khảo

* [Tài liệu C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [Tài liệu Winforms](https://learn.microsoft.com/vi-vn/dotnet/desktop/winforms/)
* Tài liệu của giáo viên cung cấp trong lớp NT106.Q14

### CC BY-NC 4.0
