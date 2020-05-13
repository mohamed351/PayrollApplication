using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyDataLayer;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace BAL
{
   public class Employee:IDisposable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmployeeNumber { get; set; }
        public double Salary { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte[] Picture { get; set; }
        public bool IsActive { get; set; }
        public string username { get; set; }
        public int DepartmentID { get; set; }
        public string password { get; set; }
        public string MaritalStatus { get; set; }
        public string Geneder { get; set; }
        public int JobID { get; set; }
        public int FingerPrintNumber { get; set; }

        public void Dispose()
        {
            GC.Collect();
        }

        public bool InsertEmployees(Employee employee)
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] par = new SqlParameter[11];
                par[0] = new SqlParameter("@Name", employee.Name);
                par[1] = new SqlParameter("@Salary", employee.Salary);
                par[2] = new SqlParameter("@HireDate", employee.HiredDate.ToShortDateString());
                par[3] = new SqlParameter("@DateOFBith", employee.DateOfBirth.ToShortDateString());
                par[4] = new SqlParameter("@picture", employee.Picture);
                par[5] = new SqlParameter("@Marital_status", employee.MaritalStatus);
                par[6] = new SqlParameter("@Geneder", employee.Geneder);
                par[7] = new SqlParameter("@username", employee.username);
                par[8] = new SqlParameter("@password", employee.password);
                par[9] = new SqlParameter("@JobID", employee.JobID);
                par[10] = new SqlParameter("@DepartmentNumber", employee.DepartmentID);
                int result = (int)my.MyMethod("sp_InsertEmployees", par, TypeStatment.UpdateOrDeleteOrInsert);
                if (result <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            
        }
       
        public DataTable SelectEmployeeInformations()
        {
            MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
          return (DataTable)  my.MyMethod("sp_Select_Employees1", null, TypeStatment.Select);
        }

        public bool EditEmployees(Employee employee)
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] par = new SqlParameter[12];
                par[0] = new SqlParameter("@Name", employee.Name);
                par[1] = new SqlParameter("@Salary", employee.Salary);
                par[2] = new SqlParameter("@HireDate", employee.HiredDate.ToShortDateString());
                par[3] = new SqlParameter("@DateOFBith", employee.DateOfBirth.ToShortDateString());
                par[4] = new SqlParameter("@picture", employee.Picture);
                par[5] = new SqlParameter("@Marital_status", employee.MaritalStatus);
                par[6] = new SqlParameter("@Geneder", employee.Geneder);
                par[7] = new SqlParameter("@username", employee.username);
                par[8] = new SqlParameter("@password", employee.password);
                par[9] = new SqlParameter("@JobID", employee.JobID);
                par[10] = new SqlParameter("@DepartmentNumber", employee.DepartmentID);
                par[11] = new SqlParameter("@ID", employee.ID);
                int result = (int)my.MyMethod("sp_EditEmployees", par, TypeStatment.UpdateOrDeleteOrInsert);
                if (result <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
        public DataTable SelectEmployees(string name)
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] par = new SqlParameter[1];
                par[0] = new SqlParameter("@Name", name);
             return (DataTable)   my.MyMethod("sp_Select_Employees2", par, TypeStatment.Select);
            }

        }


    }
}
