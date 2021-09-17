using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Text = "Editor";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.Text = "Editor - Top";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clack;
            clack = Width + 100;
            this.Width = clack;
            button4.Visible = true;
            if(checkBox1.Checked == true)
            {
                textBox1.Text = "é fusionario";
            }
            else
            {
                textBox1.Text = "não é fusionario";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Width = 423;
            button4.Visible = false;
        }
    }
}
