using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaLoja
{
    public partial class fmCaixaLoja : Form
    {
        string[] codProd = new string[6];
        string[] nomeProd = new string[6];
        decimal[] preco = new decimal[6];
        decimal somaTotal;

        public fmCaixaLoja()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 5)
            {
                int ind = 0;
                for (int cp=1; cp<=5 ;cp++)
                {
                    if (textBox1.Text == codProd[cp])
                    {
                        ind=cp;
                    }
                }
                if (ind == 0)
                {
                    MessageBox.Show("Produto não encontrado");
                }
                else
                {
                listBox1.Items.Add(string.Format("#{0} {1}  R${2}",textBox1.Text , nomeProd[ind] , preco[ind]));

                somaTotal = somaTotal + preco[ind];
                label2.Text = string.Format("Valor total {0:C} ",somaTotal);
                pictureBox1.ImageLocation = "d:/imagens/" + codProd[ind] + ".jpg";
                textBox1.Text = "";
                textBox1.Focus();
                }
            }
        }

        private void fmCaixaLoja_Load(object sender, EventArgs e)
        {
            carregaArray();
            somaTotal = 0;
        }

        private void carregaArray()
        {
            //---------------------------------Codigo do Produto
            codProd[1] = "12345";
            codProd[2] = "12346";
            codProd[3] = "12347";
            codProd[4] = "12348";
            codProd[5] = "12349";
            //---------------------------------Nome do Produto
            nomeProd[1] = "Mantega";
            nomeProd[2] = "Garafa";
            nomeProd[3] = "Pão";
            nomeProd[4] = "Queijo";
            nomeProd[5] = "Presunto";
            //---------------------------------Preço do Produto
            preco[1] = 2.00M;
            preco[2] = 10.00M;
            preco[3] = 2.50M;
            preco[4] = 5.00M;
            preco[5] = 5.00M;
        }
    }
}
