using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text); 
                int c = Convert.ToInt32(textBox3.Text);
                double xStart = Convert.ToDouble(textBox4.Text); 
                double xEnd = Convert.ToDouble(textBox5.Text);
                double dX = Convert.ToDouble(textBox6.Text);

                textBox7.Text = "|    X    |    F    |";
                textBox7.Text = "------------";

                for (double x = xStart; x <= xEnd; x += dX)
                {
                    double result;
                    int aInt = (int)a;
                    int bInt = (int)b;
                    int cInt = (int)c;

                    if (((aInt & bInt) != 0) || ((aInt & cInt) != 0))
                    {
                        result = a + Math.Sqrt(Math.Abs(x)) - Math.Pow(Math.Sin(b), 3) * Math.Pow(Math.Cos(c), 2);
                    }
                    else if ((x > 0) && (b == 0))
                    {
                        result = (x + a) / (x + c);
                    }
                    else
                    {
                        result = a*x / c*b;
                    }

                    if (result % 1 == 0)
                    {
                        textBox7.Text = $"{x} | {result:F0}";
                    }
                    else
                    {
                        textBox7.Text = $"{x} | {result:F2}";
                    }
                }
            }
            catch (Exception ex)
            {
                textBox7.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
