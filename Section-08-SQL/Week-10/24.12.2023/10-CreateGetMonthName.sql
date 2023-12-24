use Northwind
go
create function GetMonthName
	(@date date)
	returns nvarchar(max)
begin
	declare @monthNumber smallint
	set @monthNumber= Month(@date)
	declare @result nvarchar(max)
	set @result= (
	case @monthNumber
		when 1 then 'Ocak'
		when 2 then 'Þubat'
		when 3 then 'Mart'
		when 4 then 'Nisan'
		when 5 then 'Mayýs'
		when 6 then 'Haziran'
		when 7 then 'Temmuz'
		when 8 then 'Aðustos'
		when 9 then 'Eylül'
		when 10 then 'Ekim'
		when 11 then 'Kasým'
		when 12 then 'Aralýk'
		else 'Hata'
	end)
	return @result
end