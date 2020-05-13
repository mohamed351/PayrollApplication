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
    public partial class AttendForm : Form
    {
        public AttendForm()
        {
            InitializeComponent();
        }

        private void AttendForm_Load(object sender, EventArgs e)
        {
            Year();
            Month();
            Days();
            comboBox3.Text = "1";
            using (Attenance attend = new Attenance())
            {
               combolaberday.DataSource= attend.SelectDaysLabor();
                combolaberday.DisplayMember = "Attendance_Date";
                combolaberday.ValueMember = "ID";
            }
           
            
        }

        private void Year()
        {
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.Text = DateTime.Now.Year.ToString();
           
        }

        private void Month()
        {
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i);
            }
            comboBox2.Text = DateTime.Now.Month.ToString();
            comboBox3.Text = "1";
        }
        private void Days()
        {
            comboBox3.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(comboBox1.Text),Convert.ToInt32(comboBox2.Text)); i++)
            {
                comboBox3.Items.Add(i);
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Days();
            comboBox3.Text = "1";
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Days();
            comboBox3.Text = "1";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectA();
        }

        private void SelectA()
        {
            using (Attenance atn = new Attenance())
            {
                dataAttend.DataSource = atn.SelectInformation(comboBox1.Text, comboBox2.Text, comboBox3.Text);
            }
        }

        private void btnSearchLabor_Click(object sender, EventArgs e)
        {
            using (Attenance attenance = new Attenance())
            {
              dataAttend.DataSource=  attenance.Get_AllAttendTime(Convert.ToInt32(combolaberday.SelectedValue));
            }
        }
    }
}
