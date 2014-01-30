using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Aplicatie_medicala
{
  public partial  class BusinessLayer 
    {
      public DataLayer objdl = new DataLayer();
      
      public Boolean calllog(string unume,string pass)
      {

          return objdl.get(unume, pass);
      }

      public bool insert_Pacient(string cnp, string nume, string prenume, int varsta, string adresa, string tel, string email)
      {
          if (cnp == "" || nume == "" || prenume == "")
              return false;

          if (adresa == "")
              adresa = null;
          if (tel == "")
              tel = null;
          if (email == "")
              email = null;

          return objdl.insert_Pacient(cnp, nume, prenume, varsta, adresa, tel, email);
      }

     public string get_UserName(string cnp)
      {
          return objdl.get_UserName(cnp);
      }

     public List<string> get_ListaMedici()
     {
         return objdl.get_ListaMedici();
     }

     public List<string> get_ListaSectii()
     {
         return objdl.get_ListaSectii();
     }

     public List<string> get_ListaCategorii()
     {
         return objdl.get_ListaCategorii();
     }

     public bool insert_Personal(string cnp, string categ, string nume, string prenume, string adresa, string tel, string sectie, DateTime data_ang, DateTime data_inc, float salariu, string parola)
     {
         if (cnp == "" || categ == "" || nume == "" || prenume == "" || sectie == "")
             return false;

         if (adresa == "")
             adresa = null;
         if (tel == "")
             tel = null;
         if (data_ang.ToString() == "")
             data_ang = System.DateTime.Now;

       return  objdl.insert_Personal(cnp, categ, nume, prenume, adresa, tel, sectie, data_ang, data_inc, salariu, parola);
     }

     public DataTable get_Pacienti(string cnp)
     {
         return objdl.get_Pacienti(cnp);
     }

     public DataTable table_personal()
     {
         return
              objdl.table_Personal();
     }

     public int get_idcateg(string categorie)
     {
         return objdl.get_idcateg(categorie);
     }


     public int get_idsectie(string sectie)
     {
         return objdl.get_idsectie(sectie);
     }
     public DataTable get_detalii_pacient(string cnp)
     {
         return objdl.get_detalii_pacient(cnp);
     }
    }
}
