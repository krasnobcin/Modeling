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
    public partial class Form6 : Form
    {
        public Form6()
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
                    double v = double.Parse(textBox1.Text);
                    double r = double.Parse(textBox3.Text);
                    chart1.Series[0].Points.Clear();
                    double w = v / r;
                    textBox4.Text = string.Format("{0:f4}", w);
                    textBox2.Text = string.Format("{0:f4}", 2*Math.PI*r/v);
                    double T = double.Parse(textBox2.Text);
                    textBox2.Text += " с";
                    textBox4.Text += " рад/с";
                    double x = 0;
                    double y ;
                    double h = T / 5;
                    while (x <= T*3)
                    {
                        y = Math.PI * r * Math.Sin(w*x);
                        chart1.Series[0].Points.AddXY(x,y);
                        x += h;
                    }
                }
                catch (FormatException)
                {
                    textBox5.Text = "Все значения должны быть числового типа (в дробных числах используется запятая).";
                }
            }
            if (( sender as Button ) == button1)
            {
                Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                Close();
            }
        }
    }
}
