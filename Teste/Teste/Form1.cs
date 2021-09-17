using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class frmInicial : Form
    {
        bool Erro = true;
        public frmInicial()
        {
            InitializeComponent();
        }

        private void critica()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Erro!!,Iscreva nome de Pleier1");
                Erro = false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Erro!!,Iscreva nome de Pleier2");
                Erro = false;
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            critica();
            if (Erro == false)
            {
                Erro = true;
                return;
            }
                
                Form Form2 = new Form2();
                Form2.Show();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }
    }
}