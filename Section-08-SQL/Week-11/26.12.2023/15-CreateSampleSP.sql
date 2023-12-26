/*
	Stored Procedure
Server �zerinde �al��t�r�lan kod par�alar�d�r.
Functionlara g�re daha g�venli ve h�zl� �al���rlar, bu y�zden de daha �ok tercih edilirler.
*/
use Northwind
go

drop procedure if exists spSample
go

create procedure spSample
as
	select *
	from Products p
	where p.CategoryID=1
	order by p.UnitPrice desc
go
execute spSample