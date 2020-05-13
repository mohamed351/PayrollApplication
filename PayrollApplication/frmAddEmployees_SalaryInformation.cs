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

namespace PayrollApplication
{
    public partial class frmAddEmployees_SalaryInformation : Form
    {
        public int EmpID { get; set; }
        public string empName { get; set; }
        public double Salary { get; set; }
        public decimal InsurancePercent { get; set; }
        public decimal InsuranceValue { get; set; }
        public int idaccount { get; set; }
        public string AccountName { get; set; }
        public frmAddEmployees_SalaryInformation()
        {
            InitializeComponent();
        }

        private void frmAddEmployees_SalaryInformation_Load(object sender, EventArgs e)
        {
            OurModel.CompanyEntities company = new OurModel.CompanyEntities();
            comboAccout.DataSource = company.Banks.ToList();
            comboAccout.DisplayMember = "Name";
            comboAccout.ValueMember = "ID";

            foreach (var item in company.Employees)
            {
                Search.AutoCompleteCustomSource.Add(item.Name);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OurModel.CompanyEntities company = new OurModel.CompanyEntities();
            string seach = Search.Text;
            OurModel.Employee employee =company.Employees.SingleOrDefault(a => a.Name== seach );
            string departmentName = company.Departments.SingleOrDefault(a => a.ID == employee.DepartmentID).DepartmentName;
           if(employee !=null)
            {
                txtname.Text = employee.Name;
                txtSalary.Text = employee.Salary.ToString();
                txtjobname.Text = employee.JobTitle.Name;
                ID.Text = employee.ID.ToString();
                txtDepartment.Text = departmentName;
                ImageConverter converter = new ImageConverter();
                pictureBox1.Image = (Image)converter.ConvertFrom(employee.Picture);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (TotalSalary sal = new TotalSalary())
            {
             if( ! sal.IsAddORNot(Convert.ToInt32(ID.Text), Convert.ToInt32(comboAccout.SelectedValue)))
                {

                   
                }
             else
                {
                    this.DialogResult = DialogResult.None;
                    MessageBox.Show("لقد تم تسجيل هذا الموظف في هذا الشهر", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                   
                }


            }


                if (!string.IsNullOrWhiteSpace(ID.Text))
                {
                    OurModel.CompanyEntities entities = new OurModel.CompanyEntities();

                    EmpID = Convert.ToInt32(ID.Text);
                    empName = txtname.Text;
                    Salary = Convert.ToDouble(txtSalary.Text);
                    InsurancePercent = Convert.ToDecimal(txtInsurancepersent.Text);
                    InsuranceValue = Convert.ToDecimal(txtinsurancevalues.Text) * Convert.ToDecimal(0.14) * 12;
                    idaccount = Convert.ToInt32(comboAccout.SelectedValue);
                    AccountName = comboAccout.Text;


                }
                else
                {
                    this.DialogResult = DialogResult.None;
                }
           
        }
    }
}
