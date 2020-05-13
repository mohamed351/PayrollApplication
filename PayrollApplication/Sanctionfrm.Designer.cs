namespace PayrollApplication
{
    partial class Sanctionfrm
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.idvisiable = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(13, 83);
            this.datagrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(756, 343);
            this.datagrid.TabIndex = 0;
            this.datagrid.Click += new System.EventHandler(this.datagrid_Click);
            // 
            // idvisiable
            // 
            this.idvisiable.AutoSize = true;
            this.idvisiable.Location = new System.Drawing.Point(33, 507);
            this.idvisiable.Name = "idvisiable";
            this.idvisiable.Size = new System.Drawing.Size(0, 34);
            this.idvisiable.TabIndex = 5;
            this.idvisiable.Visible = false;
            // 
            // btnprint
            // 
            this.btnprint.Image = global::PayrollApplication.Properties.Resources.print_icon;
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprint.Location = new System.Drawing.Point(585, 435);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(175, 62);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "طباعة";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Enabled = false;
            this.btndelete.Image = global::PayrollApplication.Properties.Resources.edit_not_validated_icon_3;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.Location = new System.Drawing.Point(404, 435);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(175, 62);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "مسح";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Enabled = false;
            this.btnedit.Image = global::PayrollApplication.Properties.Resources.edit_not_validated_icon_3;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnedit.Location = new System.Drawing.Point(207, 435);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(175, 62);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "تعديل";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PayrollApplication.Properties.Resources.add_icon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(14, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 62);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Sanctionfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 529);
            this.Controls.Add(this.idvisiable);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.datagrid);
            this.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sanctionfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الجزاءات ";
            this.Load += new System.EventHandler(this.Sanctionfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label idvisiable;
    }
}