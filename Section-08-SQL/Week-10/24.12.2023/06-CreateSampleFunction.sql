--Functions
/*
	-Geriye deðer döndürebilen yapýlardýr.
	-Sorgularýn içinde kullanýlablirler.
	-Geriye bir DEÐER yada TABLO dödürebilirler.
	-Parametre alabilirler.
	-Bir fonksiyon tablo üzerinde insert, update, delete gibi iþlemleri yapamaz. Ama bu sorgular içerisinde de fonksiyon kullanýlabilir.
*/
use Northwind
go

create function fnSample(@txt nvarchar(max)) 
	returns nvarchar(max)
begin 
	return upper(@txt)
end
