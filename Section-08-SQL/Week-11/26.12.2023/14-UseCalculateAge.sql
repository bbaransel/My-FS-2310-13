use Northwind
go

select 
e.FirstName + ' ' + e.LastName as '�al��an',
dbo.fnCalculateAge(e.BirthDate) as 'Ya�'
from Employees e
order by Ya� DESC