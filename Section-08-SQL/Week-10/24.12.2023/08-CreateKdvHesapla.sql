use Northwind
go

create function fnKdvHesapla
	(@deger money, @oran money)
	returns money
begin
	return @deger*@oran
end