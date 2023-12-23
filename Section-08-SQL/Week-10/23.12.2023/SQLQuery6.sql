use MovieDb
go
-- CTRL+R aþaðýdaki console u (Results ve Messages yazan yer) açýp kapatmaya yarýyor.

--select *
--from Categories

-- Ayný anda bütün tablolarý görmemek için baktýktan sonra commente çevirdik

select Name as [Film Adý], IsActive as 'Aktif mi?', CreatedDate as [Oluþturulma Tarihi]
from Films
-- as den sonra [] içinde ya da '' içinde kullanýlabilir.

