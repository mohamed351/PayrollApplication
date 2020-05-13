using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PayrollApplication
{
    public partial class frmBank : MetroFramework.Forms.MetroForm
    {
        public frmBank()
        {
            InitializeComponent();
        }

        private void frmBank_Load(object sender, EventArgs e)
        {
            OurModel.CompanyEntities entities = new OurModel.CompanyEntities();
            decimal? b = entities.Employees.Sum(a => a.Salary);
            txtAllSalary.Text = b.ToString();
            SelectInforamtiom(entities);
        }

        public void SelectInforamtiom(OurModel.CompanyEntities entities)
        {
            var select = from x in entities.Banks.ToList()
                         select new { x.ID, x.Name, x.BankBlance, x.AddedDate };
            dataGridBank.DataSource = select.ToList();
            dataGridBank.Columns[0].Visible = false;
            dataGridBank.Columns[1].HeaderText = "اسم الحساب";
            dataGridBank.Columns[2].HeaderText = "المبلغ";
            dataGridBank.Columns[3].HeaderText = "التاريخ";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtAllSalary.Text) > double.Parse(txtAll.Value.ToString()))
            {
                MessageBox.Show("لا يمكن اضافة الحساب", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OurModel.CompanyEntities entities = new OurModel.CompanyEntities();
            entities.Banks.Add(new OurModel.Bank() { Name = txtname.Text, BankBlance = txtAll.Value, AddedDate = AllDate.Value });
            if (entities.SaveChanges() > 0)
            {
                MessageBox.Show("لقد تم اضافة الحساب بتاريخ المراد بيعة", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SelectInforamtiom(entities);
            }
        }
    }
}
