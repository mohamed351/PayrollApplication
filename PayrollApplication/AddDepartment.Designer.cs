namespace PayrollApplication
{
    partial class AddDepartment
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
            this.dataviewDepartment = new System.Windows.Forms.DataGridView();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.btnAddManager = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataviewDepartment
            // 
            this.dataviewDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataviewDepartment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataviewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewDepartment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataviewDepartment.Location = new System.Drawing.Point(30, 382);
            this.dataviewDepartment.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dataviewDepartment.Name = "dataviewDepartment";
            this.dataviewDepartment.RowTemplate.Height = 24;
            this.dataviewDepartment.Size = new System.Drawing.Size(724, 384);
            this.dataviewDepartment.TabIndex = 0;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Image = global::PayrollApplication.Properties.Resources.add_icon;
            this.btnAddDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDepartment.Location = new System.Drawing.Point(614, 780);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(168, 49);
            this.btnAddDepartment.TabIndex = 1;
            this.btnAddDepartment.Text = "اضافة";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Font = new System.Drawing.Font("JF Flat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.Location = new System.Drawing.Point(195, 84);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtDepartmentName.MaxLength = 50;
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(407, 54);
            this.txtDepartmentName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "اسم القسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "وصف القسم";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("JF Flat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(195, 136);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtDescription.MaxLength = 160;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(407, 174);
            this.txtDescription.TabIndex = 6;
            // 
            // txtManagerName
            // 
            this.txtManagerName.Enabled = false;
            this.txtManagerName.Font = new System.Drawing.Font("JF Flat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerName.Location = new System.Drawing.Point(195, 320);
            this.txtManagerName.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtManagerName.MaxLength = 50;
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(407, 54);
            this.txtManagerName.TabIndex = 7;
            // 
            // btnAddManager
            // 
            this.btnAddManager.Font = new System.Drawing.Font("JF Flat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddManager.Location = new System.Drawing.Point(614, 320);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(75, 48);
            this.btnAddManager.TabIndex = 8;
            this.btnAddManager.Text = "+";
            this.btnAddManager.UseVisualStyleBackColor = true;
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "المدير";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 34);
            this.label4.TabIndex = 10;
            this.label4.Visible = false;
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(795, 845);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddManager);
            this.Controls.Add(this.txtManagerName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.dataviewDepartment);
            this.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة قسم";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataviewDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataviewDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.Button btnAddManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}