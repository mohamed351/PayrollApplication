namespace PayrollApplication
{
    partial class FrmEditEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.topdownNumic = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hiredate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.combodepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combojob = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cheackpassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.topdownNumic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 41);
            this.label1.TabIndex = 0;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(216, 108);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(343, 47);
            this.txtname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "المرتب";
            // 
            // topdownNumic
            // 
            this.topdownNumic.Location = new System.Drawing.Point(216, 169);
            this.topdownNumic.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.topdownNumic.Name = "topdownNumic";
            this.topdownNumic.Size = new System.Drawing.Size(120, 47);
            this.topdownNumic.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(659, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // hiredate
            // 
            this.hiredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hiredate.Location = new System.Drawing.Point(216, 237);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(296, 47);
            this.hiredate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "تاريخ التعين";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 41);
            this.label5.TabIndex = 8;
            this.label5.Text = "تاريخ الميلاد";
            // 
            // birthdate
            // 
            this.birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdate.Location = new System.Drawing.Point(216, 307);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(296, 47);
            this.birthdate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 41);
            this.label6.TabIndex = 10;
            this.label6.Text = "القسم";
            // 
            // combodepartment
            // 
            this.combodepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodepartment.FormattingEnabled = true;
            this.combodepartment.Location = new System.Drawing.Point(216, 374);
            this.combodepartment.Name = "combodepartment";
            this.combodepartment.Size = new System.Drawing.Size(298, 48);
            this.combodepartment.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "الوظيفة";
            // 
            // combojob
            // 
            this.combojob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combojob.FormattingEnabled = true;
            this.combojob.Location = new System.Drawing.Point(216, 450);
            this.combojob.Name = "combojob";
            this.combojob.Size = new System.Drawing.Size(298, 48);
            this.combojob.TabIndex = 13;
            this.combojob.SelectionChangeCommitted += new System.EventHandler(this.combojob_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 41);
            this.label8.TabIndex = 14;
            this.label8.Text = "الحالة الأجتماعية ";
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "عازب/عازبة",
            "متزوج /متزوجة",
            "ارمل / ارملة ",
            "مطلق /مطلفة "});
            this.comboStatus.Location = new System.Drawing.Point(216, 533);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(296, 48);
            this.comboStatus.TabIndex = 15;
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.White;
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "ذكر ",
            "انثي"});
            this.comboGender.Location = new System.Drawing.Point(216, 602);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(298, 48);
            this.comboGender.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 605);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 41);
            this.label9.TabIndex = 19;
            this.label9.Text = "النوع ";
            // 
            // txtpath
            // 
            this.txtpath.Enabled = false;
            this.txtpath.Location = new System.Drawing.Point(601, 375);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(433, 47);
            this.txtpath.TabIndex = 20;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(754, 428);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(172, 53);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.Text = "Browse ..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(527, 533);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 41);
            this.label10.TabIndex = 22;
            this.label10.Text = "اسم المستخدم";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(706, 530);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(343, 47);
            this.txtusername.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(565, 609);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 41);
            this.label11.TabIndex = 24;
            this.label11.Text = "كلمة المرور";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(706, 599);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(343, 47);
            this.txtpassword.TabIndex = 25;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnEdit
            // 
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEdit.Location = new System.Drawing.Point(873, 724);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(176, 57);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cheackpassword
            // 
            this.cheackpassword.AutoSize = true;
            this.cheackpassword.BackColor = System.Drawing.Color.White;
            this.cheackpassword.Location = new System.Drawing.Point(706, 653);
            this.cheackpassword.Name = "cheackpassword";
            this.cheackpassword.Size = new System.Drawing.Size(217, 45);
            this.cheackpassword.TabIndex = 27;
            this.cheackpassword.Text = "اظهار كلمة المرور";
            this.cheackpassword.UseVisualStyleBackColor = false;
            this.cheackpassword.CheckedChanged += new System.EventHandler(this.cheackpassword_CheckedChanged);
            // 
            // FrmEditEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 810);
            this.Controls.Add(this.cheackpassword);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combojob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combodepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hiredate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topdownNumic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات الموظفين";
            this.Load += new System.EventHandler(this.FrmEditEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topdownNumic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown topdownNumic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker hiredate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combodepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combojob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox cheackpassword;
    }
}