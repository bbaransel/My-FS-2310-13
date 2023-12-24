--Kendisine gönderilecek 2 adet sayýyý toplayýp sonucu dödüren function hazýrla

drop function if exists dbo.fnTopla
go

create function fnTopla
(@sayi1 int, @sayi2 int)
returns int
begin
return @sayi1+@sayi2
end


select dbo.fnTopla(4,8) [Result]