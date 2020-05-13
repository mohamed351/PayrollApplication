using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace PayrollApplication
{
    public partial class EditJobName : MaterialSkin.Controls.MaterialForm
    {
        public EditJobName(int ID , string name , double min , double max)
        {
            InitializeComponent();
            label4.Text = ID.ToString();
            txtname.Text = name;
            txtmin.Text = min.ToString();
            txtmax.Text = max.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OurModel.CompanyEntities entities = new OurModel.CompanyEntities();
            int i = Convert.ToInt32(label4.Text);
           OurModel.JobTitle title= entities.JobTitles.SingleOrDefault(a => a.ID == i);
            title.Name = txtname.Text;
            title.RangeMax = Convert.ToDecimal(txtmax.Text);
            title.RangeMin = Convert.ToDecimal(txtmin.Text);
            title.ISDelete = false;
          
           if ( entities.SaveChanges()>0)
            {
                MessageBox.Show("تم تغير بيانات اسم الوظيفة","معلومات",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}
