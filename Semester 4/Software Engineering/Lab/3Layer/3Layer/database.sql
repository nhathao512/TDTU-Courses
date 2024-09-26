create database InternshipManage
Create table Project
(
	PID varchar(10),
	PName nvarchar(50),
	Supervisor nvarchar(50),
	Funding int
)
insert into Project values('PO001', N'Flower shop management', N'Phuoc Tran', 1000000000)
select * from Project 
