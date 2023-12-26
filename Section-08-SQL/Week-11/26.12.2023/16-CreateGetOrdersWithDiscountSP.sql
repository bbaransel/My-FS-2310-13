use Northwind
go

drop proc if exists spGetOrderWithDiscount
go
create proc spGetOrderWithDiscount
as
	select 
	od.OrderID as 'Sat�� No',
	sum(od.UnitPrice*od.Quantity*(1-od.Discount)) as 'Sipari� Tutar�'
	from OrderDetails od
	group by od.OrderID
go

--Test

exec spGetOrderWithDiscount
go