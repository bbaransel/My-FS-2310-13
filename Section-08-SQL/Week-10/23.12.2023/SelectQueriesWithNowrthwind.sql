use Northwind
go

--select *
--from Products

--select *
--from Products
--where ProductID=8

--select *
--from Products
--where CategoryID=1 and UnitsInStock>=50 and SupplierID=16

--select *
--from Products
--where CategoryID=1 or CategoryID=2

--select *
--from Products
--where UnitPrice>=50 and UnitPrice<=60

--select count(*) as 'Beverages Kategorisindeki Tüm Ürünler'
--from Products
--where CategoryID=1

-- * yerine ProductId de yazýlabilir bize colondaki içi dolu olanlarýn tümünü göstermek için kolaylýk olsun diye konulmuþ.

--select min(UnitPrice) as 'Minimum Ürün Fiyatý'
--from Products

--select max(UnitPrice) as 'Maximum Ürün Fiyatý'
--from Products

--select *, od.UnitPrice * od.Quantity as 'Total'
--from OrderDetails od

--select sum (od.UnitPrice * od.Quantity) as 'Ciro'
--from OrderDetails od

--select avg (od.UnitPrice * od.Quantity) as [Ortalama Satýþ]
--from OrderDetails od

--select e.TitleOfCourtesy+' '+e.FirstName +' '+ e.LastName as [Employees], e.City, e.Country
--from Employees e

--select upper(e.FirstName+ ' ' + e.LastName) as 'Soyad'
--from Employees e
--select lower(e.FirstName+ ' ' + e.LastName) as 'Soyad'
--from Employees e

-- Çalýþanlarýmýza ad.soyad þeklinde mail adresi verliecektir. Bunun için gerekli mail adresini oluþturacak kodu yazýnýz. Geriya ad soyad ve mail adresi dönsün
-- not: mail adresiörneði : ad.soyad.@bright.com

--select e.FirstName as Ad,
--e.LastName as Soyad,
--lower(e.FirstName+'.'+e.LastName+'@bright.com') as Mail
--from Employees e
-- tek kelime olunca '' veya [] kullanmaya gerek yok

--select len(e.FirstName) as 'FirstName Uzunluðu'
--from Employees e

--select
--p.ProductName as 'Name',
--lower(replace(REPLACE(p.ProductName, ' ', '-'),'''','')) as 'Url'
--from Products p

--select
--o.EmployeeID as 'Çalýþan',
--count(*) as 'Satýþ Adedi'
--from Orders o
--group by o.EmployeeID

--select 
--od.OrderID,
--sum(od.UnitPrice*od.Quantity) as Total
--from OrderDetails od
--group by od.OrderID

--select
--o.EmployeeID,
--o.CustomerID,
--count(*) as 'Quantity'
--from Orders o
--group by o.EmployeeID, o.CustomerID
