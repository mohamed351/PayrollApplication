namespace PayrollApplication
{
    partial class FrmAddPunishment
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdecription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(141, 92);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(319, 42);
            this.txtname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الجزاء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "وصف الجزاء";
            // 
            // txtdecription
            // 
            this.txtdecription.Location = new System.Drawing.Point(143, 159);
            this.txtdecription.Multiline = true;
            this.txtdecription.Name = "txtdecription";
            this.txtdecription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdecription.Size = new System.Drawing.Size(317, 162);
            this.txtdecription.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Image = global::PayrollApplication.Properties.Resources.add_icon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(316, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 49);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "اضافة ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAddPunishment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 409);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtdecription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddPunishment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة جزاءات";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdecription;
        private System.Windows.Forms.Button btnAdd;
    }
}