--Functions
/*
	-Geriye değer döndürebilen yapılardır.
	-Sorguların içinde kullanılablirler.
	-Geriye bir DEĞER yada TABLO dödürebilirler.
	-Parametre alabilirler.
	-Bir fonksiyon tablo üzerinde insert, update, delete gibi işlemleri yapamaz. Ama bu sorgular içerisinde de fonksiyon kullanılabilir.
*/
use Northwind
go

create function fnSample(@txt nvarchar(max)) 
	returns nvarchar(max)
begin 
	return upper(@txt)
end
