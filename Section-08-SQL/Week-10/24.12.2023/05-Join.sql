--Tüm filmleri kategori adlarý ile listele
--use MovieDb
--go

--select 
--f.Id as ID,
--f.Name as Film,
--c.Name Kategori
--from Films f join Categories c on f.CategoryId=c.Id

use Northwind
go

--select 
--p.ProductID as ID,
--p.ProductName as Product,
--p.UnitPrice as Price,
--c.CategoryName as Category
--from Products p join Categories c
--	on p.CategoryID=c.CategoryID 

--select 
--p.ProductID as ID,
--p.ProductName as Product,
--c.CategoryName as Category,
--s.CompanyName as 'Supplier Company'
--from Products p join Categories c
--	on p.CategoryID=c.CategoryID join Suppliers s
--		on p.SupplierID=s.SupplierID


--select 
--p.ProductID as ID,
--p.ProductName as Product,
--p.UnitPrice as Price,
--c.CategoryName as Category,
--s.CompanyName as 'Supplier Company'
--from Products p join Categories c
--	on p.CategoryID=c.CategoryID join Suppliers s
--		on p.SupplierID=s.SupplierID
--where c.CategoryName='Condiments'


-- USA den tedarik edilen ürünleri listeleyin

--select 
--p.ProductID as ID,
--p.ProductName as Product,
--s.Country as Country
--from Products p join Suppliers s
--		on p.SupplierID=s.SupplierID
--where s.Country='USA'


-- USAden tedarik edilen ürünlere ait sipariþlerin toplam tutarý
--select 
--top (5)
--p.ProductName as Product,
--sum(od.UnitPrice*od.Quantity) as Total
--from Products p join Suppliers s
--		on p.SupplierID=s.SupplierID join OrderDetails od
--			on p.ProductID=od.ProductID
--where s.Country='USA'
--group by p.ProductName
--order by Total DESC
-- ASC yazmasak da default hali o azdan çoða sýralar
-- orderby Total DESC çoktan aza sýralýyor


--Hangi çalýþan bugüne kadar kaç adet sipariþ almýþ?

--select 
--e.EmployeeID as ID,
--e.FirstName as Name,
--count(*) as Total
--from Employees e join Orders o
--	on e.EmployeeID=o.EmployeeID
--group by e.FirstName, e.EmployeeID
