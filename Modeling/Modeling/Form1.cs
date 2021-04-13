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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button_Click;
            button3.Click += Button_Click;
            button2.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button4.Click += Button_Click;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Hide();
            if ((sender as Button) == button1)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                Close();
            }
            if ((sender as Button) == button2)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
                Close();
            }
            if ((sender as Button) == button3)
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
                Close();
            }
            if ((sender as Button) == button5)
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();
                Close();
            }
            if ((sender as Button) == button6)
            {
                Form7 form7 = new Form7();
                form7.ShowDialog();
                Close();
            }
            if (sender as Button == button4)
            {
                Form5 form5 = new Form5();
                form5.ShowDialog();
                Close();
            }

        }
    }
}
