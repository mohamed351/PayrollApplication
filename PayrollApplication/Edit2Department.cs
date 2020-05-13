using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using BAL;

namespace PayrollApplication
{
    public partial class Edit2Department :MaterialForm
    {
       
        public Edit2Department(int departmentid, string departmentname,string decription,string ManagerName)
        {
            InitializeComponent();
            labID.Text = departmentid.ToString();
            txtDepartmentName.Text = departmentname;
            txtDescription.Text = decription;
            txtManager.Text = ManagerName;



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (btnEdit.DialogResult == DialogResult.OK)
                {
                    using (Department department = new Department())
                    {
                        department.ID = Convert.ToInt32(labID.Text);
                        department.DepartmentName = txtDepartmentName.Text;
                        department.Description = txtDescription.Text;
                        department.ManagerID = Convert.ToInt32(label4.Text);
                        department.EditDepartment(department);
                    }
                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnEdit.DialogResult = DialogResult.None;
                btnEdit.PerformClick();

                
                
            }


          
        }

        private void btn_Add_Manager_Click(object sender, EventArgs e)
        {
            using (FrmSelectManager frm = new FrmSelectManager())
            {
                frm.WhenManagerSelected += (a, b) =>
                  {
                      label4.Text = a.ToString();
                      txtManager.Text = b;

                  };
                frm.ShowDialog();
            }

        }
    }
}
