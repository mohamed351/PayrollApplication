using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using PayrollApplication.OurModel;
namespace PayrollApplication
{
    public partial class frmSubTrackSalary : MaterialForm
    {
        public frmSubTrackSalary()
        {
            InitializeComponent();
        }

        private void frmSubTrackSalary_Load(object sender, EventArgs e)
        {
            CompanyEntities entities = new CompanyEntities();

            comboSen.DataSource = entities.Sanctions_List.ToList();
            comboSen.DisplayMember = "Sanction_Name";
            comboSen.ValueMember = "ID";
            SelectInformation(entities);

        }

        private void SelectInformation(CompanyEntities entities)
        {
            var x = from n in entities.SubTractSalaries
                    select new { n.ID, n.Sanctions_List.Sanction_Name,n.Amount, n.Justification };

            dataGridView1.DataSource = x.ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyEntities entities = new CompanyEntities();
                SubTractSalary sub = new SubTractSalary();
                sub.Amount = Convert.ToDecimal(txtamont.Text);
                sub.Justification = txtJustification.Text;
                sub.SanctionsID = Convert.ToInt32(comboSen.SelectedValue);
                entities.SubTractSalaries.Add(sub);
                if (entities.SaveChanges() > 0)
                {
                    MessageBox.Show("لقد تم اضافة بيانات ","رسالة ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    SelectInformation(entities);
                }
              
               



            }
            catch (FormatException)
            {
                MessageBox.Show("قم بادخال البيانات بشكل صحيح","خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("من فضل لا تقوم بادخال البيانات بشكل عشوائي","خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(dataGridView1.CurrentRow !=null)
            {
                int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                CompanyEntities entitie = new CompanyEntities();
              SubTractSalary sub =  entitie.SubTractSalaries.SingleOrDefault(a => a.ID == ID);
                sub.Amount = Convert.ToDecimal(txtamont.Text);
                sub.Justification = txtJustification.Text;
               if( entitie.SaveChanges()>0)
                {
                    MessageBox.Show("لقد تم تعديل البيانات","رسالة",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    SelectInformation(entitie);


                }
                
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
              txtamont.Text =  dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtJustification.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboSen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if(dataGridView1.CurrentRow != null)
            {
            DialogResult result=    MessageBox.Show("هل تريد مسح "+dataGridView1.CurrentRow.Cells[1].Value,"تحذير", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    CompanyEntities entities = new CompanyEntities();
                    int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    SubTractSalary sub = entities.SubTractSalaries.SingleOrDefault(a => a.ID == ID);
                    entities.SubTractSalaries.Remove(sub);
                    if(entities.SaveChanges() >0)
                    {
                        MessageBox.Show("لقد تم الغاء البيانات ","معلومات",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        SelectInformation(entities);
                    }

                }
            }
        }
    }
}
