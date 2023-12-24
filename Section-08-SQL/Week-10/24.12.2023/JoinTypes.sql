use MovieDb
go

--Hangi Kategoride kaç film var 

--select 
--d.Name as 'Director',
--c.Name as 'Category',
--count(f.Id) as 'Film Adedi'
--from Films f right join Categories c
--	on f.CategoryId=c.Id right join Directors d
--		on f.DirectorId=d.Id
--group by d.Name, c.Name
--order by 'Film Adedi' DESC

-- Hangi yönetmenin hangi kategoriden kaç tane filmi var
--select 
--d.Name as 'Director',
--c.Name as 'Category',
--count(f.Id) as 'Film Adedi'
--from Films f right join Categories c
--	on f.CategoryId=c.Id right join Directors d
--		on f.DirectorId=d.Id
--group by d.Name, c.Name
--order by 'Film Adedi' DESC


-- Hangi filmin oyuncusu yoktur?

--select 
--f.Name as Film
--from Films f  left outer join FilmsStars fs
--	on f.Id=fs.FilmId left outer join Stars s
--		on fs.StarId=s.Id
--group by f.Name
--having count(s.Id)=0
use Northwind
go

-- Hangi kategoriden kaç paralýk satýþ yapmýþýz.

--select top (1)
--c.CategoryName as Category,
--sum(od.UnitPrice*od.Quantity) as Total
--from Categories c join Products p
--	on c.CategoryID=p.CategoryID join OrderDetails od
--		on p.ProductID=od.ProductID
--group by c.CategoryName
--order by Total DESC

-- Hangi üründen kaç adet satýlmýþtýr. Satýþý yapýlmamýþ ürün varsa o da listelensin

--select 
--p.ProductName as Product,
--count(od.Quantity) as 'Adet'
--from Products p left join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--order by Adet 


--select 
--p.ProductName as Product
--from Products p left join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--having sum(od.Quantity) Is Null

--En çok ciro yapýlan üç ürün hangisidir? Cirolarý ile birlikte listeleyiniz.

--select top 3
--p.ProductName as Product,
--sum(od.Quantity*od.UnitPrice) as 'Ciro'
--from Products p left join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--order by Ciro DESC

--Hangi müþteriye ne kadarlýk satýþ yapýlmýþtýr? Satýþ tutarýna göre büyükten küçüðe sýraðý listele

--select 
--c.CompanyName as Company,
--sum(od.Quantity*od.UnitPrice) as Ciro
--from Customers c join Orders o
--	on c.CustomerID=o.CustomerID join OrderDetails od
--		on o.OrderID=od.OrderID
--group by c.CompanyName
--order by Ciro desc

--Hangi bölgede hangi üründen ne kadarlýk satýþ yapýlmýþtýr.

select 
r.RegionDescription as Region,
p.ProductName as Product,
sum(od.Quantity*od.UnitPrice) Ciro
from Region r join Territories t
	on r.RegionID=t.RegionID join EmployeeTerritories et
		on t.TerritoryID=et.TerritoryID join Employees e
			on et.EmployeeID=e.EmployeeID join Orders o
				on e.EmployeeID=o.EmployeeID join OrderDetails od
					on o.OrderID=od.OrderID join Products p
						on od.ProductID=p.ProductID
--where r.RegionDescription='Eastern'
group by r.RegionDescription, p.ProductName
--having
order by r.RegionDescription, p.ProductName
