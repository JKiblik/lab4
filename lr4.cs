using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "5.3";
            textBox2.Text = "10.3";
            textBox3.Text = "0.25";
            textBox4.Text = "1.35";
            textBox5.Text = "-6.25";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            textBox6.Text = "Работу выполнил ст. Киблик" + Environment.NewLine;
            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y =a * x * x * x + Math.Pow(Math.Cos(x * x * x - b),2);
                textBox6.Text += "x=" + Convert.ToString(x) + ";y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

   
    }
}
