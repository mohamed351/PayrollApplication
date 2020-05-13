namespace PayrollApplication
{
    partial class frmAddEmployees_SalaryInformation
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
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtjobname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.comboAccout = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtinsurancevalues = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInsurancepersent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Search.Location = new System.Drawing.Point(110, 34);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(493, 22);
            this.Search.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "الموظف";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(609, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "اظهار";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(42, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(432, 101);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(239, 22);
            this.txtname.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Enabled = false;
            this.txtSalary.Location = new System.Drawing.Point(432, 129);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(239, 22);
            this.txtSalary.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "اسم الموظف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "المرتب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "القسم";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Enabled = false;
            this.txtDepartment.Location = new System.Drawing.Point(432, 163);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(239, 22);
            this.txtDepartment.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "المسمي الوظيفي";
            // 
            // txtjobname
            // 
            this.txtjobname.Enabled = false;
            this.txtjobname.Location = new System.Drawing.Point(432, 193);
            this.txtjobname.Name = "txtjobname";
            this.txtjobname.Size = new System.Drawing.Size(239, 22);
            this.txtjobname.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(599, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(372, 303);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 17);
            this.ID.TabIndex = 13;
            this.ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ID.Visible = false;
            // 
            // comboAccout
            // 
            this.comboAccout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccout.FormattingEnabled = true;
            this.comboAccout.Location = new System.Drawing.Point(432, 222);
            this.comboAccout.Name = "comboAccout";
            this.comboAccout.Size = new System.Drawing.Size(239, 24);
            this.comboAccout.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "الحساب";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "مبلغ التأمين";
            // 
            // txtinsurancevalues
            // 
            this.txtinsurancevalues.Location = new System.Drawing.Point(432, 263);
            this.txtinsurancevalues.Name = "txtinsurancevalues";
            this.txtinsurancevalues.Size = new System.Drawing.Size(239, 22);
            this.txtinsurancevalues.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "نسبة مبلغ التامين";
            // 
            // txtInsurancepersent
            // 
            this.txtInsurancepersent.Enabled = false;
            this.txtInsurancepersent.Location = new System.Drawing.Point(432, 298);
            this.txtInsurancepersent.Name = "txtInsurancepersent";
            this.txtInsurancepersent.Size = new System.Drawing.Size(100, 22);
            this.txtInsurancepersent.TabIndex = 19;
            this.txtInsurancepersent.Text = "0.14";
            // 
            // frmAddEmployees_SalaryInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 414);
            this.Controls.Add(this.txtInsurancepersent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtinsurancevalues);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboAccout);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtjobname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEmployees_SalaryInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموظف";
            this.Load += new System.EventHandler(this.frmAddEmployees_SalaryInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtjobname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox comboAccout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtinsurancevalues;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInsurancepersent;
    }
}