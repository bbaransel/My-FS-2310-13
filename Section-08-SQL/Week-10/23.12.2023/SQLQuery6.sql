use MovieDb
go
-- CTRL+R a�a��daki console u (Results ve Messages yazan yer) a��p kapatmaya yar�yor.

--select *
--from Categories

-- Ayn� anda b�t�n tablolar� g�rmemek i�in bakt�ktan sonra commente �evirdik

select Name as [Film Ad�], IsActive as 'Aktif mi?', CreatedDate as [Olu�turulma Tarihi]
from Films
-- as den sonra [] i�inde ya da '' i�inde kullan�labilir.

