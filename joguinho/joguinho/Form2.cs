using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joguinho
{
    public partial class Form2 : Form
    {
        int o = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnJogo_Aleatorio_Click(object sender, EventArgs e)
        {
            Random Jogo_Aleatorio = new Random();
            int Abri_Jogo = Jogo_Aleatorio.Next(1, 11);
        }

        private void btnJogo_da_velha_Click(object sender, EventArgs e)
        {
            Form jogo_da_velha = new Form1();
            jogo_da_velha.Show();
        }

        private void btnJogo_da_Memoria_Click(object sender, EventArgs e)
        {
            Form jogo_da_memoria = new Form3();
            jogo_da_memoria.Show();
        }
    }
}
