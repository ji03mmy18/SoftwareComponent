using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareComponent_W3
{
    public partial class Form1 : Form
    {
        bool isClick = false;
        public Form1()
        {
            InitializeComponent();
            label5.Text = DateTime.Now.ToLongDateString() + "\n" +  DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isClick = true;
            label5.Text = "Hello, " + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isClick = false;
            label5.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isClick == false)
            {
                label5.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
            }
        }
    }
}
