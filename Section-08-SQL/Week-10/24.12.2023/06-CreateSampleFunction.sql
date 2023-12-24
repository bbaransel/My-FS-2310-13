--Functions
/*
	-Geriye de�er d�nd�rebilen yap�lard�r.
	-Sorgular�n i�inde kullan�lablirler.
	-Geriye bir DE�ER yada TABLO d�d�rebilirler.
	-Parametre alabilirler.
	-Bir fonksiyon tablo �zerinde insert, update, delete gibi i�lemleri yapamaz. Ama bu sorgular i�erisinde de fonksiyon kullan�labilir.
*/
use Northwind
go

create function fnSample(@txt nvarchar(max)) 
	returns nvarchar(max)
begin 
	return upper(@txt)
end
