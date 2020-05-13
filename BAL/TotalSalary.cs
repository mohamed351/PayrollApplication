using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataLayer;
using System.Data.SqlClient;

namespace BAL
{
   public class TotalSalary:IDisposable
    {

        DataTable _subtracktable;
        DataTable _addsalarytable;
        public int EmpID { get; set; }
        public DataTable subtracktable
        {
            get { return _subtracktable; }
            set { _subtracktable = value; }
        }
        public DataTable addsalarytable
        {
            get { return _addsalarytable; }
            set { _addsalarytable = value; }
        }
        public int BankID { get; set; }
        public decimal Salary { get; set; }
        public decimal AllSalary { get; set; }
        public string AccountName { get; set; }
        public decimal Insurance { get; set; }
        public decimal TaxValue { get; set; }
        public int TaxID { get; set; }

        MyData my;
        public TotalSalary( )
        {
            my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        }
        
        public bool SaveEmployeesData(TotalSalary total)
        {
            SqlParameter[] parameters = new SqlParameter[10];
            parameters[0] = new SqlParameter("@EmpID", total.EmpID);
            parameters[1] = new SqlParameter("@subtracktable", total.subtracktable);
            parameters[2] = new SqlParameter("@addsalarytable", total.addsalarytable);
            parameters[3] = new SqlParameter("@BankID", total.BankID);
            parameters[4] = new SqlParameter("@Salary", total.Salary);
            parameters[5] = new SqlParameter("@AllSalary", total.AllSalary);
            parameters[6] = new SqlParameter("@AccountName", total.AccountName);
            parameters[7] = new SqlParameter("@Insurance", total.Insurance);
            parameters[8] = new SqlParameter("@TaxValue", total.TaxValue);
            parameters[9] = new SqlParameter("@TaxID", total.TaxID);


      int rows= (int)   my.MyMethod("sp_AddMonthSalary", parameters, TypeStatment.UpdateOrDeleteOrInsert);
            if( rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public bool IsAddORNot (int EmployeesID , int BankID)
        {
            SqlParameter[] paramenter = new SqlParameter[2];
            paramenter[0] = new SqlParameter("@BankID", BankID);
            paramenter[1] = new SqlParameter("@EmpID", EmployeesID);
       DataTable table=(DataTable)  my.MyMethod("IFTakedSalay", paramenter, TypeStatment.Select);

            if(table.Rows.Count <=0)
            {
                return false;
            }
            else
            {
                return true;

            }

        }
        public void Dispose()
        {
            GC.Collect();
        }
    }
}
