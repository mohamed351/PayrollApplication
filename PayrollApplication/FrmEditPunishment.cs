using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using BAL;

namespace PayrollApplication
{
    public partial class FrmEditPunishment :MaterialSkin.Controls.MaterialForm
    {
        int _id;
        string _name;
        string _decription;
        public FrmEditPunishment(int ID , string name , string decription)
        {
            _id = ID;
            _name = name;
            _decription = decription;
            InitializeComponent();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                using (Sanction sanction = new Sanction())
                {
                    sanction.ID = int.Parse(IDvisiable.Text);
                    sanction.SanctionName = txtname.Text;
                    sanction.Sanction_Description = txtdecription.Text;
                    if (sanction.Edit_Sanction(sanction))
                    {
                        MessageBox.Show("لقد تم تعديل الجزاء", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("يوجد خطاء  ما", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FrmEditPunishment_Load(object sender, EventArgs e)
        {
            IDvisiable.Text = _id.ToString();
            txtname.Text = _name;
            txtdecription.Text = _decription; 

        }
    }
}
