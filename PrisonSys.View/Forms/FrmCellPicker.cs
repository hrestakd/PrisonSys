﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonSys.Forms
{
    public partial class FrmCellPicker : Form
    {
        public FrmCellPicker()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}