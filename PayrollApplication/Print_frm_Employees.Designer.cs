namespace PayrollApplication
{
    partial class Print_frm_Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_ShowEmployeesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyDataSet = new PayrollApplication.CompanyDataSet();
            this.vw_ShowEmployeesDetailsTableAdapter = new PayrollApplication.CompanyDataSetTableAdapters.vw_ShowEmployeesDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ShowEmployeesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_ShowEmployeesDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PayrollApplication.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(899, 796);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // vw_ShowEmployeesDetailsBindingSource
            // 
            this.vw_ShowEmployeesDetailsBindingSource.DataMember = "vw_ShowEmployeesDetails";
            this.vw_ShowEmployeesDetailsBindingSource.DataSource = this.CompanyDataSet;
            // 
            // CompanyDataSet
            // 
            this.CompanyDataSet.DataSetName = "CompanyDataSet";
            this.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_ShowEmployeesDetailsTableAdapter
            // 
            this.vw_ShowEmployeesDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Print_frm_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 796);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Print_frm_Employees";
            this.Text = "Print_frm_Employees";
            this.Load += new System.EventHandler(this.Print_frm_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_ShowEmployeesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_ShowEmployeesDetailsBindingSource;
        private CompanyDataSet CompanyDataSet;
        private CompanyDataSetTableAdapters.vw_ShowEmployeesDetailsTableAdapter vw_ShowEmployeesDetailsTableAdapter;
    }
}