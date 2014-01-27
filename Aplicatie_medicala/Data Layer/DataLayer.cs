﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Aplicatie_medicala
{
 public partial class DataLayer
    {
        public Boolean get(string uname,string pass)
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

      //pentru moment nu merge properly....ma mai ocup de ea in alta zi
        public bool insert_Personal(string cnp, string categ, string nume, string prenume, string adresa, string tel, string sectie, DateTime data_ang, DateTime data_inc, float salariu, string parola)
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
            {
                var id_categ = db.Categories.Where(c => c.Nume.Equals(categ)).Select(c=> c.IDCateg).First();
                var id_sectie = db.Sectiis.Where(s => s.Nume.Equals(sectie)).Select(s=> s.IDSectie).First();

                db.insert_Personal(cnp, nume, prenume, tel, adresa, data_ang, data_inc, parola, id_categ, id_sectie, salariu);
                db.SaveChanges();
            }

            return false;
        }

        public bool insert_Pacient(string cnp, string nume, string prenume, int varsta, string adresa, string tel, string email)
        {
            using (var db = new Data_Layer.Aplicatie_medicalaContext())
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
                    Internat = true
                };

                db.Pacientis.Add(pacient);
                db.SaveChanges();
                return true;

            }
        }

      public  string get_UserName(string cnp)
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
                          .Where(m => m.IDCateg==2);

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

      public DataTable get_Pacienti(string cnp)
      {
          //creaza un tabel cu toti pacientii internati pe sectia userului
          
          using (var db=new Data_Layer.Aplicatie_medicalaContext())
          {
              var id_sectie = db.Personals.Where(p => p.CNP.Equals(cnp))
                               .Select(p => p.IDSectie).First();

              var pacienti = from p in db.Pacientis
                                              join i in db.Internari_Externari on p.CNP equals i.CNP
                                              where i.IDSectie == id_sectie
                                              where p.Internat==true
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
                  row["Varsta"]=item.Varsta;
                  row["Email"]=item.Email;

                  result.Rows.Add(row);
              }

              return result;
            

          }
      }



    }
}
