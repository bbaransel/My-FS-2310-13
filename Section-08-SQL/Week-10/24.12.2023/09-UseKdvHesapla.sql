use Northwind
go

select 
od.OrderID,
od.UnitPrice as 'Birim fiyat',
od.Quantity as 'Adet',
od.UnitPrice*od.Quantity as [Tutar],
dbo.fnKdvHesapla(od.UnitPrice*od.Quantity,0.2) as 'KDV tutar�',
od.UnitPrice*od.Quantity + dbo.fnKdvHesapla(od.UnitPrice*od.Quantity,0.2) as 'KDV dahil tutar�'
from OrderDetails od