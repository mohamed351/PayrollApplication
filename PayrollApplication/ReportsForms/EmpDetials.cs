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
    public partial class EmpDetials : Form
    {
        int _id;
        public EmpDetials(int ID)
        {
            InitializeComponent();
            _id = ID;
        }
      
       
        private void EmpDetials_Load(object sender, EventArgs e)
        {

          

            using (BAL.Reports n = new BAL.Reports())
                {
                Reports.EmpDetialsReport report = new Reports.EmpDetialsReport();
                

                    DataTable table = n.SelectEmployeeID(_id);
                    report.SetDataSource(table);
                    crystalReportViewer1.ReportSource = report;
                    crystalReportViewer1.Refresh();
                    crystalReportViewer1.ReportRefresh += CrystalReportViewer1_ReportRefresh;
                    Reports.CachedEmpDetialsReport cached = new Reports.CachedEmpDetialsReport();
                    cached.Dispose();
                   

               }

               
          
        }

        private void CrystalReportViewer1_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
