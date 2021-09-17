using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueA
{
    public partial class Form1 : Form
    {
        string nivel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nivel = "Gerencial";

            if (nivel == "Operacional")
            {
                estoqueToolStripMenuItem.Enabled = false;
            }
            else
            {
                estoqueToolStripMenuItem.Enabled = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Processando...";
            toolStripProgressBar1.Visible = true;

            for (int t = 0; t < 100000; t++)
            {
                toolStripProgressBar1.Value = t;
            }
            toolStripStatusLabel1.Text = "Finalizado";
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
