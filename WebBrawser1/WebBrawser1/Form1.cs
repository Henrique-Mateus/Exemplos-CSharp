using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrawser1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVoutar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btir_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btEstop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCotinuar_Click(object sender, EventArgs e)
        {

        }
    }
}
