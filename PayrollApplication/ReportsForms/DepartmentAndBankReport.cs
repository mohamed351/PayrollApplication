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
    public partial class DepartmentAndBankReport : Form
    {
        public DepartmentAndBankReport()
        {
            InitializeComponent();
        }

        private void DepartmentAndBankReport_Load(object sender, EventArgs e)
        {
            using (OurModel.CompanyEntities entities = new OurModel.CompanyEntities())
            {
                comboAccountName.DataSource = entities.Banks.ToList();
                comboAccountName.ValueMember = "ID";
                comboAccountName.DisplayMember = "Name";
            }
            using (OurModel.CompanyEntities entity = new OurModel.CompanyEntities())
            {
              comboDepartment.DataSource =  entity.Departments.ToList();
                comboDepartment.ValueMember = "ID";
                comboDepartment.DisplayMember = "DepartmentName";

               
                
            }
          
              
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            BAL.Reports report = new BAL.Reports();
          DataTable table=  report.SelectDepartmentEmployees(Convert.ToInt32(comboAccountName.SelectedValue), Convert.ToInt32(comboDepartment.SelectedValue));
            using (Reports.EmployeesDepartmentReport rep = new Reports.EmployeesDepartmentReport())
            {
                rep.SetDataSource(table);
                crystalReportViewer1.ReportSource = rep;
                crystalReportViewer1.Refresh();
            }
            
        }
    }
}
