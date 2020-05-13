using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using BAL;

namespace PayrollApplication
{
    public partial class FrmEditEmployees : MaterialSkin.Controls.MaterialForm
    {

        int _id;
        
        public FrmEditEmployees(int ID)
        {
            _id = ID;
            InitializeComponent();
        }
        byte[] orignalImage;
        List<JobTitle> jobtitle;
        private void FrmEditEmployees_Load(object sender, EventArgs e)
        {
            label1.Text = _id.ToString();
            Employee employee;
            JobTitle title;
            using (Context context = new Context())
            {
                employee= context.Employees.SingleOrDefault(a => a.ID == _id);
                jobtitle = context.JobTitles;
                title = jobtitle.SingleOrDefault(a => a.ID == employee.JobID);
                combodepartment.DataSource = context.Department;
                combodepartment.ValueMember = "ID";
                combodepartment.DisplayMember = "DepartmentName";
                combojob.DataSource = context.JobTitles;
                combojob.ValueMember = "ID";
                combojob.DisplayMember = "Name";


            }
            txtname.Text = employee.Name;
            topdownNumic.Maximum = Convert.ToDecimal(title.RangMax);
            topdownNumic.Minimum = Convert.ToDecimal(title.RangMin);
            topdownNumic.Value = Convert.ToDecimal(employee.Salary);
            ImageConverter converter = new ImageConverter();
            orignalImage = employee.Picture;
           pictureBox1.Image =(Image) converter.ConvertFrom(orignalImage);
            hiredate.Value = employee.HiredDate;
            birthdate.Value = employee.DateOfBirth;
          combodepartment.SelectedValue =   employee.DepartmentID;
            combojob.SelectedValue = employee.JobID;
            comboGender.Text = employee.Geneder;
            comboStatus.Text = employee.MaritalStatus;
            txtusername.Text = employee.username;
         txtpassword.Text=  EncryptionAndDescrption.DecryptString(employee.password);



            
        }
        byte[] picture;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtpath.Text = open.FileName;
                    pictureBox1.ImageLocation = txtpath.Text;
                picture=   Helper.ConvertImage(txtpath.Text);
                }
            }
        }

        private void cheackpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = !cheackpassword.Checked;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Employee employees = new Employee();
            
                using (EncryptionAndDescrption cn = new EncryptionAndDescrption())
                {
                   
                 employees.password=  cn.Encryption(txtpassword.Text);
                }
                    employees.ID = _id;
                employees.Name = txtname.Text;
               
                employees.username = txtusername.Text;
                employees.DateOfBirth = birthdate.Value;
                employees.HiredDate = hiredate.Value;
                employees.JobID = Convert.ToInt32(combojob.SelectedValue);
                employees.DepartmentID = Convert.ToInt32(combodepartment.SelectedValue);
                employees.Geneder = comboGender.Text;
                employees.MaritalStatus = comboStatus.Text;
                employees.Salary = Convert.ToDouble(topdownNumic.Value);
                if (picture != null)
                {
                    employees.Picture = picture;
                }
                else
                {
                    employees.Picture = orignalImage;
                }

              if(employees.EditEmployees(employees))
                {
                    MessageBox.Show("لقد تم التعديل","رسالة",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            
        }

        private void combojob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(combojob.SelectedValue);
            JobTitle t = jobtitle.SingleOrDefault(a => a.ID == i);
            topdownNumic.Maximum = Convert.ToDecimal(t.RangMax);
            topdownNumic.Minimum = Convert.ToDecimal(t.RangMin);

           
        }
    }
}
