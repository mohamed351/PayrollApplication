namespace PayrollApplication
{
    partial class frmBank
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAllSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AllDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAll = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dataGridBank = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBank)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 524);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(511, 36);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAllSalary
            // 
            this.txtAllSalary.Enabled = false;
            this.txtAllSalary.Location = new System.Drawing.Point(140, 210);
            this.txtAllSalary.Name = "txtAllSalary";
            this.txtAllSalary.Size = new System.Drawing.Size(133, 22);
            this.txtAllSalary.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "مرتبات موظفين";
            // 
            // AllDate
            // 
            this.AllDate.Location = new System.Drawing.Point(140, 168);
            this.AllDate.Name = "AllDate";
            this.AllDate.Size = new System.Drawing.Size(243, 22);
            this.AllDate.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "التاريخ";
            // 
            // txtAll
            // 
            this.txtAll.Location = new System.Drawing.Point(140, 121);
            this.txtAll.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtAll.Name = "txtAll";
            this.txtAll.Size = new System.Drawing.Size(120, 22);
            this.txtAll.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "المبلغ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "اسم الحساب";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(140, 73);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 22);
            this.txtname.TabIndex = 14;
            // 
            // dataGridBank
            // 
            this.dataGridBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBank.Location = new System.Drawing.Point(22, 259);
            this.dataGridBank.Name = "dataGridBank";
            this.dataGridBank.RowTemplate.Height = 24;
            this.dataGridBank.Size = new System.Drawing.Size(499, 248);
            this.dataGridBank.TabIndex = 13;
            // 
            // frmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 609);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAllSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AllDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.dataGridBank);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBank";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.frmBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAllSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker AllDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DataGridView dataGridBank;
    }
}