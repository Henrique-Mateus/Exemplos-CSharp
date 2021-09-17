using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresaA.ProjetoX.Model;
using EmpresaA.Core;

namespace EmpresaA.ProjetoX
{
    public partial class fmCadCliente : Form
    {
        public fmCadCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DadosEmpresa de = new DadosEmpresa();
            label5.Text = de.Nome;

            Button a = new Button();

            Point p = new Point(190,115);
            a.Location = p;
            a.Text = "Entre";
            this.Controls.Add(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cliente a = new Cliente();
            //a.Nome = textBox1.Text;
            //a.Telefone = maskedTextBox1.Text;
            //a.Endereso = textBox2.Text;

            Cliente a = new Cliente(textBox1.Text, maskedTextBox1.Text, textBox2.Text);

            label4.Text = a.DisplayDDD();
            label5.Text = Convert.ToString(Cliente.verficar_cadastro());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
