use Northwind
go

drop proc if exists spGetOrderWithDiscount
go
create proc spGetOrderWithDiscount
as
	select 
	od.OrderID as 'Satýþ No',
	sum(od.UnitPrice*od.Quantity*(1-od.Discount)) as 'Sipariþ Tutarý'
	from OrderDetails od
	group by od.OrderID
go

--Test

exec spGetOrderWithDiscount
go