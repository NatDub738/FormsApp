﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        LentaF f2;
        Form2 f3;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new LentaF();
            f2.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            f3 = new Form2();
            f3.Show();
        }
    }
}
