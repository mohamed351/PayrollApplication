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
using MaterialSkin.Controls;

namespace PayrollApplication
{
    public partial class FrmJob : MaterialSkin.Controls.MaterialForm
    {
        public FrmJob()
        {
            InitializeComponent();
        }

        private void FrmJob_Load(object sender, EventArgs e)
        {
            SelectItems();

        }

        private void SelectItems()
        {
            using (Context context = new Context())
            {
                dataGridView1.DataSource = context.JobTitles;
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["Name"].HeaderText = "اسم الوظيفة";
                dataGridView1.Columns[2].HeaderText = "الحد الأدني";
                dataGridView1.Columns[3].HeaderText = "الحد الأقصي";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddfrmJob frm = new AddfrmJob())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (Context context = new Context())
                    {
                        dataGridView1.DataSource = context.JobTitles;
                        dataGridView1.Columns["ID"].Visible = false;
                        dataGridView1.Columns["Name"].HeaderText = "اسم الوظيفة";
                        dataGridView1.Columns[2].HeaderText = "الحد الأدني";
                        dataGridView1.Columns[3].HeaderText = "الحد الأقصي";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            string name = Convert.ToString(dataGridView1.CurrentRow.Cells["Name"].Value);
            double min = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value);
            double max = Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value);

            using (EditJobName frm = new EditJobName(ID, name, min, max))
            {
                frm.ShowDialog();
                SelectItems();
            }
        }
    }
}
