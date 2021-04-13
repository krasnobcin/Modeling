using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeling
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button1.Click += Button_Click;
            button2.Click += Button_Click;
        }


        private void Button_Click(object sender, EventArgs e)
        {
            if (sender as Button == button2)
            {
                try
                {
                    double v = double.Parse(textBoxVo.Text);
                    double a = double.Parse(textBoxa.Text);
                    double rad = a * (Math.PI / 180);
                    const double g = 9.81;
                    chart1.Series[0].Points.Clear();
                    chart2.Series[0].Points.Clear();
                    chart2.Series[1].Points.Clear();
                    chart2.Series[2].Points.Clear();
                    textBox4.Text = string.Format("{0:f4}", v * v * Math.Sin(2 * rad) / g);
                    textBox4.Text += " м";
                    textBox6.Text = string.Format("{0:f4}", v * v * Math.Pow(Math.Sin(rad), 2) / (2 * g));
                    textBox6.Text += " м";
                    textBox7.Text = string.Format("{0:f4}", 2 * v * Math.Sin(rad) / g);
                    textBox7.Text += " с";
                    double t = 2 * v * Math.Sin(rad) / g;
                    double x = 0;
                    double y;
                    double L = v * v * Math.Sin(2 * rad) / g;
                    double h = Math.Round(L, 4);
                    if (a != 90 )
                    {
                        while (x <= L + h)
                        {
                            if (v == 0)
                            {
                                chart1.Series[0].Points.AddXY(0, 0);
                                break;
                            }
                            y = -(g * x * x / (2 * v * v * Math.Pow(Math.Cos(rad), 2))) + Math.Tan(rad) * x;
                            chart1.Series[0].Points.AddXY(x, y);
                            x += h;
                        }
                        x = 0;
                        h = Math.Round(t/5,4);
                    }
                    while (x <= t + h)
                    {
                        y = Math.Sqrt(v * v - 2 * v * Math.Sin(rad) * g * x + g * g * x * x);
                        chart2.Series[0].Points.AddXY(x, y);
                        y = v * Math.Sin(rad) - g * x;
                        chart2.Series[1].Points.AddXY(x, y);
                        y = v * Math.Cos(rad);
                        chart2.Series[2].Points.AddXY(x, y);
                        x += h;
                    }
                }
                catch (FormatException)
                {
                    textBox1.Text = "Все значения должны быть числового типа (в дробных числах используется запятая).";
                }
            }
            if (sender as Button == button1)
            {
                Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                Close();
            }
        }
    }
}
