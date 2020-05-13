using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollApplication
{
    public partial class EmployeesReport : Form
    {
        public EmployeesReport()
        {
            InitializeComponent();
        }

        private void EmployeesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CompanyDataSet.Employees' table. You can move, or remove it, as needed.
            this.EmployeesTableAdapter.Fill(this.CompanyDataSet.Employees);

            this.reportViewer1.RefreshReport();
        }
    }
}
