----create database NewDb2

----create table Kisiler(Id int, Name nvarchar(50))

--use NewDb
--go
----create table Ayarlar(id int, IsActive bit, title nvarchar(100))
--create table Kurslar(
--	Id int primary key identity(1,1),
--	CourseName nvarchar(50) not null,
--	Duration smallint,
--	IsActive bit default 1,
--	CreatedDate datetime default getdate()
--)

--drop table Kisiler
use master
go

drop database NewDb