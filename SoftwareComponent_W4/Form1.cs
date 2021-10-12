using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareComponent_W4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 48516927112121245664.45116;
            string b = "Hello, YoMin";
            string c = String.Format("{0}是{1}的倍數", 25, 5);
            string d = String.Format("{0}是{1}的倍數", 2, 2*12);
            textBox1.Text = a.ToString();
            textBox2.Text = b;
            textBox3.Text = c;
            textBox4.Text = d;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double value = 0;
            double money = double.Parse(textBox5.Text);
            double yrate = double.Parse(textBox6.Text) / 100;
            double mrate = yrate / 12;
            int year = int.Parse(textBox7.Text);
            double month = year * 12;

            value = money * (Math.Pow((1 + mrate), month) * mrate) / (Math.Pow((1 + mrate), month) - 1);
            label10.Text = value.ToString();
        }
    }
}
