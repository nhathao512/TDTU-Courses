CREATE DATABASE QLTV1
--DROP DATABASE Library_Management
USE QLTV1

CREATE TABLE DocGia (
    MaDocGia VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50),
    NgaySinh DATE
)

-- Tạo bảng Sách
CREATE TABLE Sach (
    MaSach VARCHAR(10) PRIMARY KEY,
    TenSach NVARCHAR(100),
    TacGia NVARCHAR(50),
    SoLuong INT
)

-- Tạo bảng MuonSach
CREATE TABLE MuonSach (
    MaPhieuMuon VARCHAR(10) PRIMARY KEY,
    MaDocGia VARCHAR(10),
    NgayMuon DATE,
    FOREIGN KEY (MaDocGia) REFERENCES DocGia(MaDocGia)
)

CREATE TABLE CTPM (
    MaPhieuMuon VARCHAR(10),
    MaSach VARCHAR(10),
    NgayTra DATE,
    PRIMARY KEY (MaPhieuMuon, MaSach),
    FOREIGN KEY (MaPhieuMuon) REFERENCES MuonSach(MaPhieuMuon),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
)

-- Nhập dữ liệu mẫu vào bảng Độc giả
INSERT INTO DocGia (MaDocGia, HoTen, NgaySinh) 
VALUES
('DG001', N'Nguyễn Văn A', '1990-01-01'),
('DG002', N'Trần Thị B', '1992-02-02'),
('DG003', N'Trần Thanh C', '1996-03-10'),
('DG004', N'Phạm Thị D', '1995-07-12'),
('DG005', N'Nguyễn Thành E', '1995-07-12');

-- Nhập dữ liệu mẫu vào bảng Sách
INSERT INTO Sach (MaSach, TenSach, TacGia, SoLuong) 
VALUES
('MS001', N'1984', N'George Orwell', 3),
('MS002', N'To Kill a Mockingbird', N'Harper Lee', 5),
('MS003', N'The Great Gatsby', N'F. Scott Fitzgerald', 2),
('MS004', N'Pride and Prejudice', N'Jane Austen', 4),
('MS005', N'The Catcher in the Rye', N'J.D. Salinger', 1);

-- Nhập dữ liệu mẫu vào bảng Mượn sách
INSERT INTO MuonSach (MaPhieuMuon, MaDocGia, NgayMuon) 
VALUES
('PM001', 'DG002', '2024-03-01'),
('PM002', 'DG004', '2024-03-05'),
('PM003', 'DG001', '2024-03-10'),
('PM004', 'DG003', '2024-03-07'),
('PM005', 'DG005', '2024-03-03');

-- Nhập dữ liệu mẫu vào bảng CTPM
INSERT INTO CTPM (MaPhieuMuon, MaSach, NgayTra) 
VALUES
('PM001', 'MS001', '2024-03-10'),
('PM001', 'MS002', '2024-03-10'),
('PM002', 'MS003', '2024-03-12'),
('PM003', 'MS001', '2024-03-15');


--tao phieu moi
CREATE PROCEDURE PhatSinhMaPhieuMuon1
    @MaPhieuMuon VARCHAR(10) OUTPUT
AS
BEGIN
    DECLARE @MaxMaPhieuMuon INT

    -- Lấy số cao nhất từ cột mã phiếu mượn
    SELECT @MaxMaPhieuMuon = ISNULL(MAX(CAST(SUBSTRING(MaPhieuMuon, 3, LEN(MaPhieuMuon)) AS INT)), 0)
    FROM MuonSach;

    -- Phát sinh mã mới
    SET @MaPhieuMuon = 'PM' + CAST(@MaxMaPhieuMuon + 1 AS VARCHAR(10))
END;


DECLARE @MaPhieuMuonGenerated VARCHAR(10)
EXEC PhatSinhMaPhieuMuon1 @MaPhieuMuonGenerated OUTPUT
PRINT @MaPhieuMuonGenerated