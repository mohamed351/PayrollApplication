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
    public partial class FrmLogin_System : Form
    {
        public FrmLogin_System()
        {
            InitializeComponent();
        }

        private void FrmLogin_System_Load(object sender, EventArgs e)
        {
            SelectLoginEmployees();
        }

        private void SelectLoginEmployees()
        {
            using (EmployeesLogin log = new EmployeesLogin())
            {
                dataLogin.DataSource = log.EmployeesThatHavePermission();
                dataLogin.Columns["ID"].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddlogin frm = new frmAddlogin())
            {
                if(frm.ShowDialog()== DialogResult.OK)
                {
                    SelectLoginEmployees();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Name = dataLogin.CurrentRow.Cells[1].Value.ToString();
            int ID = Convert.ToInt32(dataLogin.CurrentRow.Cells[0].Value);
           if ( MessageBox.Show("هل تريد الغاء "+Name,"تحذير",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (EmployeesLogin lg = new EmployeesLogin())
                {
                    lg.DeleteLogin(ID);
                    SelectLoginEmployees();

                }
            }
        }
    }
}
