using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaticoes
{
    public partial class MainpulaString : Form
    {
        public MainpulaString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tamanho = textBox1.TextLength;
            string saida = "";
            //for (int t = tamanho; t > 0; t--)
            //{
            //    saida = saida + textBox1.Text.Substring(t - 1, 1);
            //}
            //textBox2.Text = saida;

            //for (int t = 1; t <= tamanho; t++)
            //{
            //    if (textBox1.Text.Substring(t - 1, 1) == "%")
            //    {
            //        saida = saida + "perc";
            //    }
            //    else
            //    {
            //        saida = saida + textBox1.Text.Substring(t - 1, 1);
            //    }
            //}

            //saida = textBox1.Text.Replace("%", "Perc");

            textBox2.Text = saida;
        }
    }
}
