using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tomado_de_decizao
{
    public partial class Form1 : Form
    {
        int NumeroLAT;
        string nome1 = "Luke";
        string nome2 = "Nick";
        string nome3 = "Theo";
        string nome4 = "Billy";
        string nome5 = "Tobby";
        string nome6 = "Pingo";
        string nome7 = "ICO";
        string nome8 = "Noult";
        string nome9 = "Pitu";
        string nome10 = "Boris";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnDO_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(1,11);
            NumeroLAT = valorInteiro;
            if (NumeroLAT == 1)
            {
                tb1.Text = nome1;
            }
            else if (NumeroLAT == 2)
            {
                tb1.Text = nome2;
            }
            else if (NumeroLAT == 3)
            {
                tb1.Text = nome3;
            }
            else if (NumeroLAT == 4)
            {
                tb1.Text = nome4;
            }
            else if (NumeroLAT == 5)
            {
                tb1.Text = nome5;
            }
            else if (NumeroLAT == 6)
            {
                tb1.Text = nome6;
            }
            else if (NumeroLAT == 7)
            {
                tb1.Text = nome7;
            }
            else if (NumeroLAT == 8)
            {
                tb1.Text = nome8;
            }
            else if (NumeroLAT == 9)
            {
                tb1.Text = nome9;
            }
            else if (NumeroLAT == 10)
            {
                tb1.Text = nome10;
            }
        }
    }
}
