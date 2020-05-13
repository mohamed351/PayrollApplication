using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollApplication.OurModel;

namespace PayrollApplication
{
    public partial class frmAddSalary : MaterialSkin.Controls.MaterialForm
    {
        public frmAddSalary()
        {
            InitializeComponent();
        }

        private void frmAddSalary_Load(object sender, EventArgs e)
        {
            SelectInformation();
        }
        /// <summary>
        /// تقوم بأستدعاء البيانات من قواعد البيانات
        /// </summary>
        private void SelectInformation()
        {
            try
            {
                CompanyEntities entities = new OurModel.CompanyEntities();
                var x = from n in entities.AddSalaries
                        select new { n.ID, n.Amount, n.Justification };
                dataGridView1.DataSource = x.ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns["Amount"].HeaderText = "الكمية";
                dataGridView1.Columns["Justification"].HeaderText = "التبرير";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtAddSalary.Text) && !string.IsNullOrWhiteSpace(txtJusfifcation.Text))
                {
                    CompanyEntities entities = new CompanyEntities();
                    entities.AddSalaries.Add(new AddSalary() { Amount = Convert.ToDecimal(txtAddSalary.Text), Justification = txtJusfifcation.Text });
                    int i = entities.SaveChanges();
                    if (i > 0)
                    {
                        MessageBox.Show("تم حفظ البيانات ", "البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.EraseAllText(this);

                        SelectInformation();

                    }
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    CompanyEntities entities = new CompanyEntities();
                    int i = int.Parse(txtID.Text);
                    AddSalary salary = entities.AddSalaries.SingleOrDefault(a => a.ID == i);
                    if (salary != null)
                    {
                        salary.Amount = Convert.ToDecimal(txtAddSalary.Text);
                        salary.Justification = txtJusfifcation.Text;
                        if (entities.SaveChanges() > 0)
                        {
                            MessageBox.Show("لقد تم التعديل في البيانات", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SelectInformation();
                        }

                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
           

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
          if(dataGridView1.CurrentRow !=null)
            {
                txtAddSalary.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtJusfifcation.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow !=null)
            {
              if(MessageBox.Show("هل تريد الغاء "+ dataGridView1.CurrentRow.Cells[2].Value, "تحذير",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CompanyEntities entity = new CompanyEntities();
                    int i = int.Parse(txtID.Text);
                 AddSalary salary=   entity.AddSalaries.SingleOrDefault(a => a.ID == i);
                    entity.AddSalaries.Remove(salary);
                   if( entity.SaveChanges() >0)
                    {
                        MessageBox.Show("لقد تم المسح بنجاح", "الغاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SelectInformation();
                        Helper.EraseAllText(this);


                    }
               
                  
                }
            }
        }
    }
}
