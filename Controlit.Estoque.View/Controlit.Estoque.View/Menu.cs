using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlit.Estoque.View
{
    public partial class Menu : Form
    {
        string vNome;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(string nomeUsu)
        {
            InitializeComponent();
            vNome = nomeUsu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmcad = new Form1(label1.Text);
            frmcad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmbst = new frmbaixaEstoque(label1.Text);
            frmbst.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label1.Text = vNome;
        }
    }
}
