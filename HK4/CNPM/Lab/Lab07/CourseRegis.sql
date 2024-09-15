create database CourseRegis
create table Khoa

(

Makhoa varchar(10),

Tenkhoa nvarchar(30),

Diadiem nvarchar(30),

Dienthoai varchar(20)

)




create table Sinhvien

(

Masv varchar(10),

Ten nvarchar(30),

NS date, 

QQ nvarchar(30),

Gioitinh nvarchar(10),

DC nvarchar(30),

Makhoa varchar(10)

)

create table Monhoc

(

Mamh varchar(10),

Tenmh nvarchar(30),

STC int

)




Create table MonTQ

(

Mamh varchar(10),

Mamh_TQ varchar(10)

)




Create table Ketqua

(

Masv varchar(10),

Mamh varchar(10),

LanDK int,

DTL float,

DGK float,

DCK float

)

--

insert into Khoa values ('IT', N'Information technology', N'Tan Phong', '012')

insert into Khoa values ('ET', N'Electric technology', N'Tan Phong', '234')

insert into Khoa values ('BM', N'Bussiness Management', N'Tan Phong', '234')




insert into sinhvien values ('S01', N'Ly Duc', '2000/02/02', N'Sai Gon', N'Male', N'Sai Gon', 'IT')

insert into sinhvien values ('S02', N'Tran Tam', '2000/02/02', N'Sai Gon', N'Male', N'Sai Gon', 'IT')

insert into sinhvien values ('S03', N'Minh Binh', '2000/02/02', N'Sai Gon', N'Male', N'Sai Gon', 'IT')

insert into sinhvien values ('S04', N'Nguyen Lu', '2000/02/02', N'Sai Gon', N'Male', N'Sai Gon', 'IT')

insert into sinhvien values ('S05', N'Thai Bao', '2000/02/02', N'Sai Gon', N'Male', N'Sai Gon', 'IT')




insert into Monhoc values ('OOP', N'Object oriented Programming', 4)

insert into Monhoc values ('DBS', N'Database system', 4)

insert into Monhoc values ('DS', N'Data structure', 4)

insert into Monhoc values ('SE', N'Software engineering', 4)




insert into MonTQ values ('DBS', 'OOP')

insert into MonTQ values ('DS', 'OOP')

insert into MonTQ values ('SE', 'OOP')

insert into MonTQ values ('SE', 'DBS')




insert into Ketqua values ('S01', 'OOP', 1, 10, 10, 10)

insert into Ketqua values ('S01', 'DBS', 1, 2, 3, 4)

insert into Ketqua values ('S01', 'DBS', 2, 8, 8, 10)

select * from ketqua
