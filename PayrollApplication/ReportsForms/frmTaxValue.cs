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
    public partial class frmTaxValue : Form
    {
        public frmTaxValue()
        {
            InitializeComponent();
        }

        private void frmTaxValue_Load(object sender, EventArgs e)
        {
            OurModel.CompanyEntities entities = new OurModel.CompanyEntities();
          comboBox1.DataSource =  entities.Banks.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAL.Reports re = new BAL.Reports();
            int id = (int) comboBox1.SelectedValue;
            DataTable table = re.SelectTaxValue(id);
            Reports.TaxValueReport report = new Reports.TaxValueReport();
            report.SetDataSource(table);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
