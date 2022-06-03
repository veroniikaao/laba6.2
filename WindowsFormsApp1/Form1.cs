using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double a, b, c;
        private double x, y, x1;

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(checkBox1.Checked==false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false && checkBox7.Checked == false && checkBox8.Checked == false)
            {
                MessageBox.Show("Выберите одну функцию!");
                return;
            }

            if (textBox_a.Text=="" || textBox_b.Text=="" || textBox_c.Text == "" || textBox_x.Text == "")
            {
                MessageBox.Show("Укажите все параметры!");
                  
            }
                a = Convert.ToInt32(textBox_a.Text);
                b = Convert.ToDouble(textBox_b.Text);
                c = Convert.ToDouble(textBox_c.Text);
                x1 = Convert.ToDouble(textBox_x.Text);
                double h = 0.1;
                int i = -15;
                int j = 20;
            if (checkBox1.Checked)
            {
                x = i;
                while (x <= j)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = x * a + b;
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else 
                    {
                        y = x * a + b;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (checkBox2.Checked)
            {
                x = i;
                while (x <= j)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = a * Math.Sin(x * b) + c;
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = a * Math.Sin(x * b) + c;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }

            }
            if (checkBox3.Checked)
            {
                x = i;
                while (x <= j)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = a * Math.Cos(x * b + c);
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = a * Math.Cos(x * b + c);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (checkBox4.Checked)
            {
                x = i;
                while (x <= j)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = a * Math.Tan(x * b) + c;
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = a * Math.Tan(x * b) + c;
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (checkBox5.Checked)
            {
                x = i;
                while (x <= j)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = a * (1 / Math.Tan(x * b + c));
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = a *(1/ Math.Tan(x * b + c));
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (checkBox6.Checked)
            {
                x = i;
                while (x <= j)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = b * Math.Pow(x, a);
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = b * Math.Pow(x, a);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (checkBox7.Checked)
            {
                x = i;
                while (x <= j)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        y = Math.Pow(a , (x + b));
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        y = b * Math.Pow(x, a);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
            if (checkBox8.Checked)
            {
                x = i;
                while (x <= j)
                {
                    var x2 = Math.Round(x, 1);
                    if (x2 == x1)
                    {
                        if ((x - Math.Pow(x, 0.5)) + 1 == 0) // одз
                        {
                            x += h;
                        }
                        else if (x == 0) //одз
                        {
                            x += h;
                        }
                        y = Math.Pow((Math.Sin(x) + a * x) / ((x - Math.Pow(x, 0.5)) + 1), (b / x));
                        chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    else
                    {
                        if ((x- Math.Pow(x,0.5)) + 1 == 0)
                        {
                            x += h;
                        }
                        else if (x == 0)
                        {
                            x += h;
                        }
                        y = Math.Pow((Math.Sin(x) + a * x) / ((x - Math.Pow(x, 0.5)) + 1), (b / x));
                        chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
            }
        }
       
    }
}
