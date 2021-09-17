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
    public partial class frmbaixaEstoque : Form
    {
        string vNome;

        public frmbaixaEstoque()
        {
            InitializeComponent();
        }

        public frmbaixaEstoque(string nomeUsu)
        {
            InitializeComponent();
            vNome = nomeUsu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmbaixaEstoque_Load(object sender, EventArgs e)
        {
            label1.Text = vNome;
        }
    }
}
