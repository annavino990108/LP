using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox1.Text);
            textBox3.Text += "Результаты программы" + Environment.NewLine;
            textBox3.Text += "  X = " + textBox1.Text + Environment.NewLine;
            textBox3.Text += "  Y = " + textBox2.Text + Environment.NewLine;

            //Вычисление выражения
            double d;
            double z;

            if (x > y)
            d = Math.Pow((Math.Pow(x, 2) - y), 3) + Math.Atan(Math.Pow(x, 2));
            else
                if (y>x)
                    d = Math.Pow(y - (Math.Pow(x, 2)), 3) + Math.Atan(Math.Pow(x, 2));
                else
                   d = Math.Pow(y + (Math.Pow(x, 2)), 3) + 0.5;
            //Вывод результата
            textBox3.Text += "  D = " + d.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
