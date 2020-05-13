using System;
using System.Windows.Forms;
using BAL;

namespace PayrollApplication
{
    public partial class Sanctionfrm : MaterialSkin.Controls.MaterialForm
    {
        public Sanctionfrm()
        {
            InitializeComponent();
        }

        private void Sanctionfrm_Load(object sender, EventArgs e)
        {
            using (Context ctx = new Context())
            {
                datagrid.DataSource = ctx.Sentions;
            }
            datagrid.Columns["ID"].Visible = false;
            datagrid.Columns[1].HeaderText = "اسم الجزاء";
            datagrid.Columns[2].HeaderText = "وصف الجزاء";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FrmAddPunishment frm = new FrmAddPunishment())
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    using (Context ctx = new Context())
                    {
                       datagrid.DataSource = ctx.Sentions;
                    }
                }
            }

        }

        private void datagrid_Click(object sender, EventArgs e)
        {
        idvisiable.Text =   datagrid.CurrentRow.Cells["ID"].Value.ToString();
            if(!string.IsNullOrEmpty(idvisiable.Text))
            {
                btnedit.Enabled = true;
                btndelete.Enabled = true;
                
            }
            else
            {
                btnedit.Enabled = false;
                btndelete.Enabled = false;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = datagrid.CurrentRow.Cells[1].Value.ToString();
                string description = datagrid.CurrentRow.Cells[2].Value.ToString();
                FrmEditPunishment frm = new FrmEditPunishment(Convert.ToInt32(idvisiable.Text), name, description);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (Context ctx = new Context())
                    {
                        datagrid.DataSource = ctx.Sentions;

                    }
                }
                Fix();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Fix()
        {
            idvisiable.Text = "";
            btnedit.Enabled = false;
            btndelete.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (Sanction sanction = new Sanction())
                {
                    sanction.ID = Convert.ToInt32(idvisiable.Text);
                   if( sanction.Delete_Sanction(sanction))
                    {
                        MessageBox.Show("لقد تم الغاء الموظفين","معلومات",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        using (Context ctx = new Context())
                        {
                            datagrid.DataSource = ctx.Sentions;
                        }
                        Fix();
                    }
                   else
                    {
                        MessageBox.Show("لم يتم الغاء الموظفين", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
