using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_medicala
{
 public partial   class DataLayer
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
    }
}
