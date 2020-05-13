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
using PayrollApplication.Reports;


namespace PayrollApplication
{
    public partial class DepartmentReport : Form
    {
        public DepartmentReport()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DepartmentReport_Load(object sender, EventArgs e)
        {
            using (OurModel.CompanyEntities entities = new OurModel.CompanyEntities())
            {
               
             comboBox1.DataSource=   entities.Banks.ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
            }


        }

        private void btnSelectReport_Click(object sender, EventArgs e)
        {
            BAL.Reports b = new BAL.Reports();
         DataTable table =(DataTable)   b.SelectDepartmentThroughBankID(Convert.ToInt32(comboBox1.SelectedValue));
            using (DepartmentSalaryReport report = new DepartmentSalaryReport())
            {
                report.SetDataSource(table);
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
           
            
        }
    }
}
