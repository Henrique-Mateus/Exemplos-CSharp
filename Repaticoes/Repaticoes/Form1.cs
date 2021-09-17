using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaticoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int cont = 0; cont < 50; cont = cont + 1)
            {
                //MessageBox.Show("Valor de cont é : "+cont);
                Console.WriteLine("Valor de cont é : " + cont);
            }
            Console.WriteLine("For terminado com sucesso ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fat = new Fatorial();
            fat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form inv = new MainpulaString();
            inv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form edt = new Encadeamento();
            edt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form cme = new ComandoWhile();
            cme.Show();
        }
    }
}
