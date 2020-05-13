using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataLayer;
using System.Configuration;
using System.Data.SqlClient;

namespace BAL
{
   public class Sanction:IDisposable
    {
        public int ID { get; set; }
        public string SanctionName { get; set; }
        public string Sanction_Description { get; set; }
        

        public  bool Add_Sanction(Sanction sanction)
        {
            try
            {
                if (string.IsNullOrEmpty(sanction.SanctionName) || string.IsNullOrEmpty(sanction.Sanction_Description))
                {
                    throw new Exception("قم بأدخال البيانات كاملة");
                }
                using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    SqlParameter[] parm = new SqlParameter[2];
                    parm[0] = new SqlParameter("@SanctionName", sanction.SanctionName);
                    parm[1] = new SqlParameter("@SanctionDescription", sanction.Sanction_Description);
                    int result = (int)my.MyMethod("sp_AddSanction", parm, TypeStatment.UpdateOrDeleteOrInsert);
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public bool Edit_Sanction(Sanction sanction)
        {
            try
            {
                if (string.IsNullOrEmpty(sanction.SanctionName) || string.IsNullOrEmpty(sanction.Sanction_Description) || string.IsNullOrEmpty(sanction.ID.ToString()))
                {
                    throw new Exception("قم بأدخال البيانات كاملة");
                }
                using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    SqlParameter[] parameter = new SqlParameter[3];
                    parameter[0] = new SqlParameter("@SanctionID", sanction.ID);
                    parameter[1] = new SqlParameter("@SanctionName", sanction.SanctionName);
                    parameter[2] = new SqlParameter("@SanctionDescription", sanction.Sanction_Description);

                    int result = (int)my.MyMethod("sp_EditSanction", parameter, TypeStatment.UpdateOrDeleteOrInsert);
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete_Sanction(Sanction sanction)
        {
            try
            {
                if (string.IsNullOrEmpty(sanction.ID.ToString()))
                {
                    throw new Exception("يوجد خطاء في اختيار");
                }
                using (MyData my = new MyData(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    SqlParameter[] parameter = new SqlParameter[1];
                    parameter[0] = new SqlParameter("@ID", sanction.ID);
                    int result = (int)my.MyMethod("sp_Delete_Sanctions", parameter, TypeStatment.UpdateOrDeleteOrInsert);
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
