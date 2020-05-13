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
    public partial class frmAddlogin : Form
    {
        public frmAddlogin()
        {
            InitializeComponent();
        }

        private void frmAddlogin_Load(object sender, EventArgs e)
        {
            using (Context ctx = new Context())
            {
                listBox1.DataSource = ctx.Employees;
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "ID";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (EmployeesLogin lg = new EmployeesLogin())
            {
                lg.InsertLogin(Convert.ToInt32(listBox1.SelectedValue));
            }
        }
    }
}
