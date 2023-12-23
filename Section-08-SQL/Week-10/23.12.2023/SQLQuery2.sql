use master
go

create database Shopping
go

use Shopping
go

--Categories tablosunu oluþturma

create table Categories(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	Description nvarchar(100),
	IsActive bit default 1,
	CreatedDate datetime default getdate(),
)
go

--Categories tablosuna veri giriþi

insert into Categories(Name) values
	('Telefon'),
	('Elektronik'),
	('Televizyon'),
	('Bilgisayar')
go

--Products tablosunu oluþturma

create table Products(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	Properties nvarchar(500),
	Price money not null,
	IsActive bit default 1,
	CreatedDate datetime default getdate(),
	CategoryId int foreign key references Categories(Id)
	-- references iliþkili diðer tabloyu ve hangi deðiþkeni ile alakalandýrýlacaðýný belirtecek.
)
go
-- Products tablosuna veri giriþi
insert into Products(Name,Price,CategoryId) values
	('IPhone 13',45000,1),
	('Samsung S23', 37000,1),
	('Xaomi 13', 21000, 1),

	('Vestel Elk.Süpürge', 9500,2),

	('Sony', 3000, 3),
	('Blaupuntk', 22000,3),

	('MacBook Air M1',4000,4),
	('Lenovo',45000,4),
	('Casper Excalibur', 60000,4),
	('Macbook Pro M3', 90000,4)
	go
