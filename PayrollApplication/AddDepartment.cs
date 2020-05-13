using System;
using System.Windows.Forms;
using BAL;

namespace PayrollApplication
{
   //لم نقم بتسجيل اضافة للمدير القسم 
    public partial class AddDepartment :MaterialSkin.Controls.MaterialForm
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            //نقوم باستدعاء البيانات من قاعدة البيانات
            SelectDepartment();
            dataviewDepartment.Columns["ID"].Visible = false;
            dataviewDepartment.Columns["DepartmentName"].HeaderText = "اسم القسم";
            dataviewDepartment.Columns["Description"].HeaderText = " الوصف القسم";
            dataviewDepartment.Columns["Name"].HeaderText = "اسم المدير القسم";
        }
        /// <summary>
        /// تقوم بأستدعاء البيانات من قاعدة البانات
        /// </summary>
        private void SelectDepartment()
        {

            try
            {
                Department dept = new Department();
                dataviewDepartment.DataSource = dept.SelectDepartmentWithManager();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = new Department
                {

                    DepartmentName = txtDepartmentName.Text,
                    Description = txtDescription.Text,
                    ManagerID = Convert.ToInt32(label4.Text) 
                    
                };
                if (department.AddDepartment(department))
                {
                   
                    MessageBox.Show(" لقد تم اضافة القسم", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SelectDepartment();
                    Helper.EraseAllText(this);
                    
                }
                else
                {
                    MessageBox.Show("يوجد خطاء ما ربما في الأتصال او الأدخال", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmSelectManager frm = new FrmSelectManager())
                {
                    // عندما تشير الي موظف جديد لقسم 
                    // دا Event 
                    frm.WhenManagerSelected += (a, b) =>
                      {
                          txtManagerName.Text = b;
                          label4.Text = a.ToString();
                      };
                    frm.ShowDialog();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
