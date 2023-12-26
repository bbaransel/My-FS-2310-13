use Northwind
go

select 
e.FirstName + ' ' + e.LastName as 'Çalýþan',
dbo.fnCalculateAge(e.BirthDate) as 'Yaþ'
from Employees e
order by Yaþ DESC