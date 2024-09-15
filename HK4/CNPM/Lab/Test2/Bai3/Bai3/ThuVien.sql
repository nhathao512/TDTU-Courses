use master 
create database ThuVien
use ThuVien
-- Tạo bảng Độc giả
CREATE TABLE DocGia (
    MaDocGia VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50),
    NgaySinh DATE
);

-- Tạo bảng Sách
CREATE TABLE Sach (
    MaSach VARCHAR(10) PRIMARY KEY,
    TenSach NVARCHAR(100),
    TacGia NVARCHAR(50),
    SoLuong INT
);

-- Tạo bảng MuonSach
CREATE TABLE MuonSach (
    MaPhieuMuon VARCHAR(10) PRIMARY KEY,
    MaDocGia VARCHAR(10),
    NgayMuon DATE,
    FOREIGN KEY (MaDocGia) REFERENCES DocGia(MaDocGia)
);

-- Tạo bảng ChiTietPhieuMuon
CREATE TABLE ChiTietPhieuMuon (
    MaPhieuMuon VARCHAR(10),
    MaSach VARCHAR(10),
    NgayTra DATE,
    PRIMARY KEY (MaPhieuMuon, MaSach),
    FOREIGN KEY (MaPhieuMuon) REFERENCES MuonSach(MaPhieuMuon),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);

--Insert data
-- Thêm dữ liệu vào bảng Độc giả
INSERT INTO DocGia (MaDocGia, HoTen, NgaySinh) VALUES
('DG001', 'Nguyen Van A', '1990-05-15'),
('DG002', 'Tran Thi B', '1985-08-20'),
('DG003', 'Le Van C', '1995-02-10');

-- Thêm dữ liệu vào bảng Sách
INSERT INTO Sach (MaSach, TenSach, TacGia, SoLuong) VALUES
('MS101', 'Sach 1', 'Tac Gia 1', 20),
('MS102', 'Sach 2', 'Tac Gia 2', 15),
('MS103', 'Sach 3', 'Tac Gia 3', 25);

-- Thêm dữ liệu vào bảng MuonSach
INSERT INTO MuonSach (MaPhieuMuon, MaDocGia, NgayMuon) VALUES
('PM001', 'DG001', '2024-03-01'),
('PM002', 'DG002', '2024-03-05'),
('PM003', 'DG003', '2024-03-08');

-- Thêm dữ liệu vào bảng ChiTietPhieuMuon
INSERT INTO ChiTietPhieuMuon (MaPhieuMuon, MaSach, NgayTra) VALUES
('PM001', 'MS101', '2024-03-10'),
('PM001', 'MS102', '2024-03-10'),
('PM002', 'MS103', '2024-03-12'),
('PM003', 'MS101', '2024-03-15');


select * from MuonSach

--Tạo mã phiếu tự động 
-- Tạo procedure
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
