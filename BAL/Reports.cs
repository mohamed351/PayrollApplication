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
   public class Reports:IDisposable
    {
        public void Dispose()
        {
            GC.Collect();
        }

        public DataTable SelectDepartmentThroughBankID(int ID)
        {
            using (MyData data = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@BankID", ID);

              return (DataTable)  data.MyMethod("sp_Select_DepartmentSalaryReport", parameters, TypeStatment.Select);

            }

        }
        public DataTable SelectEmployeeID (int ID)
        {
            using (MyData data = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@EmpID", ID);

                return (DataTable)data.MyMethod("sp_reportemp", parameters, TypeStatment.Select);

            }
        }
        /// <summary>
        /// This is function helps you to Create Report Department and BankID
        /// </summary>
        /// <param name="BankID">BankID in month </param>
        /// <param name="DepartmentID">DepartmentID </param>
        /// <returns>DataTable For Report Department and Monthly Salary</returns>
        public DataTable SelectDepartmentEmployees(int BankID, int DepartmentID)
        {
            using (MyData layer = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@BankID", BankID);
                parameters[1] = new SqlParameter("@DepartmentID", DepartmentID);

                return (DataTable)layer.MyMethod("sp_Report_DepartmentBank", parameters, TypeStatment.Select);

            }

        }
        /// <summary>
        /// This is Function is Made to display Insuracne Report
        /// </summary>
        /// <returns>DataTable For Insurance</returns>
        public DataTable SelectInsuranceReport(int ID)
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@BankID", ID);
              return (DataTable)  my.MyMethod("sp_select_Report_Insurance", parameters, TypeStatment.Select);
            }
        }

        /// <summary>
        /// This is Method Returns Tax Information 
        /// </summary>
        /// <returns>DataTable That Containe The Tax Information</returns>
        public DataTable SelectTaxValue(int ID)
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@ID", ID);
                return (DataTable)my.MyMethod("sp_TaxInfoReport", parameter, TypeStatment.Select);

            }
        }

        public DataTable SelectEmployeesDontNotResiveSalary( int ID)
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@BankID", ID);
              return(DataTable)  my.MyMethod("sp_Employeesdontnot", parameters, TypeStatment.Select);
            }
        }


        public DataTable SalaryinfoReport(int ID , int BankID)
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@EmpID", ID);
                parameters[1] = new SqlParameter("@BankID", BankID);
             return (DataTable)my.MyMethod("Sp_SelectSalary_BankID", parameters, TypeStatment.Select);
            }
        }

        public DataTable AddSalaryReport(int ID , int BankID)
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@EmpID", ID);
                parameters[1] = new SqlParameter("@BankID", BankID);
                return (DataTable)my.MyMethod("sp_SelectAddSalayInfo", parameters, TypeStatment.Select);
            }
        }

        public DataTable SubtrackSalary(int ID , int BankID)
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@BankID", BankID);
                parameters[1] = new SqlParameter("@EmployeesID  ", ID);
                return (DataTable)my.MyMethod("Sp_SelectInformationSubTrackInfo", parameters, TypeStatment.Select);
            }
        }
    }
}
