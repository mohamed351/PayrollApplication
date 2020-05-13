using BAL;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing;

namespace PayrollApplication
{
    public partial class Employees : MaterialSkin.Controls.MaterialForm
    {
        public Employees()
        {
            InitializeComponent();
        }
        List<JobTitle> job;
        byte[] image;  
        private void Employees_Load(object sender, EventArgs e)
        {


            using (Context context = new Context())
            {
                comboDepartment.DataSource = context.Department;
                comboDepartment.DisplayMember = "DepartmentName";
                comboDepartment.ValueMember = "ID";
                job = context.JobTitles;
                comboJobTitle.DataSource = job;
                comboJobTitle.DisplayMember = "Name";
                comboJobTitle.ValueMember = "ID";
                CalculateMaxAndMin(job);

            }
            SelectInformation();

        }

        private void SelectInformation()
        {
            Employee emp = new Employee();
           
                txtsearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                DataTable table = emp.SelectEmployeeInformations();
                dataGridView1.DataSource = table;
                foreach (DataRow item in table.Rows)
                {
                    txtsearch.AutoCompleteCustomSource.Add(item["Name"].ToString());
                }

           
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "اسم الموظف";
            dataGridView1.Columns[2].HeaderText = "المرتب";
            dataGridView1.Columns[3].HeaderText = "اسم القسم";
            dataGridView1.Columns[4].HeaderText = "الوظيفة ";
        }

        private void CalculateMaxAndMin(List<JobTitle> job)
        {
            /*Metho*/
            minandMax.Minimum = Convert.ToDecimal(job.Single(d => d.ID == Convert.ToInt32(comboJobTitle.SelectedValue)).RangMin);

            minandMax.Maximum = Convert.ToDecimal(job.Single(d => d.ID == Convert.ToInt32(comboJobTitle.SelectedValue)).RangMax);
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "PNGFiles|*.png|JPGFiles|*.jpg";
                
                if(file.ShowDialog() == DialogResult.OK)
                { 
                    
                    picEmployee.ImageLocation = file.FileName;
                    txtpath.Text = file.FileName;
                image= Helper.ConvertImage(file.FileName);
                   
                }
            }
        }

        private void comboJobTitle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CalculateMaxAndMin(job);
        }

        private void txtpath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (image == null)
                {
                    throw new Exception("قم باضافة الصورة");
                }
                using (Employee employee = new Employee())
                {
                    employee.Name = txtname.Text;
                    employee.Salary = Convert.ToDouble(minandMax.Value);
                    employee.DepartmentID = Convert.ToInt32(comboDepartment.SelectedValue);
                    employee.HiredDate = dateHire.Value;
                    employee.DateOfBirth = dateBirth.Value;
                    employee.Picture = image;
                    employee.MaritalStatus = comboStatus.Text;
                    employee.Geneder = comboGender.Text;
                    employee.JobID = Convert.ToInt32(comboJobTitle.SelectedValue);
                    employee.username = txtusername.Text;
                    using (EncryptionAndDescrption cn = new EncryptionAndDescrption())
                    {
                        employee.password = cn.Encryption(txtpassword.Text);
                    }
                    if (employee.InsertEmployees(employee))
                    {
                        MessageBox.Show("لقد تم اضافة الموظفين", "رسالة ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SelectInformation();
                    }
                    else
                    {
                        MessageBox.Show("يوجد خطاء في ادخال البيانات", "رسالة ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

              




            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message ,"رسالة ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

     

        private void button4_Click(object sender, EventArgs e)
        {


            
            int id = Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            using (FrmEditEmployees frm = new FrmEditEmployees(id))
            {
               if( frm.ShowDialog() == DialogResult.OK)
                {
                    using (Context ctx = new Context())
                    {
                        SelectInformation();
                    }
                }
            }
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

          
                using (FrmEmployeesAllInformations frm = new FrmEmployeesAllInformations(i))
                {
                    frm.ShowDialog();
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (EmployeesReport employees = new EmployeesReport())
            {
                employees.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Print_frm_Employees frm = new Print_frm_Employees())
            {
                frm.ShowDialog();
            }
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int empID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            using (ReportsForms.EmpDetials frm =new ReportsForms.EmpDetials(empID))
            {
                frm.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
           dataGridView1.DataSource = emp.SelectEmployees(txtsearch.Text);

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "اسم الموظف";
            dataGridView1.Columns[2].HeaderText = "المرتب";
            dataGridView1.Columns[3].HeaderText = "اسم القسم";
            dataGridView1.Columns[4].HeaderText = "الوظيفة ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
          SelectInformation();
        }
    }
}
