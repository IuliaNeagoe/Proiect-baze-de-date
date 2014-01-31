create procedure Insert_Internari_Externari(@cnp_pacient as char(13), @cnp_medic as char(13), @data_int as datetime, @id_sectie as int)
as
DECLARE @id uniqueidentifier
SET @id = NEWID()
insert into Internari_Externari(IDInreg,CNP,CNP_Medic,Data_internare,IDSectie)
values (@id,@cnp_pacient,@cnp_medic,@data_int,@id_sectie)