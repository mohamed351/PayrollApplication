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

namespace PayrollApplication
{
    public delegate void SelectedManager(int ID,string name );
    
    public partial class FrmSelectManager : Form
    {
    public    event SelectedManager WhenManagerSelected;
        public FrmSelectManager()
        {
         
            InitializeComponent();
        }

        private void FrmSelectManager_Load(object sender, EventArgs e)
        {
            using (Context ctx = new Context())
            {
               listBox1.DataSource= ctx.Employees;
           
                listBox1.DisplayMember = "Name";
                listBox1.ValueMember = "ID";
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            SelectedManager selected = new SelectedManager(WhenManagerSelected);
            selected(Convert.ToInt32(listBox1.SelectedValue), ((Employee)listBox1.SelectedItem).Name);
            this.Close();
        }
    }
}
