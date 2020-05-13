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

namespace PayrollApplication.ReportsForms
{
    public partial class frmInsuranceReport : Form
    {
        public frmInsuranceReport()
        {
            InitializeComponent();
        }

        private void frmInsuranceReport_Load(object sender, EventArgs e)
        {
            OurModel.CompanyEntities entities = new OurModel.CompanyEntities();
          comboBox1.DataSource =  entities.Banks.ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";


           

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            BAL.Reports rep = new BAL.Reports();
            int i = Convert.ToInt32(comboBox1.SelectedValue);
            DataTable table = rep.SelectInsuranceReport(i);
            Reports.InsuranceReport report = new Reports.InsuranceReport();
            report.SetDataSource(table);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
