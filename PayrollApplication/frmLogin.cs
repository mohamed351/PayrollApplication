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
using System.Threading;

namespace PayrollApplication
{
    public partial class frmLogin :MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtusername.Text) && !string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    EmployeesLogin login = new EmployeesLogin();
                    Employee employee = login.Login(txtusername.Text, txtpassword.Text);
                    if (!string.IsNullOrEmpty(employee.Name))
                    {
                        Thread th = new Thread(Main);
                        th.ApartmentState = ApartmentState.STA;
                        th.Start();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("يوجد خطاء في اسم المستخدم و كلمة المرور", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Test");
            }
        }
        public void Main()
        {
            Application.Run(new Main());
        }
    }
}
