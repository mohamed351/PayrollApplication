using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataLayer;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace BAL
{
   public class EmployeesLogin:IDisposable
    {
        public int ID { get; set; }
        public int EmployeesID { get; set; }

        public Employee Login(string username, string password)
        {
            using (Employee employee = new Employee())
            {
                using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    using (EncryptionAndDescrption e = new EncryptionAndDescrption())
                    {
                        SqlParameter[] par = new SqlParameter[2];

                        par[0] = new SqlParameter("@username", username);
                        par[1] = new SqlParameter("@password", e.Encryption(password));
                        DataTable table = (DataTable)my.MyMethod("sp_Login_Employees", par, TypeStatment.Select);
                        if (table.Rows.Count <= 0)
                        {
                            return null;
                        }
                        foreach (DataRow item in table.Rows)
                        {
                            employee.ID = Convert.ToInt32(item["ID"]);
                            employee.Name = item["Name"].ToString();
                            employee.EmployeeNumber = item["EmployeeNumber"].ToString();
                            break;
                        }
                    }


                }
                return employee;
            }
           
        }

        public DataTable EmployeesThatHavePermission()
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
              return (DataTable)  my.MyMethod("sp_Select_Employees_HaveLogin", null, TypeStatment.Select);
            }

          
        }
        public bool InsertLogin(int ID)
        {
            
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@ID",ID);
              int rows =(int)my.MyMethod("sp_Insert_Login", parameter, TypeStatment.UpdateOrDeleteOrInsert);
                if(rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public  bool DeleteLogin(int ID)
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
                SqlParameter[] parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@ID", ID);
                int rows = (int)my.MyMethod("sp_Delete_Login", parameter, TypeStatment.UpdateOrDeleteOrInsert);
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
