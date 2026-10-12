# Chủ đề: Hệ thống quản lý phòng khám
## US-01 · Patient: đặt lịch khám
1. Patient chọn Doctor và Appointment còn trống → đặt lịch → hệ thống lưu thông tin Appointment.
2. Appointment đã có người đặt → Patient đặt lại → báo lỗi.
## US-02 · Patient: xem lịch khám
1. Patient đăng nhập → xem danh sách Appointment → hệ thống hiển thị Doctor, thời gian và phòng khám.
2. Patient không có Appointment → hệ thống thông báo chưa có lịch khám.
## US-03 · Doctor: xem danh sách bệnh nhân
1. Doctor chọn ngày khám → hệ thống hiển thị danh sách Patient đã đặt Appointment.
2. Không có Patient đăng ký → hệ thống thông báo không có lịch khám.
## US-04 · Doctor: cập nhật kết quả khám
1. Doctor chọn Patient → nhập MedicalRecord và hướng điều trị → hệ thống lưu thông tin.
2. Chưa nhập đầy đủ MedicalRecord → lưu → báo lỗi.
## US-05 · Receptionist: quản lý lịch khám
1. Receptionist nhập thông tin Doctor, thời gian và phòng khám → tạo Appointment → hệ thống lưu lịch khám.
2. Thời gian bị trùng Appointment → tạo lịch → báo lỗi.
## US-06 · Admin: quản lý tài khoản
1. Admin tạo Account cho Doctor hoặc Receptionist → nhập đầy đủ thông tin → hệ thống lưu Account.
2. Account đã tồn tại → tạo lại → báo lỗi.

