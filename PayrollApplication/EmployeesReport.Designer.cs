namespace PayrollApplication
{
    partial class EmployeesReport
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
            this.CompanyDataSet = new PayrollApplication.CompanyDataSet();
            this.EmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeesTableAdapter = new PayrollApplication.CompanyDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmployeesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PayrollApplication.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1240, 821);
            this.reportViewer1.TabIndex = 0;
            // 
            // CompanyDataSet
            // 
            this.CompanyDataSet.DataSetName = "CompanyDataSet";
            this.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeesBindingSource
            // 
            this.EmployeesBindingSource.DataMember = "Employees";
            this.EmployeesBindingSource.DataSource = this.CompanyDataSet;
            // 
            // EmployeesTableAdapter
            // 
            this.EmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 821);
            this.Controls.Add(this.reportViewer1);
            this.Name = "EmployeesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeesReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmployeesBindingSource;
        private CompanyDataSet CompanyDataSet;
        private CompanyDataSetTableAdapters.EmployeesTableAdapter EmployeesTableAdapter;
    }
}