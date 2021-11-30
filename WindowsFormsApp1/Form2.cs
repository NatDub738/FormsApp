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

    public partial class Form2 : Form
    {
        int countP;
        int MAX = 30;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameP = textBox1.Text;
            string ColStr = textBox2.Text;
            int ColInt;
            bool ColIntBool = int.TryParse(ColStr, out ColInt);
            bool flag = true;
            if (ColIntBool == true)
            {
                for (int i = 0; i < countP; i++)
                {
                    if (dataGridView1[1, i].Value.ToString() == nameP)
                    {
                        flag = false;
                        label2.Text = "    Внимание!   " + '\n' +
                         "  Данный товар уже есть в нашем магазине. ";
                    }

                }
                if (flag == true)
                {
                    if (ColInt > MAX)
                    {
                        ColInt = 30;
                        label2.Text = "    Внимание!   " + '\n' +
                         "  Количество товара превосходит максимальное!  " + '\n' +
                         "  Мы не можем поместить на склад более " + MAX + " единиц товара." + '\n' +
                         "  Товар был добавлен в каталог в максимально возможном количестве" + '\n' +
                         "  Теперь его можно найти на полках нашего магазина    ";
                    }
                    if (ColInt < 10)
                    {
                        ColInt = 10;
                        label2.Text = "    Внимание!   " + '\n' +
                         "  Количество товара слишком мало!  " + '\n' +
                         "  Мы не можем поместить на склад мение " + (MAX / 3) + " единиц товара." + '\n' +
                         "  Товар был добавлен в каталог в минимальном колличестве" + '\n' +
                         "  Теперь его можно найти на полках нашего магазина    ";
                    }
                    countP++;
                    dataGridView1.Rows.Add(countP, nameP, ColInt);
                }
            }
            else
            {
                label2.Text = "    Внимание!   " + '\n' +
                         "В поле ввода  <<исходное количество>> должно находиться число.";
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}