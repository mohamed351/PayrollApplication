using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using MaterialSkin.Controls;
namespace PayrollApplication
{
    public partial class FrmEmployeesAllInformations :MaterialSkin.Controls.MaterialForm
    {
        int id;
        public FrmEmployeesAllInformations(int ID)
        {
            id = ID;
            InitializeComponent();
        }

        private void FrmEmployeesAllInformations_Load(object sender, EventArgs e)
        {
            try
            {
                Employee emp;
                Department department;
                JobTitle job;
                using (Context context = new Context())
                {
                    emp = context.Employees.Single(a => a.ID == id);
                    department = context.Department.Single(a => a.ID == emp.DepartmentID);
                    job = context.JobTitles.Single(a => a.ID == emp.JobID);

                }
                ImageConverter converter = new ImageConverter();
                pictureBox1.Image = (Image)converter.ConvertFrom(emp.Picture);
                this.Text = emp.Name;
                txtname.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
                txtHireDate.Text = emp.HiredDate.ToShortDateString();
                txtjobname.Text = job.Name;
                txtMax.Text = job.RangMax.ToString();
                txtmin.Text = job.RangMin.ToString();
                txtbirthdate.Text = emp.DateOfBirth.ToShortDateString();
                txtdepartmentName.Text = department.DepartmentName;
                txtdescription.Text = department.Description;


            }
            catch
            {
                this.Close();
            }


          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
