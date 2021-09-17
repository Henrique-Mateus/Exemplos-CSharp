using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //---------------------Decimais
            decimal vSalario;
            decimal vPercIR;
            //---------------------Criticas
            if (textBox1.Text == "")
            {
                MessageBox.Show("Valor de salario deve ser fornecido!", "Erro campo Salário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                vSalario = Convert.ToDecimal(textBox1.Text);
                if (Convert.ToDecimal(textBox1.Text) < 540M)
                {
                    MessageBox.Show("Valor de salario não pode ser meno doque o salario mínimo!");
                }

                if (Convert.ToDecimal(textBox1.Text) > 27000M)
                {
                    MessageBox.Show("Valor de salario não pode ser maior que o Teto Nacional");
                }
                //---------------------Plano de Saude
                if (vSalario > 1000 && checkBox1.Checked)
                {
                    vSalario = vSalario - 100;
                }
                //---------------------Data da Folha
                if (dateTimePicker1.Value.Month == 12)
                {
                    vSalario = vSalario * 2;
                }
                //---------------------Clubi de Lazer
                switch (comboBox1.Text)
                {
                    case "Clube A":
                        vSalario = vSalario - 100;
                        break;
                    case "Clube B":
                        vSalario = vSalario - 50;
                        break;
                    case "Clube C":
                        vSalario = vSalario - 10;
                        break;
                    default:
                        break;
                }
                //---------------------Salario Liquido
                vPercIR = 0;

                if (vSalario > 0 && vSalario < 1500)
                {
                    vPercIR = 0;
                }
                else if (vSalario > 1500 && vSalario <= 2500)
                {
                    vPercIR = 5;
                }
                else if (vSalario > 1500 && vSalario <= 5000)
                {
                    vPercIR = 10;
                }
                else if (vSalario > 5000)
                {
                    vPercIR = 20;
                }
                //---------------------Resebedores
                textBox3.Text = Convert.ToString(vSalario);
                textBox2.Text = Convert.ToString(vSalario * vPercIR / 100M);
                textBox4.Text = Convert.ToString(vSalario - (vSalario * vPercIR / 100M));
            }
        }
    }
}
