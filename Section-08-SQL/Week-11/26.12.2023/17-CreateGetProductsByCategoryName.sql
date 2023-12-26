use Northwind
go

drop proc if exists spGetProductsByCategoryName
go

create proc spGetProductsByCategoryName
	@categoryName nvarchar(15)
as
	select 
	p.ProductID as 'Ürün Seri no',
	p.ProductName as 'Ürün',
	p.UnitPrice as 'Fiyat',
	c.CategoryName as 'Test Kategori adý'
	from Products p join Categories c
		on p.CategoryID= c.CategoryID
where c.CategoryName=@categoryName
order by 'Fiyat' desc
go

--exec spGetProductsByCategoryName 'Beverages'
exec spGetProductsByCategoryName @categoryName='Beverages'
go