using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_medicala
{
  public partial  class BusinessLayer 
    {
      public DataLayer objdl = new DataLayer();
      
      public Boolean calllog(string unume,string pass)
      {

          return objdl.get(unume, pass);
      }

    }
}
