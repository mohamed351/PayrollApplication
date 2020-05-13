namespace PayrollApplication
{
    partial class AttendForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataAttend = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.combolaberday = new System.Windows.Forms.ComboBox();
            this.btnSearchLabor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAttend)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("JF Flat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 38);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "السنة  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "شهر :";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("JF Flat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(423, 33);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 38);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "اليوم :";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("JF Flat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(725, 30);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 38);
            this.comboBox3.TabIndex = 5;
            // 
            // dataAttend
            // 
            this.dataAttend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAttend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAttend.Location = new System.Drawing.Point(11, 250);
            this.dataAttend.Name = "dataAttend";
            this.dataAttend.RowTemplate.Height = 24;
            this.dataAttend.Size = new System.Drawing.Size(905, 518);
            this.dataAttend.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(725, 95);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(191, 52);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "بحث";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // combolaberday
            // 
            this.combolaberday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combolaberday.Font = new System.Drawing.Font("JF Flat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combolaberday.FormattingEnabled = true;
            this.combolaberday.Location = new System.Drawing.Point(68, 65);
            this.combolaberday.Name = "combolaberday";
            this.combolaberday.Size = new System.Drawing.Size(246, 38);
            this.combolaberday.TabIndex = 8;
            // 
            // btnSearchLabor
            // 
            this.btnSearchLabor.Font = new System.Drawing.Font("JF Flat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLabor.Location = new System.Drawing.Point(335, 65);
            this.btnSearchLabor.Name = "btnSearchLabor";
            this.btnSearchLabor.Size = new System.Drawing.Size(166, 38);
            this.btnSearchLabor.TabIndex = 9;
            this.btnSearchLabor.Text = "بحث عن ايام العمل";
            this.btnSearchLabor.UseVisualStyleBackColor = true;
            this.btnSearchLabor.Click += new System.EventHandler(this.btnSearchLabor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchLabor);
            this.groupBox1.Controls.Add(this.combolaberday);
            this.groupBox1.Location = new System.Drawing.Point(21, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 154);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث عن العامل";
            // 
            // AttendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 780);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataAttend);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AttendForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAttend)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataAttend;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox combolaberday;
        private System.Windows.Forms.Button btnSearchLabor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}