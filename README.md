# c-sharp-learning
 
## Requiredment Technology
- Net 7.0
- MySQL 8.0.31
- VS Code lastest

## Cách chạy (Usage)
1. Chạy toàn bộ file init.sql
2. Chỉnh sửa file app-setting.json phần ConnectionString
> __server__ : mặc định là localhost

> __port__ : tuỳ cấu hình. ko chỉnh gì thì là 3306

> __user__ : có thể là `root` hoặc 1 user tự tạo được trao quyền.

> __pass__ : ********
3. Chạy trên terminal tại folder chứa code 
`dotnet build && dotnet run`
4. Vào trình duyệt, truy cập đường dẫn trong file
