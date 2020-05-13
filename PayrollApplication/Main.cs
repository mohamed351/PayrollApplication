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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void اضافةقسمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddDepartment frm = new AddDepartment())
            {
                frm.ShowDialog();
            }
        }

        private void تعديلالاقسامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EditDepartment frm = new EditDepartment())
            {
                frm.ShowDialog();
            }
        }

        private void مسحالأقسامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DeleteDepartment frm = new DeleteDepartment())
            {
                frm.ShowDialog();
            }
        }

        private void استرجاعالأقسامToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void موظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Employees employees = new Employees())
            {
                employees.ShowDialog();
            }
        }

        private void قائمةالجزاءاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Sanctionfrm frm =new Sanctionfrm())
            {
                frm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //  timelab.Text = DateTime.Now.ToLongTimeString();
            timer1.Stop();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timelab.Text = DateTime.Now.ToLongTimeString();
        }

        private void الوظائفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmJob frm = new FrmJob())
            {
                frm.ShowDialog();
            }

        }

        private void الدخولللبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmLogin_System frm = new FrmLogin_System())
            {
                frm.ShowDialog();
            }
        }

        private void الغيابوالحضورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AttendForm frm = new AttendForm())
            {
                frm.ShowDialog();
            }
        }

        private void المرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmSalaryInformation frm = new frmSalaryInformation())
            {
                frm.ShowDialog();
            }
        }

        private void العلاواتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAddSalary frm = new frmAddSalary())
            {
                frm.ShowDialog();

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void اعداداتالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmSubTrackSalary frm = new frmSubTrackSalary())
            {
                frm.ShowDialog();

            }
        }

        private void الخزينةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmBank frm = new frmBank())
            {
                frm.ShowDialog();

            }

        }

        private void تقريركلشهرعنكلقسمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DepartmentReport frm = new DepartmentReport())
            {
                frm.ShowDialog();
            }
        }

        private void رسمبيانيعنالمرتبلكلقسمToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (DepartmentSalaryChart frm = new DepartmentSalaryChart())
            {
                frm.ShowDialog();
            }

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();

          
        }

        private void مرتباتالموظفينداخلالقسمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ReportsForms.DepartmentAndBankReport frm = new ReportsForms.DepartmentAndBankReport())
            {
                frm.ShowDialog();
            }

        }

        private void التأميناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ReportsForms.frmInsuranceReport frm = new ReportsForms.frmInsuranceReport())
            {
                frm.ShowDialog();
            }
        }

        private void الضرائبToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (ReportsForms.frmTaxValue frm = new ReportsForms.frmTaxValue())
            {
                frm.ShowDialog();
            }
        }

        private void الضرائبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SeeTax frm = new SeeTax())
            {
                frm.ShowDialog();
            }
        }

        private void الموظفينالذينلميتماستلامالمرتبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ReportsForms.frmDidnotSalary frm = new ReportsForms.frmDidnotSalary())
            {
                frm.ShowDialog();

            }
        }

        private void المرتبالشهريللموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ReportsForms.SalaryEmployeesInformation frm = new ReportsForms.SalaryEmployeesInformation())
            {
                frm.ShowDialog();
            }
           
        }
    }
}
