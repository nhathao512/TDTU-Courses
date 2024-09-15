CREATE DATABASE QLTV;

CREATE TABLE DocGia 
(
    MaDocGia INT PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE
);

CREATE TABLE Sach 
(
    MaSach INT PRIMARY KEY,
    TenSach NVARCHAR(100),
    TacGia NVARCHAR(100),
    SoLuong INT
);

CREATE TABLE MuonSach 
(
    MaPhieuMuon INT PRIMARY KEY,
    MaDocGia INT,
    NgayMuon DATE,
    FOREIGN KEY (MaDocGia) REFERENCES DocGia(MaDocGia)
);

CREATE TABLE CTPM 
(
    MaPhieuMuon INT,
    MaSach INT,
    NgayTra DATE,
    FOREIGN KEY (MaPhieuMuon) REFERENCES MuonSach(MaPhieuMuon),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);

INSERT INTO DocGia (MaDocGia, HoTen, NgaySinh) VALUES 
(1, 'Nguyen Van A', '1990-01-01'),
(2, 'Tran Thi B', '1995-05-05'),
(3, 'Vo Nhat Hao', '2004-12-05'),
(4, 'Pham Van C', '2003-05-06'),
(5, 'Tran Duc D', '2000-12-12');

INSERT INTO Sach (MaSach, TenSach, TacGia, SoLuong) VALUES 
(101, 'Sach 1', 'Tac Gia A', 5),
(102, 'Sach 2', 'Tac Gia B', 3),
(103, 'Sach 3', 'Tac Gia C', 10),
(104, 'Sach 4', 'Tac Gia D', 2),
(105, 'Sach 5', 'Tac Gia E', 8);

INSERT INTO MuonSach (MaPhieuMuon, MaDocGia, NgayMuon) VALUES 
(1001, 1, '2024-03-10'),
(1002, 2, '2024-03-11'),
(1003, 3, '2024-03-12'),
(1004, 4, '2024-03-13'),
(1005, 5, '2024-03-14');

INSERT INTO CTPM (MaPhieuMuon, MaSach, NgayTra) VALUES 
(1001, 101, '2024-04-10'),
(1002, 102, '2024-04-11'),
(1003, 103, '2024-04-12'),
(1005, 105, '2024-04-13'),
(1004, 104, '2024-04-15');