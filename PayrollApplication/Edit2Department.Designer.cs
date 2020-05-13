namespace PayrollApplication
{
    partial class Edit2Department
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
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add_Manager = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم القسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "الوصف";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.Location = new System.Drawing.Point(206, 118);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(429, 47);
            this.txtDepartmentName.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(208, 177);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(430, 210);
            this.txtDescription.TabIndex = 3;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(136, 153);
            this.labID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(0, 33);
            this.labID.TabIndex = 4;
            this.labID.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEdit.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(553, 478);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 51);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(377, 478);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 52);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtManager
            // 
            this.txtManager.Enabled = false;
            this.txtManager.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManager.Location = new System.Drawing.Point(198, 398);
            this.txtManager.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(441, 47);
            this.txtManager.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "المدير ";
            // 
            // btn_Add_Manager
            // 
            this.btn_Add_Manager.Location = new System.Drawing.Point(646, 399);
            this.btn_Add_Manager.Name = "btn_Add_Manager";
            this.btn_Add_Manager.Size = new System.Drawing.Size(75, 47);
            this.btn_Add_Manager.TabIndex = 9;
            this.btn_Add_Manager.Text = "+";
            this.btn_Add_Manager.UseVisualStyleBackColor = true;
            this.btn_Add_Manager.Click += new System.EventHandler(this.btn_Add_Manager_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 33);
            this.label4.TabIndex = 10;
            this.label4.Visible = false;
            // 
            // Edit2Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 564);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Add_Manager);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("JF Flat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Edit2Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل علي القسم";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add_Manager;
        private System.Windows.Forms.Label label4;
    }
}