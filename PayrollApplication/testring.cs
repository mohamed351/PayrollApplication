﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollApplication
{
    public partial class testring : Form
    {
        public testring(DataTable table1 , DataTable table2)
        {
            InitializeComponent();

            dataGridView1.DataSource = table1;
            dataGridView2.DataSource = table2;
        }
    }
}
