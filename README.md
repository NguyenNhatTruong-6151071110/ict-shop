
1. Giải nén

2. Kết nối cơ sở dữ liệu
- Mở thư mục database Copy 2 file vào thư mục data của SQL SERVER
PATH: C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA
- Mở sql server attach db 
- Xong

3. Mở project với Visual Studio
file ictshop.sln
- Vào file Web.config

4. Config lại kết nối từ Visual Studio đến SQL Server
- Tại thẻ <connectionStrings> </connectionStrings>
thay đổi tên server , tài khoản , mật khẩu kết nối đến sql server
data source là server name

Lưu lại. build lại ứng dụng . Và run


Phân quyền quản trị và khách hàng

Bấm mua hàng : giỏ hàng sẽ cập nhật sản phẩm đã chọn.
Có thể chỉnh sửa giỏ hàng >
Đặt hàng

Kích vào hình ảnh để xem chi tiết sản phẩm

Đăng nhập tài khoản admin để thêm sửa xóa sản phẩm và các danh mục khác.
