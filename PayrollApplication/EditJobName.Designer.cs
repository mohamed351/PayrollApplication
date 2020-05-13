namespace PayrollApplication
{
    partial class EditJobName
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("JF Flat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(196, 104);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(304, 39);
            this.txtname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("JF Flat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("JF Flat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "الحد الاقصي  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("JF Flat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "الحد الادني :";
            // 
            // txtmax
            // 
            this.txtmax.Font = new System.Drawing.Font("JF Flat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmax.Location = new System.Drawing.Point(196, 160);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(304, 39);
            this.txtmax.TabIndex = 4;
            // 
            // txtmin
            // 
            this.txtmin.Font = new System.Drawing.Font("JF Flat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmin.Location = new System.Drawing.Point(196, 214);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(304, 39);
            this.txtmin.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(441, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "تعديل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            this.label4.Visible = false;
            // 
            // EditJobName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 340);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditJobName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل البيانات";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}