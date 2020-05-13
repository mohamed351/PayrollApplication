namespace PayrollApplication
{
    partial class Employees
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.labDepartment = new System.Windows.Forms.Label();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.comboJobTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minandMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dateHire = new System.Windows.Forms.DateTimePicker();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minandMax)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1101, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ادخال بيانات الموظفين";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtname);
            this.groupBox3.Controls.Add(this.labDepartment);
            this.groupBox3.Controls.Add(this.comboDepartment);
            this.groupBox3.Controls.Add(this.comboJobTitle);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.minandMax);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dateHire);
            this.groupBox3.Controls.Add(this.comboGender);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateBirth);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboStatus);
            this.groupBox3.Location = new System.Drawing.Point(42, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 581);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الموظفين";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(154, 41);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(234, 42);
            this.txtname.TabIndex = 3;
            // 
            // labDepartment
            // 
            this.labDepartment.AutoSize = true;
            this.labDepartment.BackColor = System.Drawing.Color.White;
            this.labDepartment.Location = new System.Drawing.Point(85, 107);
            this.labDepartment.Name = "labDepartment";
            this.labDepartment.Size = new System.Drawing.Size(72, 34);
            this.labDepartment.TabIndex = 0;
            this.labDepartment.Text = "القسم";
            // 
            // comboDepartment
            // 
            this.comboDepartment.BackColor = System.Drawing.Color.White;
            this.comboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Location = new System.Drawing.Point(163, 99);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(225, 42);
            this.comboDepartment.TabIndex = 1;
            // 
            // comboJobTitle
            // 
            this.comboJobTitle.BackColor = System.Drawing.Color.White;
            this.comboJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJobTitle.FormattingEnabled = true;
            this.comboJobTitle.Location = new System.Drawing.Point(164, 152);
            this.comboJobTitle.Name = "comboJobTitle";
            this.comboJobTitle.Size = new System.Drawing.Size(225, 42);
            this.comboJobTitle.TabIndex = 21;
            this.comboJobTitle.SelectionChangeCommitted += new System.EventHandler(this.comboJobTitle_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "الاسم";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 34);
            this.label8.TabIndex = 20;
            this.label8.Text = "الوظيفة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "المرتب";
            // 
            // minandMax
            // 
            this.minandMax.Location = new System.Drawing.Point(163, 214);
            this.minandMax.Name = "minandMax";
            this.minandMax.Size = new System.Drawing.Size(219, 42);
            this.minandMax.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "تاريخ التعين";
            // 
            // dateHire
            // 
            this.dateHire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHire.Location = new System.Drawing.Point(164, 274);
            this.dateHire.Name = "dateHire";
            this.dateHire.Size = new System.Drawing.Size(225, 42);
            this.dateHire.TabIndex = 7;
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.White;
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "ذكر ",
            "انثي"});
            this.comboGender.Location = new System.Drawing.Point(168, 443);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(231, 42);
            this.comboGender.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = " تاريخ الميلاد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "النوع ";
            // 
            // dateBirth
            // 
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirth.Location = new System.Drawing.Point(168, 333);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(225, 42);
            this.dateBirth.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "LE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "الحالة الأجتماعية";
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
            this.comboStatus.Location = new System.Drawing.Point(168, 391);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(226, 42);
            this.comboStatus.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnbrowse);
            this.groupBox2.Controls.Add(this.picEmployee);
            this.groupBox2.Controls.Add(this.txtpath);
            this.groupBox2.Location = new System.Drawing.Point(501, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 361);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الصورة الشخصية";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(154, 308);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(197, 47);
            this.btnbrowse.TabIndex = 11;
            this.btnbrowse.Text = "Browse ..";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // picEmployee
            // 
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.Location = new System.Drawing.Point(151, 33);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(200, 223);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 10;
            this.picEmployee.TabStop = false;
            // 
            // txtpath
            // 
            this.txtpath.Enabled = false;
            this.txtpath.Location = new System.Drawing.Point(104, 260);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(306, 42);
            this.txtpath.TabIndex = 12;
            this.txtpath.TextChanged += new System.EventHandler(this.txtpath_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Location = new System.Drawing.Point(501, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 221);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الحساب المؤقتة ";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(177, 124);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(266, 42);
            this.txtpassword.TabIndex = 25;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 34);
            this.label10.TabIndex = 24;
            this.label10.Text = "كلمة المرور";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 34);
            this.label9.TabIndex = 23;
            this.label9.Text = "اسم المستخدم";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(177, 67);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(266, 42);
            this.txtusername.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PayrollApplication.Properties.Resources.add_icon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(806, 593);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 52);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(28, 108);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1109, 713);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtsearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1101, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "بيانات الموظفين";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(724, 597);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(240, 42);
            this.button7.TabIndex = 8;
            this.button7.Text = "طباعة البيانات الشخصية";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(528, 597);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 42);
            this.button6.TabIndex = 7;
            this.button6.Text = "طباعة ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(264, 597);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(258, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "طباعة البيانات الشخصية";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 597);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "تعديل ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 523);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(855, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "البيانات كاملة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsearch.Location = new System.Drawing.Point(15, 20);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(640, 42);
            this.txtsearch.TabIndex = 0;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(15, 79);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1118, 23);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "بيانات الموظفين";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 824);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال بيانات الموظفين";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minandMax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label labDepartment;
        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.ComboBox comboJobTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minandMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateHire;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnAdd;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}