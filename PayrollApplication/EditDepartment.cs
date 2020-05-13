using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using BAL;

namespace PayrollApplication
{
    public partial class EditDepartment : MaterialForm
    {
        public EditDepartment()
        {
            InitializeComponent();
        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {
            /* Context context = new Context();
             dataGridView1.DataSource = context.Department;
             dataGridView1.Columns["ID"].Visible = false;
             dataGridView1.Columns["DepartmentName"].HeaderText = "اسم القسم";
             dataGridView1.Columns["Description"].HeaderText = "وصف القسم";
             */


            using (Department dept = new Department())
            {
               dataGridView1.DataSource= dept.SelectDepartmentWithManager();
                
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["DepartmentName"].HeaderText = "اسم القسم";
                dataGridView1.Columns["Description"].HeaderText = "وصف القسم";
                dataGridView1.Columns["Name"].HeaderText = "اسم المدير";
                
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {

                int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                string name = dataGridView1.CurrentRow.Cells["DepartmentName"].Value.ToString();
                string decription = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
                string ManagerName = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                Edit2Department frm = new Edit2Department(ID, name, decription,ManagerName);

                Context context = new Context();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Department department = new Department();
                    dataGridView1.DataSource = department.SelectDepartmentWithManager();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                
            }

            
        }
    }
}
