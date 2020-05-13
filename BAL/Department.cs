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
    public class Department:IDisposable
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public int ManagerID { get; set; }
        /// <summary>
        ///  اضافة قسم جديد
        /// </summary>
        /// <param name="department"> بيانات القسم</param>
        /// <returns> هل تم اضافة القسم ام لا </returns>
        public bool AddDepartment(Department department)
        {
            //لو فية حد سايب حاجة فاضية يرمي اكسبشن
            if(string.IsNullOrEmpty(department.DepartmentName) || string.IsNullOrEmpty(department.Description))
            {
                throw new Exception(" من فضلك أدخل البيانات كاملة ");
            }
            try
            {
                //دي بقا الداتا لير لي احنا عملنها
                MyData myData = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                //دي بقا البراميتر
                SqlParameter[] parameter = new SqlParameter[3];
                parameter[0] = new SqlParameter("@DepartmentName", department.DepartmentName);
                parameter[1] = new SqlParameter("@Description", department.Description);
                parameter[2] = new SqlParameter("@ManagerID", department.ManagerID);
                // دي الأستورد بروسيجر
                int x = (int)myData.MyMethod("sp_AddDepartment", parameter, TypeStatment.UpdateOrDeleteOrInsert);
                if (x > 0)
                {
                    // لو اكبر من الصفر هيطلع الحاجة صح لي هي عدد التغيرات في قاعدة البيانات
                    return true;
                }
                else
                {
                    // لو اقل من الصفر لي هي عدد التغيرات الموجودة 
                    return false;
                }
            }
            catch(Exception ex)
            {
                // ارمي اكسبشن لو حاجة حصلت عشان اعرف الأكسبشن دا ايه النحية التانية 
                throw ex;
                
            }
        }
        public void Dispose()
        {
            GC.Collect();
        }
        /// <summary>
        /// لتعديل بيانات الأقسام
        /// </summary>
        /// <param name="department"> بيانات القسم </param>
        /// <returns>هل تمت العمية ام لا</returns>
        public bool EditDepartment(Department department)
        {
            if((string.IsNullOrEmpty(department.ID.ToString())) ||(string.IsNullOrEmpty(department.DepartmentName)) || string.IsNullOrEmpty(department.Description))
            {

                throw new Exception("قم بادخال البيانات كاملة");

            }
            try
            {
                MyData data = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                SqlParameter[] parameter = new SqlParameter[4];
                parameter[0] = new SqlParameter("@ID", department.ID);
                parameter[1] = new SqlParameter("@DepartmentName", department.DepartmentName);
                parameter[2] = new SqlParameter("@Description", department.Description);
                parameter[3] = new SqlParameter("@ManagerID", department.ManagerID);
                int result = (int)data.MyMethod("sp_EditDepartment", parameter, TypeStatment.UpdateOrDeleteOrInsert);
                if (result < 0)
                {
                    return false;
                }
                else
                {

                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// لجعل القسم غير مرئي  تم الفاءة بنسة لموظفين لكن ليس بنسبة لقاعدة البيانات
        /// </summary>
        /// <param name="department"></param>
        /// <returns>هل تمت العملية ام لا لا</returns>
        public bool UnFlagDepartment(Department department)
        {
            if(string.IsNullOrEmpty(department.ID.ToString()))
            {
                throw new Exception("قم بأختيار الموظف من فضلك ");
            }
            try
            {
                MyData data = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                SqlParameter[] parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@ID", department.ID);
             int result =(int)  data.MyMethod("sp_UnFlagDepartment", parameter, TypeStatment.UpdateOrDeleteOrInsert);
                if(result<0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
               
            }
            catch(Exception ex)
            {
                throw ex;
            }


        }
        /// <summary>
        /// استرجاع البيانات بسبة لعميل 
        /// </summary>
        /// <param name="department"></param>
        /// <returns> هل تمت العملية ام لا </returns>
        public bool FlagDepartment(Department department)
        {
            if (string.IsNullOrEmpty(department.ID.ToString()))
            {
                throw new Exception("قم بأختيار الموظف من فضلك ");
            }
            try
            {
                MyData data = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                SqlParameter[] parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@ID", department.ID);
                int result = (int)data.MyMethod("sp_FlagDepartment", parameter, TypeStatment.UpdateOrDeleteOrInsert);
                if (result < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable SelectDepartmentWithManager()
        {
            using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            {
            return (DataTable) my.MyMethod("sp_select_Department_and_Manager", null, TypeStatment.Select);
            }

        }
        
        
    }
}
