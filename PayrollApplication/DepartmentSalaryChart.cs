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
    public partial class DepartmentSalaryChart : Form
    {
        public DepartmentSalaryChart()
        {
            InitializeComponent();
        }

        private void DepartmentSalaryChart_Load(object sender, EventArgs e)
        {
            OurModel.CompanyEntities entities = new OurModel.CompanyEntities();
          comboBox1.DataSource =  entities.Banks.ToList();
          
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAL.Reports s = new BAL.Reports();
            using (DataTable table = s.SelectDepartmentThroughBankID(Convert.ToInt32(comboBox1.SelectedValue)))
            {
                using (Reports.DepartmentSalaryChart chart = new Reports.DepartmentSalaryChart())
                {

                    chart.SetDataSource(table);
                    crystalReportViewer1.ReportSource = chart;
                    crystalReportViewer1.Refresh();
                }
              
            }
            
            
           

        }
    }
}
