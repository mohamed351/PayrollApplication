namespace PayrollApplication
{
    partial class FrmEditPunishment
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
            this.btnedit = new System.Windows.Forms.Button();
            this.txtdecription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.IDvisiable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnedit
            // 
            this.btnedit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnedit.Image = global::PayrollApplication.Properties.Resources.edit_validated_icon__4_1;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnedit.Location = new System.Drawing.Point(421, 398);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(174, 63);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "تعديل";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtdecription
            // 
            this.txtdecription.Location = new System.Drawing.Point(148, 133);
            this.txtdecription.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtdecription.Multiline = true;
            this.txtdecription.Name = "txtdecription";
            this.txtdecription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdecription.Size = new System.Drawing.Size(447, 251);
            this.txtdecription.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "وصف الجزاء";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم الجزاء";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(148, 82);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(447, 42);
            this.txtname.TabIndex = 5;
            // 
            // IDvisiable
            // 
            this.IDvisiable.AutoSize = true;
            this.IDvisiable.Location = new System.Drawing.Point(129, 419);
            this.IDvisiable.Name = "IDvisiable";
            this.IDvisiable.Size = new System.Drawing.Size(0, 34);
            this.IDvisiable.TabIndex = 10;
            this.IDvisiable.Visible = false;
            // 
            // FrmEditPunishment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 485);
            this.Controls.Add(this.IDvisiable);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txtdecription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditPunishment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل الجزاءات ";
            this.Load += new System.EventHandler(this.FrmEditPunishment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txtdecription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label IDvisiable;
    }
}