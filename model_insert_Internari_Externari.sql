DECLARE @id uniqueidentifier
SET @id = NEWID()

insert into Internari_Externari(IDInreg,CNP,CNP_Medic,Data_internare,IDSectie)
values (@id,'1934627525712','2921704353742','2014.01.27',1)