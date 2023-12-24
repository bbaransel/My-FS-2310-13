use Northwind
go

--declare @metin nvarchar(10)
--set @metin= 'zeynep'
--select dbo.fnSample(@metin)

select 
	c.CompanyName,
	dbo.fnSample(c.CompanyName) as [Büyük Harf]
from Customers c