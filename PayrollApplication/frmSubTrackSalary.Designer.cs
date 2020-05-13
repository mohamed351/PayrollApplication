namespace PayrollApplication
{
    partial class frmSubTrackSalary
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
            this.comboSen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtamont = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJustification = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الجزاء ";
            // 
            // comboSen
            // 
            this.comboSen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSen.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSen.FormattingEnabled = true;
            this.comboSen.Location = new System.Drawing.Point(189, 140);
            this.comboSen.Name = "comboSen";
            this.comboSen.Size = new System.Drawing.Size(567, 42);
            this.comboSen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "المبلغ";
            // 
            // txtamont
            // 
            this.txtamont.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamont.Location = new System.Drawing.Point(189, 226);
            this.txtamont.Multiline = true;
            this.txtamont.Name = "txtamont";
            this.txtamont.Size = new System.Drawing.Size(250, 38);
            this.txtamont.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = " التبرير ";
            // 
            // txtJustification
            // 
            this.txtJustification.Font = new System.Drawing.Font("JF Flat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJustification.Location = new System.Drawing.Point(189, 306);
            this.txtJustification.Multiline = true;
            this.txtJustification.Name = "txtJustification";
            this.txtJustification.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJustification.Size = new System.Drawing.Size(567, 143);
            this.txtJustification.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 800);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "اضافة ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 475);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 300);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(320, 800);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "تعديل";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(590, 800);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 45);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "مسح";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSubTrackSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 869);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJustification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtamont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboSen);
            this.Controls.Add(this.label1);
            this.Name = "frmSubTrackSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الخصوصات علي المرتب ";
            this.Load += new System.EventHandler(this.frmSubTrackSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtamont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJustification;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
    }
}