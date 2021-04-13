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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            button1.Click += Button_Click;
            button2.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender as Button == button1)
            {
                Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                Close();
            }
            if (sender as Button == button2)
            {
                try
                {
                    chart1.Series[0].Points.Clear();
                    chart1.Series[1].Points.Clear();
                    double m1 = double.Parse(textBox2.Text);
                    double m2 = double.Parse(textBox4.Text);
                    double v1 = double.Parse(textBox6.Text);
                    double v2 = double.Parse(textBox8.Text);
                    double v;
                    double distance = double.Parse(textBox10.Text);
                    double x=0;
                    double x1;
                    double y;
                    double t;
                    double h;
                    if (!checkBox1.Checked)
                    {
                        if (v1 <= v2)
                        {
                            textBox11.Text = "Столкновения не произойдёт";
                        }
                        else
                        {
                            t = distance / (v1 - v2);
                            textBox12.Text = string.Format("{0:f4}", Math.Abs((m1 * v1 + m2 * v2) / (m1 + m2)));
                            v = (m1 * v1 + m2 * v2) / (m1 + m2);
                            h = Math.Round(t/5,4);
                            while (x < t-h )
                            {
                                y = v1 * x;
                                chart1.Series[0].Points.AddXY(x, y);
                                y = distance + v2 * x;
                                chart1.Series[1].Points.AddXY(x, y);
                                x += h;
                            }
                            distance = v1 * t;
                            x1 = x;
                            x = 0;
                            while (x < t)
                            {
                                y = distance + x * v;
                                chart1.Series[0].Points.AddXY(x1, y);
                                chart1.Series[1].Points.AddXY(x1, y);
                                x += h;
                                x1 += h;
                            }
                        }
                    }
                    else
                    {
                        t = distance /(v1 + v2);
                        textBox12.Text = string.Format("{0:f4}", Math.Abs((m1 * v1 - m2 * v2) / (m1 + m2)));
                        v = (m1 * v1 - m2 * v2) / (m1 + m2);
                        h = Math.Round(t / 5,4);
                        while (x < t -h)
                        {
                            y = v1 * x;
                            chart1.Series[0].Points.AddXY(x, y);
                            y = distance - v2 * x;
                            chart1.Series[1].Points.AddXY(x, y);
                            x += h;
                        }
                        distance = v1 * t;
                        x1 = x;
                        x = 0;
                        while (x < t)
                        {
                            y = distance + x * v;
                            chart1.Series[0].Points.AddXY(x1, y);
                            chart1.Series[1].Points.AddXY(x1, y);
                            x += h;
                            x1 += h;
                        }
                    }
                }
                catch (FormatException)
                {
                    textBox11.Text= "Все значения должны быть числового типа(в дробных числах используется запятая).";
                }
            }
        }
    }
}
