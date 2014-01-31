create procedure Insert_Diagnostic(@id_inreg as uniqueidentifier, @nume as char(100))
as
DECLARE @id uniqueidentifier
SET @id = NEWID()
insert into Diagnostic(IDDiagnostic,IDInreg,Nume)
values (@id,@id_inreg,@nume)