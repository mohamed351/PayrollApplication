using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using BAL;

namespace PayrollApplication
{
    public partial class FrmAddPunishment : MaterialForm
    {
        public FrmAddPunishment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Sanction sanction = new Sanction();
                sanction.SanctionName = txtname.Text;
                sanction.Sanction_Description = txtdecription.Text;
                if(sanction.Add_Sanction(sanction))
                {
                    MessageBox.Show("لقد تم اضافة الجزاء","معلومات",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم اضافة الجزاء", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
