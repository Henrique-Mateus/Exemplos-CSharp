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
    public partial class Form1 : Form
    {
        string nome;
        int quantidade;
        double ValorCientifico;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // caracteres
            nome = "Henrique";
            char sexo;
            sexo = 'F';

            // numericos inteiros
            quantidade = 789;

            long distancia;
            distancia = 1726721L;

            // variaveis com casas decimal
            decimal nota;
            nota = 8.25M;

            ValorCientifico = 21567.2176762176;

            float cientificnum;
            cientificnum = 12545.787F;

            // Boolean
            bool comprou;
            comprou = true;
            comprou = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = nome;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(quantidade);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(ValorCientifico);
        }
    }
}
