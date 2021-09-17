using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaLoja
{
    public partial class Formula1 : Form
    {
        decimal[] tempodecarro;
        int toto;

        public Formula1()
        {
            InitializeComponent();
        }
        
        private void Formula1_Load(object sender, EventArgs e)
        {
            tempodecarro = new decimal [10];
            toto = 0;
            label3.Text = "quatidade" + toto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toto++;
            tempodecarro[toto] = Convert.ToDecimal(txttempo.Text);
            label3.Text = "quatidade" + toto;
            txttempo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal v_soma = 0;
            decimal v_melhor = tempodecarro[1];

            for (int t = 1; t <= toto ; t++)
            {
                v_soma = v_soma + tempodecarro[t];
                if (v_melhor > tempodecarro[t])
                {
                    v_melhor = tempodecarro[t];
                }
            }
            decimal v_media;
            v_media = v_soma / toto;
            textBox1.Text = Convert.ToString(v_media);
            textBox2.Text = Convert.ToString(v_melhor);
        }
    }
}
