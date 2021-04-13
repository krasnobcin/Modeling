
namespace Modeling
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxVo = new System.Windows.Forms.TextBox();
            this.textBoxa = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1152, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxVo
            // 
            this.textBoxVo.Location = new System.Drawing.Point(12, 31);
            this.textBoxVo.Name = "textBoxVo";
            this.textBoxVo.Size = new System.Drawing.Size(200, 20);
            this.textBoxVo.TabIndex = 1;
            // 
            // textBoxa
            // 
            this.textBoxa.Location = new System.Drawing.Point(12, 77);
            this.textBoxa.Name = "textBoxa";
            this.textBoxa.Size = new System.Drawing.Size(200, 20);
            this.textBoxa.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1027, 98);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(200, 40);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1027, 163);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(200, 40);
            this.textBox7.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1027, 33);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(200, 40);
            this.textBox4.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(13, 211);
            this.chart1.Name = "chart1";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.MarkerSize = 1;
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(480, 330);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "График движения тела ";
            this.chart1.Titles.Add(title5);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 100);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Окно ошибок";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(499, 211);
            this.chart2.Name = "chart2";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.MarkerSize = 1;
            series10.Name = "Скорость тела";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "Вертикальная скорость тела";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Горизонтальная скорость тела";
            this.chart2.Series.Add(series10);
            this.chart2.Series.Add(series11);
            this.chart2.Series.Add(series12);
            this.chart2.Size = new System.Drawing.Size(728, 330);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            title6.Name = "Title1";
            title6.Text = "Зависимость скорости тела от времени";
            this.chart2.Titles.Add(title6);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(200, 13);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Начальная скорость (в м/с)";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(13, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(200, 13);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Угол (в градусах)";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(1027, 144);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(200, 13);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Время полёта (в секундах)";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(1027, 79);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(200, 13);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "Максимальная высота (в метрах)";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(1027, 12);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(200, 13);
            this.textBox9.TabIndex = 17;
            this.textBox9.Text = "Дальность полёта (в метрах)";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 636);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxa);
            this.Controls.Add(this.textBoxVo);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Движение под углом к горизонту";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxVo;
        private System.Windows.Forms.TextBox textBoxa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}