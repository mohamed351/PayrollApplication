using MyDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BAL
{
   public  class Attenance:IDisposable
    {
        public int ID { get; set; }
        public int EmployeesID { get; set; }
        public int AttendID { get; set; }
        public DateTime AttendTime { get; set; }
        public DateTime LeaveTime { get; set; }

        public DataTable SelectInformation(string yearNumber , string monthNumber ,string DayNumber )
        {
            MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            SqlParameter[] parameter = new SqlParameter[3];
            parameter[0] = new SqlParameter("@year", yearNumber);
            parameter[1] = new SqlParameter("@month", monthNumber);
            parameter[2] = new SqlParameter("@Day", DayNumber);
          return (DataTable)  my.MyMethod("sp_GetAttendance", parameter, TypeStatment.Select);
        }
        public DataTable SelectDaysLabor()
        {
            MyData myData = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
          return(DataTable)  myData.MyMethod("select * from AttendanceDays", TypeStatment.Select);
        }
        public DataTable Get_AllAttendTime(int IDAttendTime)
        {
            MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@AtdID", IDAttendTime);
          return(DataTable)  my.MyMethod("Sp_Employee_Attend", parameter,TypeStatment.Select);
           
        }

        public bool Attend(int ID)
        {
            MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@EmployeesID",ID);

            int row = (int)my.MyMethod("sp_EmployeesAttend", parameter, TypeStatment.UpdateOrDeleteOrInsert);
          if(row <=0)
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

        public bool Leave(int ID)
        {
            MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@EmployeesID", ID);
            int row = (int)my.MyMethod("sp_EmployeesLeave", parameter, TypeStatment.UpdateOrDeleteOrInsert);
            if(row <=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       
    }
}
