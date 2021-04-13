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
    public partial class Form7 : Form
    {
        public Form7()
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
                    chart1.Series[0].Points.Clear();
                    chart2.Series[0].Points.Clear();
                    double k = double.Parse(textBox2.Text);
                    double l = double.Parse(textBox1.Text);
                    double m = double.Parse(textBox5.Text);
                    double w = Math.Sqrt(k/m);
                    double T = 2 * Math.PI * Math.Sqrt(m / k);
                    double h = Math.Round(2 * Math.PI * Math.Sqrt(m / k) / 5,4);
                    textBox4.Text = string.Format("{0:f2}", k * l);
                    double x;
                    double y;
                    for (x = 0; x < 3 * T; x += h)
                    {
                        y = l * Math.Sin(w*x);
                        chart1.Series[0].Points.AddXY(x,y);
                        y = l * w * Math.Cos(w*x);
                        chart2.Series[0].Points.AddXY(x, y);
                    }

                }
                catch (FormatException)
                {
                    textBox3.Text = "Все значения должны быть числового типа (в дробных числах используется запятая).";
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
