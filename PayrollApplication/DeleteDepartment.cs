using System;
using System.Windows.Forms;
using BAL;

namespace PayrollApplication
{
    public partial class DeleteDepartment : MaterialSkin.Controls.MaterialForm
    {
        public DeleteDepartment()
        {
            InitializeComponent();
        }

        private void DeleteDepartment_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                dataGridView1.DataSource = context.Department;
            }
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["DepartmentName"].HeaderText = "اسم القسم";
            dataGridView1.Columns["Description"].HeaderText = "وصف القسم";

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            labID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells["DepartmentName"].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (Department department = new Department())
            {
                try
                {
                    if (department.UnFlagDepartment(new Department() { ID = Convert.ToInt32(labID.Text) }))
                    {
                        MessageBox.Show("لقد تم مسح الأقسام ", "مسح الأقسام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("يوجد خطاء");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Context context = new Context();
            dataGridView1.DataSource= context.Department;

           
            
        }
    }
}
