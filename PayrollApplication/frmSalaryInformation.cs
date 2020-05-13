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
    public partial class frmSalaryInformation : Form
    {
        DataTable _AddSalaryTable;
        DataTable _SubTrackTable;
        public frmSalaryInformation()
        {
            InitializeComponent();
            _AddSalaryTable = new DataTable();
            _SubTrackTable = new DataTable();
            //Add Salary table 
            _AddSalaryTable.Columns.Add("AddSalaryID",typeof(int));
            _AddSalaryTable.Columns.Add("Amount",typeof(decimal));
            //SubTrack Salary table 
            _SubTrackTable.Columns.Add("subtrackSalaryID",typeof(int));
            _SubTrackTable.Columns.Add("Amount",typeof(decimal));


           
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (frmAddEmployees_SalaryInformation frm = new frmAddEmployees_SalaryInformation())
            {
               if( frm.ShowDialog() == DialogResult.OK)
                {
                    txtSearch.Text = frm.empName;
                    label5.Text = frm.EmpID.ToString();
                    txtSalarym.Text = frm.Salary.ToString();
                    txtSalary.Text = (frm.Salary * 12).ToString();
                    txtInsuransValue.Text = frm.InsuranceValue.ToString();
                    txtInsurancem.Text = (frm.InsuranceValue / 12).ToString();
                    txtbeforettaxt.Text = (Convert.ToDecimal(txtSalary.Text) - Convert.ToDecimal(txtInsuransValue.Text)).ToString();
                    

                 
                    #region  TaxCalculations
                   
                    decimal de = Convert.ToDecimal(txtbeforettaxt.Text);
                    OurModel.CompanyEntities company = new OurModel.CompanyEntities();
                    List<OurModel.SalaryTaxInformation> list = company.SalaryTaxInformations.ToList();
                    OurModel.SalaryTaxInformation info = list.SingleOrDefault(a => a.MinValue < de && a.MaxValue > de);
                   decimal cal1=  CalValueTaxAfterMainRow(list,info.ID);
                    decimal cal2 = de - Convert.ToDecimal(info.MinValue);
                    cal2 = cal2 *Convert.ToDecimal( info.Taxpercent);
                    txtTaxAfter.Text = (cal1 + cal2).ToString();
                    txtTaxValuem.Text = (Math.Round(Convert.ToDecimal(txtTaxAfter.Text) / 12)).ToString();

                    txtnumbertax.Text = info.ID.ToString();


                    #endregion
                    txtaccountid.Text = frm.idaccount.ToString();
                    txtAccountName.Text = frm.AccountName;
                }

            }
        }

        private static decimal CalValueTaxAfterMainRow(List<OurModel.SalaryTaxInformation> list, int i)
        {
            decimal val = 0;
            for (int x = 0; x < i - 1; x++)
            {
                val += Convert.ToDecimal(list[x].TaxValue);
            }
            return val;
        }

        private void frmSalaryInformation_Load(object sender, EventArgs e)
        {
            DataGridViewModel();

            OurModel.CompanyEntities entities = new OurModel.CompanyEntities();

            //Add To Salary
            comboAddToSalary.DataSource = entities.AddSalaries.ToList();
            comboAddToSalary.DisplayMember = "Justification";
            comboAddToSalary.ValueMember = "ID";
            //SubTrackToSalary 
            OurModel.SubTractSalary sub = new OurModel.SubTractSalary();

            comboSubTrackToSalary.DataSource = entities.SubTractSalaries.ToList();
            comboSubTrackToSalary.DisplayMember = "Justification";
            comboSubTrackToSalary.ValueMember = "ID";





        }

        private void DataGridViewModel()
        {
            dataAddSalary.Columns.Add("ID", "ID");
            dataAddSalary.Columns["ID"].Visible = false;
            dataAddSalary.Columns.Add("Justification", "التبرير");
            dataAddSalary.Columns.Add("amount", "المبلغ");

            datasubtrackSalary.Columns.Add("ID", "ID");
            datasubtrackSalary.Columns["ID"].Visible = false;
            datasubtrackSalary.Columns.Add("Justification", "التبرير");
            datasubtrackSalary.Columns.Add("amount", "المبلغ");
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {

            OurModel.CompanyEntities entities = new OurModel.CompanyEntities();
            int ID = Convert.ToInt32(comboAddToSalary.SelectedValue);
         OurModel.AddSalary salary=   entities.AddSalaries.SingleOrDefault(a => a.ID == ID);
            dataAddSalary.Rows.Add(ID, salary.Justification, salary.Amount);


            double addcal = 0;
            for (int i = 0; i < dataAddSalary.RowCount - 1; i++)
            {

                addcal += Convert.ToDouble(dataAddSalary.Rows[i].Cells[2].Value);
            }

           txtTotalAdd.Text = addcal.ToString();


        }
       
        private void btnSubTrackToSalary_Click(object sender, EventArgs e)
        {
            OurModel.CompanyEntities entities = new OurModel.CompanyEntities();
            int ID = Convert.ToInt32(comboSubTrackToSalary.SelectedValue);
            OurModel.SubTractSalary sub = entities.SubTractSalaries.SingleOrDefault(a => a.ID == ID);
            datasubtrackSalary.Rows.Add(ID, sub.Justification, sub.Amount);

            double subcal = 0;
            for (int i = 0; i < datasubtrackSalary.RowCount-1; i++)
            {

                subcal -= Convert.ToDouble(datasubtrackSalary.Rows[i].Cells[2].Value);
            }

            txtTotalSubtract.Text = subcal.ToString();



        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dataAddSalary.Rows.Clear();
            txtTotalAdd.Text = "0";


           
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            datasubtrackSalary.Rows.Clear();
            txtTotalSubtract.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            for (int i = 0; i < dataAddSalary.Rows.Count-1; i++)
            {
                _AddSalaryTable.Rows.Add(dataAddSalary.Rows[i].Cells["ID"].Value, dataAddSalary.Rows[i].Cells["Amount"].Value);
                

            }

            for (int i = 0; i < datasubtrackSalary.Rows.Count-1; i++)
            {
                _SubTrackTable.Rows.Add(datasubtrackSalary.Rows[i].Cells["ID"].Value, datasubtrackSalary.Rows[i].Cells["Amount"].Value);
            }

            Calculater();
            using (TotalSalary sal = new TotalSalary())
            {
               
              

                
                sal.EmpID = Convert.ToInt32(label5.Text);
                sal.addsalarytable = _AddSalaryTable;
                sal.subtracktable = _SubTrackTable;
                sal.BankID = Convert.ToInt32(txtaccountid.Text);
                sal.Salary = Convert.ToDecimal(txtSalarym.Text);
                sal.AllSalary = Convert.ToDecimal(txtTotalSalary.Text);
                sal.Insurance = Convert.ToDecimal(txtInsurancem.Text);
                sal.TaxID = Convert.ToInt32(txtnumbertax.Text);
                sal.TaxValue = Convert.ToDecimal(txtTaxValuem.Text);
                sal.AccountName = txtAccountName.Text;
               if( sal.SaveEmployeesData(sal))
                {
                    MessageBox.Show(" لقد تم اضافة المرتب لموظف ","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    Helper.MakeItEmpty(groupBox1);
                    Helper.MakeItEmpty(groupBox2);
                    Helper.MakeItEmpty(groupBox4);
                    Helper.MakeDataGridViewEmpty(datasubtrackSalary);
                    Helper.MakeDataGridViewEmpty(dataAddSalary);
                    txtTotalAdd.Text = "0";
                    txtTotalSubtract.Text = "0";
                    _AddSalaryTable.Rows.Clear();
                    _SubTrackTable.Rows.Clear();
                    txtTotalSalary.Text = "";




                }
              
  

            }
          

        }

        private void btncalac_Click(object sender, EventArgs e)
        {
            Calculater();

        }

        private void Calculater()
        {
            decimal salary = Convert.ToDecimal(txtSalarym.Text);
            decimal Insurance = Convert.ToDecimal(txtInsurancem.Text);
            decimal tax = Convert.ToDecimal(txtTaxValuem.Text);
            decimal bons = Convert.ToDecimal(txtTotalAdd.Text) + Convert.ToDecimal(txtTotalSubtract.Text);

            decimal total = (salary - Insurance - tax) + bons;

            txtTotalSalary.Text = total.ToString();
        }
    }
}
