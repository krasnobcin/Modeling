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
    public partial class Form4 : Form
    {
        public Form4()
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
                    double t;
                    double x = 0;
                    double x1;
                    double h;
                    double y;
                    double distance = double.Parse(textBox14.Text);
                    if (!checkBox1.Checked)
                    {
                        if (v1 < v2)
                        {
                            textBox9.Text = "Столкновения не произойдёт";
                        }
                        else
                        {
                            textBox12.Text = string.Format("{0:f4}", Math.Abs((v1 * (m1 - m2) + 2 * m2 * v2) / (m1 + m2)));
                            textBox10.Text = string.Format("{0:f4}", Math.Abs((v2 * (m2 - m1) + 2 * m1 * v1) / (m1 + m2)));
                            double v12 = double.Parse(string.Format("{0:f4}", textBox12.Text));
                            double v22 = double.Parse(string.Format("{0:f4}", textBox10.Text));
                            t = v2 * distance / ((v1 + v2) * v2);
                            h = Math.Round(t/10,4);
                            while (x < t)
                            {
                                y = x * v1;
                                chart1.Series[0].Points.AddXY(x, y);
                                y = distance - x * v2;
                                chart1.Series[1].Points.AddXY(x, y);
                                x += h;
                            }
                            x1 = x;
                            x = 0;
                            distance = v1 * t;
                            while (x < t)
                            {
                                y = distance - x * v12;
                                chart1.Series[0].Points.AddXY(x1, y);
                                y = distance + x * v22;
                                chart1.Series[1].Points.AddXY(x1, y);
                                x += h;
                                x1 += h;
                            }
                        }
                    }
                    else
                    {

                        textBox12.Text = string.Format("{0:f4}", Math.Abs((v1 * (m1 - m2) - 2 * m2 * v2) / (m1 + m2)));
                        textBox10.Text = string.Format("{0:f4}", Math.Abs((-1 * v2 * (m2 - m1) + 2 * m1 * v1) / (m1 + m2)));
                        double v12 = double.Parse(string.Format("{0:f4}", textBox12.Text));
                        double v22 = double.Parse(string.Format("{0:f4}", textBox10.Text));
                        t = t = v2 * distance / ((v1 + v2) * v2);
                        h = Math.Round(t/10,4);
                        while (x <= t)
                        {
                            y = x * v1;
                            chart1.Series[0].Points.AddXY(x, y);
                            y = distance - x * v2;
                            chart1.Series[1].Points.AddXY(x, y);
                            x += h / 2;
                        }
                        x1 = x;
                        x = 0;
                        distance = v1 * t;
                        while (x < t)
                        {
                            y = distance - x * v12;
                            chart1.Series[0].Points.AddXY(x1, y);
                            y = distance + x * v22;
                            chart1.Series[1].Points.AddXY(x1, y);
                            x += h;
                            x1 += h;
                        }
                    }
                }
                catch (FormatException)
                {
                    textBox9.Text = "Все значения должны быть числового типа (в дробных числах используется запятая).";
                }
            }
        }
    }
}
