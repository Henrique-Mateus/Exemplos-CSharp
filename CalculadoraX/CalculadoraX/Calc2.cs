using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraX
{
    public partial class Calc2 : Form
    {
        double valorMem;

        public Calc2()
        {
            InitializeComponent();
        }

        private void Mais_Click(object sender, EventArgs e)
        {
            valorMem = valorMem + Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void Calc2_Load(object sender, EventArgs e)
        {
            valorMem = 0;
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            valorMem = valorMem - Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void Vezis_Click(object sender, EventArgs e)
        {
            valorMem = valorMem * Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            valorMem = valorMem / Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(valorMem);
        }
    }
}
