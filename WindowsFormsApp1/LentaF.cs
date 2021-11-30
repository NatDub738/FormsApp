using System;
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
    public partial class LentaF : Form
    {
        Lenta Lt = new Lenta();
        public LentaF()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lt.SupermarketTitle = "Лента";
            Lt.SupermarketAddress = textBox1.Text;
            Lt.Manager = textBox2.Text;
            Lt.Cashier = textBox3.Text;
        }
    }
}
