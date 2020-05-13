using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollApplication.ReportsForms
{
    public partial class SalaryEmployeesInformation : Form
    {
        public SalaryEmployeesInformation()
        {
            InitializeComponent();
        }
        OurModel.Employee emp;
        private void SalaryEmployeesInformation_Load(object sender, EventArgs e)
        {
            using (OurModel.CompanyEntities entities = new OurModel.CompanyEntities())
            {
                comboBox1.DataSource = entities.Banks.ToList();
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Name";
            }


            txtsearch.AutoCompleteCustomSource = collection();



        }
        public AutoCompleteStringCollection collection()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            BAL.Context context = new BAL.Context();
            foreach (var item in context.Employees)
            {
                collection.Add(item.Name);

            }
            return collection;
           
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OurModel.CompanyEntities entities = new OurModel.CompanyEntities();
           emp= entities.Employees.SingleOrDefault(a => a.Name == txtsearch.Text);
            ImageConverter converter = new ImageConverter();
         pictureBox1.Image =(Image)  converter.ConvertFrom(emp.Picture);
            txtname.Text = emp.Name;
            
            txtbirth.Text = emp.DateOFBirth.Value.ToLongDateString();
            txtnumberemp.Text = emp.EmployeeNumber.Value.ToString();




        }

        private void btn2ndSearch_Click(object sender, EventArgs e)
        {
            if(emp !=null)
                {
                BAL.Reports rp = new BAL.Reports();
                int empid = Convert.ToInt32(emp.ID);
                int bankid = Convert.ToInt32(comboBox1.SelectedValue);
                dataGridView1.DataSource = rp.SalaryinfoReport(empid, bankid);
                dataGridView2.DataSource = rp.AddSalaryReport(empid, bankid);
                dataGridView3.DataSource = rp.SubtrackSalary(empid, bankid);
            }
            else 
            {
                MessageBox.Show("Select Employess ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            FrmSalaryInformation frm = new FrmSalaryInformation(emp.ID, Convert.ToInt32(comboBox1.SelectedValue));
            frm.ShowDialog();

        }
    }
}
