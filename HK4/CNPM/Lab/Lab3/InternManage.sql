CREATE DATABASE InternManage
--DROP DATABASE InternManage
USE InternManage

--Students table
CREATE TABLE student (
    StudentID VARCHAR(10) PRIMARY KEY,
    FullName NVARCHAR(50),
    Hometown NVARCHAR(50),
    DOB DATE,
    GPA DECIMAL(3, 1)
)

--Project table
CREATE TABLE Project (
    ProjectID VARCHAR(10) PRIMARY KEY,
    ProjectName NVARCHAR(50),
    Supervisor NVARCHAR(50),
    Funding MONEY
)

--Student_Project table
CREATE TABLE Student_Project (
    StudentID VARCHAR(10),
    ProjectID VARCHAR(10),
    InternshipPlace NVARCHAR(50),
    Distance INT,
    Results DECIMAL(3, 1),
    PRIMARY KEY (StudentID, ProjectID),
    FOREIGN KEY (StudentID) REFERENCES student(StudentID),
    FOREIGN KEY (ProjectID) REFERENCES Project(ProjectID)
)

Insert into Project
VALUES ('DT01', N'Quản lý quán ăn', N'Nguyễn Thễ Hữu', 100000000),
    ('DT02', N'Quản lý khách sạn', N'Trần Trung Hiếu', 200000000),
    ('DT03', N'Quản lý sân bóng đá mini', N'Nguyễn Công Tâm', 300000000),
    ('DT04', N'Quản lý shop hoa tươi', N'Đặng Đức Trung', 150000000),
    ('DT05', N'Quản lý cửa hàng điện thoại', N'Trịnh Thanh Duy', 2000000000);

-- Insert Students table
INSERT INTO student
VALUES
    ('SV01', 'Trần Thanh Trâm', 'Sài Gòn', '1998-03-23', 8.5),
    ('SV02', 'Nguyễn Hồng Linh', 'Thanh Hóa', '2000-01-20', 9.0),
    ('SV03', 'Trần Thanh Phước', 'Tiền Giang', '2001-07-12', 7.5),
    ('SV04', 'Nguyễn Minh Hải', 'Nghệ An', '1993-02-28', 7.0),
    ('SV05', 'Trần Thị Hồng Nhung', 'Kiên Giang', '1998-07-15', 9.0);

-- Insert Project table
INSERT INTO Project
VALUES
    ('DT01', 'Quản lý quán ăn', 'Nguyễn Thễ Hữu', 100000000),
    ('DT02', 'Quản lý khách sạn', 'Trần Trung Hiếu', 200000000),
    ('DT03', 'Quản lý sân bóng đá mini', 'Nguyễn Công Tâm', 300000000),
    ('DT04', 'Quản lý shop hoa tươi', 'Đặng Đức Trung', 150000000),
    ('DT05', 'Quản lý cửa hàng điện thoại', 'Trịnh Thanh Duy', 2000000000);

-- Insert Student_Project table
INSERT INTO Student_Project
VALUES
    ('SV01', 'DT01', 'Tiền Giang', 70, 8.0),
    ('SV02', 'DT01', 'Bình Dương', 50, 7.0),
    ('SV03', 'DT02', 'Vũng Tàu', 150, 9.5),
    ('SV03', 'DT03', 'Long An', 50, 8.5),
    ('SV04', 'DT03', 'Nha Trang', 500, 10);