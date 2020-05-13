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
    public partial class frmDidnotSalary : Form
    {
        public frmDidnotSalary()
        {
            InitializeComponent();
        }

        private void frmDidnotSalary_Load(object sender, EventArgs e)
        {
            using (OurModel.CompanyEntities entities = new OurModel.CompanyEntities())
            {
                comboBox1.DataSource = entities.Banks.ToList();
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Name";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAL.Reports report = new BAL.Reports();
            int Id = Convert.ToInt32(comboBox1.SelectedValue);
          DataTable table =  report.SelectEmployeesDontNotResiveSalary(Id);
            Reports.Employeesnot not = new Reports.Employeesnot();
            not.SetDataSource(table);
            crystalReportViewer1.ReportSource = not;

            
        }
    }
}
