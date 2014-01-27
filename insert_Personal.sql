create procedure insert_Personal(@cnp as char(13), @nume as char(50), @prenume as char(50), @tel as char(10),@adr as char(100), @dataa as date, @datai as date, @parola as char(20), @idcat as int, @idsec as int, @sal as float) 
as
insert into Personal(CNP,Nume,Prenume,Telefon,Adresa,Data_angajare,Data_incheiere,Parola,Salariu,IDCateg,IDSectie)
values (@cnp, @nume, @prenume, @tel, @adr, @dataa, @datai, PWDENCRYPT(@parola),@sal, @idcat, @idsec) 