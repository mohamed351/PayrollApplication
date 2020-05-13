using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataLayer;
using System.Configuration;
using System.Data;

namespace BAL
{
    public class Context : IDisposable
    {
        MyData _my;
        #region Constructor
        public Context()
        {
            _my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        }
        #endregion
        #region Fields
        List<Employee> _employees = new List<Employee>();
        List<Department> _department = new List<Department>();
        List<Sanction> _sanction = new List<Sanction>();
        List<JobTitle> _jobtitle = new List<JobTitle>();
        #endregion
        #region Properties
        public List<Employee> Employees
        {
            get { return SelectEmployees(); }

        }
        public List<Department> Department
        {
            get { return SelectDepartment(); }
        }
        public List<Sanction> Sentions
        {
            get { return SelectSanction(); }
        }
        public List<JobTitle> JobTitles
        {
            get { return SelectJobTitle(); }
        }
        public List<EmployeesLogin> EmployeesLogins
        {
            get { return SelectEmployeesLogin(); }
        }
        public List<Attenance> Attencess
        {
            get { return SelectAttenace(); }
        }



        #endregion
        #region Methods
        List<Department> SelectDepartment()
        {
            DataTable table = (DataTable)_my.MyMethod("sp_SelectDepartment", null, TypeStatment.Select);
            foreach (DataRow item in table.Rows)
            {
                _department.Add(new BAL.Department() { ID = Convert.ToInt32(item["ID"]), Description=item["Description"].ToString(),  DepartmentName = item["DepartmentName"].ToString() });
            }

            return _department;
        }
        List<Sanction> SelectSanction()
        {

            DataTable table = (DataTable)_my.MyMethod("sp_Select_Sanction", null, TypeStatment.Select);
            foreach (DataRow item in table.Rows)
            {
                _sanction.Add(new Sanction() { ID = Convert.ToInt32(item["ID"]), SanctionName = item["Sanction_Name"].ToString(), Sanction_Description = item["Sanction_Decription"].ToString() });

            }
            return _sanction;
        }

      List<JobTitle> SelectJobTitle()
        {
            List<JobTitle> list = new List<JobTitle>();
        DataTable table=(DataTable)  _my.MyMethod("sp_SelectJobTitle", null, TypeStatment.Select);
            foreach (DataRow item in table.Rows)
            {
                list.Add(new JobTitle() { ID = Convert.ToInt32(item["ID"]), Name = item["Name"].ToString(), RangMax = Convert.ToDouble(item["RangeMax"]), RangMin = Convert.ToDouble(item["RangeMin"]) });

            }
            return list;
        }

       List<Employee> SelectEmployees()
        {
            
            List<Employee> list = new List<Employee>();
          DataTable table= (DataTable)_my.MyMethod("sp_Select_Employees", null, TypeStatment.Select);
            foreach (DataRow item in table.Rows)
            {
                list.Add(new Employee() { ID = Convert.ToInt32(item["ID"]), Name = item["Name"].ToString(), EmployeeNumber = item["EmployeeNumber"].ToString(), DepartmentID = Convert.ToInt32(item["DepartmentID"]), JobID = Convert.ToInt32(item["JobID"])
                 , DateOfBirth = Convert.ToDateTime(item["DateOFBirth"]), HiredDate = Convert.ToDateTime(item["HireDate"]), Geneder = item["Gender"].ToString(),
                    MaritalStatus = item["Marital_status"].ToString(),Salary=Convert.ToDouble(item["Salary"].ToString()), Picture = ((byte[])item["Picture"]), username= item["username"].ToString(), password=item["password"].ToString(), FingerPrintNumber=Convert.ToInt32(item["FingerPrintNumber"]),IsActive= Convert.ToBoolean(item["ISActive"])
                });
            }
            return list;
        }

        List<EmployeesLogin> SelectEmployeesLogin()
        {
            List<EmployeesLogin> list = new List<EmployeesLogin>();
            DataTable table = (DataTable)_my.MyMethod("sp_select_Login_Employees", null, TypeStatment.Select);
            foreach (DataRow item in table.Rows)
            {
                list.Add(new EmployeesLogin() { ID = Convert.ToInt32(item["ID"]), EmployeesID = Convert.ToInt32(item["EmployeesID"]) });

            }
            return list;
        }

        List<Attenance> SelectAttenace()
        {
            List<Attenance> list = new List<Attenance>();
            DataTable table = (DataTable)_my.MyMethod("select * from AttendanceDays_Employees", TypeStatment.Select);
            foreach (DataRow item in table.Rows)
            {
                list.Add(new Attenance() { ID = Convert.ToInt32(item["ID"]), AttendID = Convert.ToInt32(item["AttendanceID"]), EmployeesID = Convert.ToInt32(item["EmployeeID"]), AttendTime = Convert.ToDateTime(item["AttendTime"]), LeaveTime = Convert.ToDateTime(item["LeaveTime"]) });
            }
            return list;
        }



        public void Dispose()
        {
            GC.Collect();
        }
        #endregion

    }
}
