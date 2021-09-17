using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ArrayList Produto = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Produto.Add("Martelo");
            Produto.Add("Chave Fenda");
            Produto.Add("Chave Inglesa");
            Produto.Add("Parafuso");
            Produto.Add("Escada");
            Produto.Add("Messa");
            Produto.Add("Fita");
            label1.Text = Convert.ToString(Produto.Count);

            SortedList sl = new SortedList();
            sl.Add(12345,"BBBBB");
            sl.Add(2222222,"CCCC");
            label3.Text = Convert.ToString(sl.IndexOfKey(2222222));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("PorFavor iscreva um numero de 1...7");
                return;
            }

            int ind = Convert.ToInt16(textBox1.Text);
            if (ind > Produto.Count)
            {
                MessageBox.Show("Valor acima da quatidade de itens");
                return;
            }
            label2.Text = Convert.ToString(Produto[ind-1]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object a = textBox2.Text;
            //Produto.Sort();
            //label3.Text = Convert.ToString(Produto.BinarySearch(a));

            for (int x = 0; x <= Produto.Count - 1; x++)
            {
                if (Convert.ToString(Produto[x]) == textBox2.Text)
                {
                    label3.Text = Convert.ToString(x);
                }
            }
        }
    }
}
