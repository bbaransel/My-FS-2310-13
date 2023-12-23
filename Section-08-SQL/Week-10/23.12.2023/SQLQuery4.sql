/*
Daha �nceden FilmDb ad�yla olu�turdu�umuz veritaban�n� MovieDb Ad�yla Sql sorgular� yazarak olu�turunuz.
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
('�zg�rl��e Ka���',1,1),
('�l�ml� D�nya',1,1),
('Sevgi Yolu',1,1),
('Bing Bang Theory',1,1),
('La Casa de Papel',1,2),
('Hababam S�n�f�',2,2),
('Zindan Adas�',2,3),
('Melekler �ehri',2,3),
('Prestige',2,3),
('Kaybedenler Klub�',2,3),
('Leon Sevginin Yolu',2,3),
('H�zl� ve �fkeli',2,4),
('G�revimiz Tehlike',2,4),
('Esaretin Bedeli',2,5),
('Y�z�klerin Efendisi',1,5),
('�nception',1,6),
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
('Sezen','K�ltablas�',1),
('Kumru','Camdanbakan',1),
('Ay�e','G�n�kurtaran',1),
('Halil','Y�rekyakan',0)
go

create table FilmStars(
	StarId int foreign key references Stars(Id),
	FilmId int foreign key references Films(Id),
	constraint [PK_FilmsStars] primary key clustered(
		StarId, FilmId
	)on [PRIMARY]
)
go