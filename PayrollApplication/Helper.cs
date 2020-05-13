using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace PayrollApplication
{
  static class Helper
    {

        public static  void EraseAllText(Form frm)
        {
            foreach (Control item in frm.Controls)
            {
                if( item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        public static byte[] ConvertImage(string path)
        {
        
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(file);
            byte[] array = reader.ReadBytes(Convert.ToInt32(file.Length));
            reader.Close();
            file.Close();
             return array;
           

         
        }

       public static void  MakeItEmpty(GroupBox box)
        {
            foreach (var item in box.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }


            }
        }
        public static void MakeDataGridViewEmpty(DataGridView view)
        {
            view.Rows.Clear();
        }
       
    }
}
