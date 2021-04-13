using System;
using System.Threading;
using System.Windows.Forms;

namespace Modeling
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Click += Button_Click;
            button2.Click += Button_Click;
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender as Button == button1)
            {
                try
                {
                    pictureBox1.Top = 320;
                    double speed = double.Parse(textBox1.Text);
                    double distance = double.Parse(textBox3.Text);
                    const double g = 9.81;
                    double t = (-speed + Math.Sqrt(speed * speed + 2 * g * distance)) / g;
                    textBox5.Text = string.Format("{0:f4}",t);
                    chart1.Series[0].Points.Clear();
                    chart2.Series[0].Points.Clear();
                    double x = 0;
                    double y;
                    double h = Math.Round(t/10,4); 
                    while (x <= t+h)
                    {
                        if (distance == 0)
                        {
                            chart1.Series[0].Points.AddXY(0, 0);
                            break;
                        }
                        y = distance -speed*x - g * x * x / 2;
                        chart1.Series[0].Points.AddXY(x, y);
                        y = speed + g * x;
                        chart2.Series[0].Points.AddXY(x, y);
                        x +=h;
                    }
                    int v = 0;
                    while (pictureBox1.Top < 530)
                    {
                        v += Convert.ToInt32(Math.Round(g * 0.25));
                        pictureBox1.Top += Convert.ToInt32(v);
                        Thread.Sleep(25);

                    }
                }
                catch (FormatException)
                {
                    textBox6.Text = "Все значения должны быть числового типа (в дробных числах используется запятая).";
                }
            }
            if (sender as Button == button2)
            {
                Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                Close();
            }

        }
    }
}
