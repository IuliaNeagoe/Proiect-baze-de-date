﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Transactions;
using System.Data.Entity;
using System.Data.Objects;

namespace Aplicatie_medicala
{
    public partial class DataLayer
    {
        public Boolean get(string uname, string pass)
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                Boolean arg = false;
                var query = from b in db.Personals
                            select b;
                foreach (var item in query)
                {
                    string sqlQuery = "SELECT [dbo].[compare] ({0},{1})";
                    Object[] parameters = { pass, item.Parola };
                    int nr = db.Database.SqlQuery<int>(sqlQuery, parameters).FirstOrDefault();
                    if (nr == 1 && uname == item.CNP)
                        //Console.WriteLine("{0}",nr);
                        arg = true; ;
                }


                //var query=from b in db.Personals
                //          where b.CNP=uname && db
                return arg;
            }

        }

        
        public bool insert_Personal(string cnp, string categ, string nume, string prenume, string adresa, string tel, string sectie, DateTime data_ang, DateTime data_inc, float salariu, string parola)
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {

                var id_categ = db.Categories.Where(c => c.Nume.Equals(categ)).Select(c => c.IDCateg).First();
                var id_sectie = db.Sectiis.Where(s => s.Nume.Equals(sectie)).Select(s => s.IDSectie).First();

                db.insert_Personal(cnp, nume, prenume, tel, adresa, data_ang, data_inc, parola, id_categ, id_sectie, salariu);
                if (db.SaveChanges() > 0)
                    return true;

               

            }
            return false;
        }

        public bool insert_Pacient(string cnp, string nume, string prenume, int varsta, string adresa, string tel, string email, bool internat, string cnp_medic)
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                //db.Database.Connection.Open();
                //pentru ca inseram in 2 tabele facem o tranzactie
                //using (var dbContextTransaction = db.Database.Connection.BeginTransaction())
                //{
                    try
                    {
                        var pacient = new Data_Layer.Pacienti()
                        {
                            CNP = cnp,
                            Nume = nume,
                            Prenume = prenume,
                            Varsta = varsta,
                            Adresa = adresa,
                            Telefon = tel,
                            Email = email,
                            Internat = internat
                        };

                        db.Pacientis.Add(pacient);
                        db.SaveChanges();

                        //facem insert si in tabelul de internari_externari

                        var id_sectie = db.Personals.Where(p => p.CNP.Equals(cnp_medic)).Select(s => s.IDSectie).First();

                        db.Insert_Internari_Externari(cnp, cnp_medic, DateTime.Now, id_sectie);
                        db.SaveChanges();
              
                        
                        //dbContextTransaction.Commit();

                        return true;
                    }
                    catch (Exception ex)
                    {
                       // Console.WriteLine(ex.Message.ToString());
                        //dbContextTransaction.Rollback();
                        return false;
                    }
               // }
            }
        }

        public Guid insert_Diagnostic(string cnp_pacient, string nume)
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                //id-ul ultimei internari
                var id_inreg = db.Internari_Externari
                    .Where(i => i.CNP.Equals(cnp_pacient))
                    .Select(i => i.IDInreg).First();

                var check = db.Diagnostics.Where(d => d.Nume.Equals(nume) && d.IDInreg.Equals(id_inreg)).Count();

                //pacientul nu a fost inreg cu acest diagnostic
                if (check == 0)
                {
                    db.Insert_Diagnostic(id_inreg, nume);
                    db.SaveChanges();
                }

                var diag = db.Diagnostics.Where(d => d.Nume.Equals(nume) && d.IDInreg.Equals(id_inreg)).First();

                return diag.IDDiagnostic;
         

            }
        }

        //nu faceti insert in Tratament --deocamdata da eroare
        public bool insert_Tratament(Guid id_diagnostic, string med, string mod_admin)
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                
                    var id_mod = db.Mod_Administarea
                        .Where(m => m.Mod.Equals(mod_admin)).
                        Select(m => m.IDMod).First();

                    Data_Layer.Tratament tratament = new Data_Layer.Tratament()
                    {
                        IDTratament = Guid.NewGuid(),
                        IDDiagnostic = id_diagnostic,
                        Medicament = med,
                        IDMod = id_mod
                    };
                 db.Trataments.Add(tratament);
                  db.SaveChanges();
               
                    return true;
              
               
            }
        }

        public string get_UserName(string cnp)
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var user = db.Personals.Where(u => u.CNP.Equals(cnp)).First();

                return user.Prenume;
            }
        }

        public List<string> get_ListaMedici()
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var medici = db.Personals
                            .Where(m => m.IDCateg == 2);

                List<string> list = new List<string>();

                foreach (var item in medici)
                    list.Add(item.Nume.TrimEnd() + " " + item.Prenume.TrimEnd());

                return list;

            }
        }
        public List<string> get_ListaSectii()
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var sectii = from s in db.Sectiis
                             select s;


                List<string> list = new List<string>();

                foreach (var item in sectii)
                    list.Add(item.Nume.TrimEnd());

                return list;

            }
        }
        //lista diagnostice
        public List<string> get_Listadiag()
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var diagnostice = from d in db.Diagnostics
                             select d;


                List<string> list = new List<string>();

                foreach (var item in diagnostice)
                    list.Add(item.Nume.TrimEnd());

                return list;

            }
        }
        public List<string> get_ListaMod_Administare()
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var mod = from m in db.Mod_Administarea
                          select m.Mod;


                List<string> list = new List<string>();

                foreach (var item in mod)
                    list.Add(item.TrimEnd());

                return list;

            }
        }

        public List<string> get_ListaDataInternare()
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var dates = from r in db.Internari_Externari
                            select r.Data_internare;


                List<string> list = new List<string>();

                foreach (var item in dates)
                    list.Add(item.ToString());

                return list;

            }
 
        }
        //lista categorii
        public List<string> get_ListaCategorii()
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var categorii = from c in db.Categories
                                select c;
                List<string> list = new List<string>();
                foreach (var item in categorii)
                    list.Add(item.Nume.TrimEnd());
                return list;
            }
        }

        //id categorie
        public int get_idcateg(string categorie)
        {
            int id = 0;

            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var categ = from c in db.Categories
                            select c;

                foreach (var item in categ)
                {
                    if (item.Nume.TrimEnd() == categorie)
                        id = item.IDCateg;

                }

                return id;
            }

        }

        //id sectie
        public int get_idsectie(string sectie)
        {
            int id = 0;

            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var sectii = from s in db.Sectiis
                             select s;

                foreach (var item in sectii)
                {
                    if (item.Nume.TrimEnd() == sectie)
                        id = item.IDSectie;

                }

                return id;
            }
        }

        /// tabela Personal
        public DataTable table_Personal()
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {

                var personals = from p in db.Personals
                                select p;
                DataTable result = new DataTable();
                result.Columns.Add("CNP", typeof(string));
                result.Columns.Add("IDCateg", typeof(Int32));
                result.Columns.Add("Nume", typeof(string));
                result.Columns.Add("Prenume", typeof(string));
                result.Columns.Add("Adresa", typeof(string)).AllowDBNull = true;
                result.Columns.Add("Telefon", typeof(string)).AllowDBNull = true;
                result.Columns.Add("IDSectie", typeof(Int32));
                result.Columns.Add("Data_angajare", typeof(DateTime));
                DataColumn col = new DataColumn("Data_incheiere");
                col.DataType = typeof(string);
                col.AllowDBNull = true;
                result.Columns.Add(col);
                result.Columns.Add("Salariu", typeof(float)).AllowDBNull = true;


                foreach (var item in personals)
                {
                    DataRow row = result.NewRow();

                    row["CNP"] = item.CNP;
                    row["IDCateg"] = item.IDCateg;
                    row["Nume"] = item.Nume;
                    row["Prenume"] = item.Prenume;
                    row["Adresa"] = item.Adresa;
                    row["Telefon"] = item.Telefon;
                    row["IDSectie"] = item.IDSectie;
                    row["Data_angajare"] = item.Data_angajare;
                    row["Data_incheiere"] = item.Data_incheiere;
                    row["Salariu"] = item.Salariu;

                    result.Rows.Add(row);
                }

                return result;
            }

        }
        //tabela Administrare
        public DataTable table_Administrare(string CNP)
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {


                var operatie = from o in db.Administrares
                               where o.CNP_personal == CNP
                               select o;
                Guid aux;
               
                DataTable result = new DataTable();
               result.Columns.Add("Nume_Pacient", typeof(string));
                result.Columns.Add("Data_ora", typeof(DateTime));
                result.Columns.Add("Medicament", typeof(string));
               
                foreach (var item in operatie)
                { DataRow row = result.NewRow();
                    //caut medicamentul
                    var med = from m in db.Trataments
                              join e in db.Administrares on m.IDTratament equals e.IDTratament
                              where e.IDTratament == item.IDTratament 
                              select new { me = m.Medicament };
                    //caut pacientul
                    var iddiag = from d in db.Diagnostics
                                 join e in db.Trataments on d.IDDiagnostic equals e.IDDiagnostic
                                 where e.IDTratament == item.IDTratament
                                 select new { inreg=d.IDInreg};
                    foreach (var ite in iddiag)
                    {
                        var cnp = from i in db.Internari_Externari
                                  join e in db.Diagnostics on i.IDInreg equals e.IDInreg
                                  where e.IDInreg==ite.inreg
                                  select new { cn=i.CNP};
                        foreach (var c in cnp)
                            row["Nume_Pacient"] = c.cn;
                         
                    }
                 //   medicament = med.ToString();

                   
                    foreach(var it in med)
                    row["Medicament"] = it.me;
                    row["Data_ora"] = item.Data_ora;
                   
                    result.Rows.Add(row);
                }

                return result;
            }

        }

        public DataTable get_Pacienti(string cnp)
        {
            //creaza un tabel cu toti pacientii internati pe sectia userului

            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var id_sectie = db.Personals.Where(p => p.CNP.Equals(cnp))
                                 .Select(p => p.IDSectie).First();

                var pacienti = from p in db.Pacientis
                               join i in db.Internari_Externari on p.CNP equals i.CNP
                               where i.IDSectie == id_sectie
                               where p.Internat == true
                               select p;

                DataTable result = new DataTable();
                result.Columns.Add("CNP", typeof(string));
                result.Columns.Add("Nume", typeof(string));
                result.Columns.Add("Prenume", typeof(string));
                result.Columns.Add("Telefon", typeof(string));
                result.Columns.Add("Varsta", typeof(int));
                result.Columns.Add("Email", typeof(string));


                foreach (var item in pacienti)
                {
                    DataRow row = result.NewRow();
                    row["CNP"] = item.CNP;
                    row["Nume"] = item.Nume;
                    row["Prenume"] = item.Prenume;
                    row["Telefon"] = item.Telefon;
                    row["Varsta"] = item.Varsta;
                    row["Email"] = item.Email;

                    result.Rows.Add(row);
                }

                return result;


            }
        }

        public DataTable get_detalii_pacient(string cnp) 
        {
            // populare tabela diagnostic pacienti
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var id_inreg = db.Internari_Externari.Where(p => p.CNP.Equals(cnp) && p.Data_externare.Equals(null)).Select(p => p.IDInreg).First();
                
                var detalii = from p in db.Diagnostics
                              where p.IDInreg==id_inreg
                              select p;
                DataTable result = new DataTable();
                result.Columns.Add("Diagnostic", typeof(string));


                foreach (var item in detalii)
                {
                    DataRow row = result.NewRow();
                    row["Diagnostic"] = item.Nume;
                    result.Rows.Add(row);
                }

                return result;
            }

        }

        public string GetAdresaPacient(string cnp)
        {
           using (var db = new Data_Layer.Aplicatie_medicalaContext())
           {
               var result = db.Pacientis.Where(p=> p.CNP.Equals(cnp)).Select(p=>p.Adresa).First();

               return result;
           }
           
        }
        public bool Update_internari_externari(string cnp, DateTime externare)
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                
                
                if (db.SaveChanges() > 0)
                    return true;



            }
            return false;
        }

    }
}
