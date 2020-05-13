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
    public partial class FrmSalaryInformation : Form
    {
        int _empid, _bankid;
     
        public FrmSalaryInformation(int EmpID , int BankID)
        {
            _empid = EmpID;
            _bankid = BankID;
            InitializeComponent();
        }

        private void FrmSalaryInformation_Load(object sender, EventArgs e)
        {
            Reports.SalaryInformation info = new Reports.SalaryInformation();
            BAL.Reports repots = new BAL.Reports();

            info.SetDataSource(repots.SalaryinfoReport(_empid, _bankid));
            crystalReportViewer1.ReportSource = info;
            crystalReportViewer1.Refresh();


        }
    }
}
