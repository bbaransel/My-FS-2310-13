/*
Daha Önceden FilmDb adýyla oluþturduðumuz veritabanýný MovieDb Adýyla Sql sorgularý yazarak oluþturunuz.
*/
use master
go

drop database if exists MovieDb
go

create database MovieDb
go

use MovieDb
go

create table Categories(
Id int primary key identity(1,1),
Name nvarchar(50) not null,
Description nvarchar(100),
IsActive bit default 1 not null,
CreatedDate datetime default getdate() not null
)

go

insert into Categories(Name) values
('Macera'),('Komedi'),('Duygusal')
go

create table Directors(
Id int primary key identity(1,1),
Name nvarchar(50) not null,
Gender bit not null,
Age smallint,
IsActive bit default 1 not null,
CreatedDate datetime default getdate() not null
)

go
insert into Directors(Name, Gender) values
('Ferzan',1),('Kemal',0),('Suzan',1),('Cemal',0),('Zeynep',1),('Baransel',0)
go

create table Films(
Id int primary key identity(1,1),
Name nvarchar(50) not null,
IsActive bit default 1 not null,
CreatedDate datetime default getdate() not null,
CategoryId int foreign key references Categories(Id),
DirectorId int foreign key references Directors(Id)
)

go
insert into Films (Name, CategoryId, DirectorId) values
('Özgürlüðe Kaçýþ',1,1),
('Ölümlü Dünya',1,1),
('Sevgi Yolu',1,1),
('Bing Bang Theory',1,1),
('La Casa de Papel',1,2),
('Hababam Sýnýfý',2,2),
('Zindan Adasý',2,3),
('Melekler Þehri',2,3),
('Prestige',2,3),
('Kaybedenler Klubü',2,3),
('Leon Sevginin Yolu',2,3),
('Hýzlý ve Öfkeli',2,4),
('Görevimiz Tehlike',2,4),
('Esaretin Bedeli',2,5),
('Yüzüklerin Efendisi',1,5),
('Ýnception',1,6),
('Bilmiyorum',1,6)

go

create table Stars(
Id int primary key identity(1,1),
FirstName nvarchar(50) not null,
LastName nvarchar(50) not null,
Age smallint,
Gender bit not null,
IsActive bit default 1 not null,
CreatedDate datetime default getdate() not null
)

go

insert into Stars(FirstName,LastName,Gender) values
('Ali','Can',0),
('Sezen','Kültablasý',1),
('Kumru','Camdanbakan',1),
('Ayþe','Günükurtaran',1),
('Halil','Yürekyakan',0)
go

create table FilmStars(
	StarId int foreign key references Stars(Id),
	FilmId int foreign key references Films(Id),
	constraint [PK_FilmsStars] primary key clustered(
		StarId, FilmId
	)on [PRIMARY]
)
go