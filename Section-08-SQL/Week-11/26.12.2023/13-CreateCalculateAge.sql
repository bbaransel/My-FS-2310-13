use Northwind
go

drop function if exists dbo.fnCalculateAge
go

create function fnCalculateAge
	(@birthDay date)
	returns int
begin
	declare @result int
	declare @today date
	set @today = getdate()
	set @result = DATEDIFF(year, @birthDay, @today)
	return @result
end
go

select dbo.fnCalculateAge('1975-07-16') as Age
go