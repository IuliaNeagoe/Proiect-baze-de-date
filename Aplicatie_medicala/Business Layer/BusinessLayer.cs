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

      public bool insert_Pacient(string cnp, string nume, string prenume, string varsta, string adresa, string tel, string email, bool internat, string cnp_medic)
      {
          if (cnp == "" || nume == "" || prenume == "")
              return false;
          int age=0;

          if (varsta=="")
            age=0;
          else
              age=Convert.ToInt32(varsta);

          if (adresa == "")
              adresa = null;
          if (tel == "")
              tel = null;
          if (email == "")
              email = null;

          return objdl.insert_Pacient(cnp, nume, prenume, age, adresa, tel, email,internat, cnp_medic);
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

     public List<string> get_ListaDataInternare()
     {
         return objdl.get_ListaDataInternare();
     }

     public List<string> get_ListaCategorii()
     {
         return objdl.get_ListaCategorii();
     }

     public List<string> get_ListaModAdministrare()
     {
         return objdl.get_ListaMod_Administare();
     }
     public List<string> get_Listadiag()
     {
         return objdl.get_Listadiag();
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

     public DataTable table_Administrare(string CNP)
     {
         return objdl.table_Administrare(CNP);

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

     public bool insert_Diagnostic_Tratament(string diagnostic, string tratament, string cnp_pacient, string mod)
     {
         Guid id_diag = objdl.insert_Diagnostic(cnp_pacient, diagnostic);
         return objdl.insert_Tratament(id_diag, tratament, mod);
     }
    }
}
