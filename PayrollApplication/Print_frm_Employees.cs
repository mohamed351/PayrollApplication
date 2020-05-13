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
    public partial class Print_frm_Employees : Form
    {
        public Print_frm_Employees()
        {
            InitializeComponent();
        }

        private void Print_frm_Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CompanyDataSet.vw_ShowEmployeesDetails' table. You can move, or remove it, as needed.
            this.vw_ShowEmployeesDetailsTableAdapter.Fill(this.CompanyDataSet.vw_ShowEmployeesDetails);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
