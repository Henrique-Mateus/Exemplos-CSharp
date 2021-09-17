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
    public partial class Form1 : Form
    {
        string vNome;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string nomeUsu)
        {
            InitializeComponent();
            vNome = nomeUsu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = vNome;
        }
    }
}
