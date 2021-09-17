using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lembrasa2021_2017
{
    public partial class Form1 : Form
    {
        string Ano = DateTime.Now.Year.ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                if (Ano == "2030")
                {
                    MessageBox.Show("Seja Bem Vindo ao seu passado Henrique :)");
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Mentira Hoje não e 2030");
                }
            }
            else 
            {
                MessageBox.Show("Então espere chegar 2030");
                Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
