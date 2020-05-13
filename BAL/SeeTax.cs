using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataLayer;

namespace BAL
{
  public  class SeeTax
    {

        public DataTable SeeInformation()
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                return (DataTable)my.MyMethod("select_Tax", null, TypeStatment.Select);
            }
        }
    }
}
