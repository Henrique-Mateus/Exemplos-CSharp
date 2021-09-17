using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joguinho
{
    public partial class Form1 : Form
    {
        int num1 = 0;
        int num2 = 0;
        bool vez = true;

        public Form1()
        {
            InitializeComponent();
            label12.Text = "0X0";
        }

        public void X_venceu()
        {
            if (label1.Text == "X" && label2.Text == "X" && label3.Text == "X" ||
                label1.Text == "X" && label5.Text == "X" && label7.Text == "X" ||
                label1.Text == "X" && label6.Text == "X" && label9.Text == "X" ||
                label9.Text == "X" && label5.Text == "X" && label3.Text == "X" ||
                label7.Text == "X" && label4.Text == "X" && label3.Text == "X" ||
                label7.Text == "X" && label8.Text == "X" && label9.Text == "X" ||
                label5.Text == "X" && label2.Text == "X" && label8.Text == "X" ||
                label5.Text == "X" && label4.Text == "X" && label6.Text == "X")
            {
                button1.Text = "Proxima partida";
                num1 += 1;
                label12.Text = num1 + "X" + num2;
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                MessageBox.Show(label11.Text + " venceu");
            }
        }

        public void O_venceu()
        {
            if (label1.Text == "O" && label2.Text == "O" && label3.Text == "O" ||
                label1.Text == "O" && label5.Text == "O" && label7.Text == "O" ||
                label1.Text == "O" && label6.Text == "O" && label9.Text == "O" ||
                label9.Text == "O" && label5.Text == "O" && label3.Text == "O" ||
                label7.Text == "O" && label4.Text == "O" && label3.Text == "O" ||
                label7.Text == "O" && label8.Text == "O" && label9.Text == "O" ||
                label5.Text == "O" && label2.Text == "O" && label8.Text == "O" ||
                label5.Text == "O" && label4.Text == "O" && label6.Text == "O")
            {
                button1.Text = "Proxima partida";
                num2 += 1;
                label12.Text = num1 + "X" + num2;
                label1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                MessageBox.Show(label11 + " venceu");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (vez == true && label1.Text == "")
            {
                label1.Text = "X";
                vez = false;
                X_venceu();
            }
            else if (label1.Text == "")
            {
                label1.Text = "O";
                vez = true;
                O_venceu();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (vez == true && label2.Text == "")
            {
                label2.Text = "X";
                vez = false;
                X_venceu();
            }
            else if (label2.Text == "")
            {
                label2.Text = "O";
                vez = true;
                O_venceu();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (vez == true && label3.Text == "")
            {
                label3.Text = "X";
                vez = false;
                X_venceu();
            }
            else if (label3.Text == "")
            {
                label3.Text = "O";
                vez = true;
                O_venceu();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (vez == true && label4.Text == "")
            {
                label4.Text = "X";
                vez = false;
                X_venceu();
            }
            else if (label4.Text == "")
            {
                label4.Text = "O";
                vez = true;
                O_venceu();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (vez == true && label5.Text == "")
            {
                label5.Text = "X";
                vez = false;
                X_venceu();
            }
            else if (label5.Text == "")
            {
                label5.Text = "O";
                vez = true;
                O_venceu();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (vez == true && label6.Text == "")
            {
                label6.Text = "X";
                vez = false;
                X_venceu();
            }
            else if (label6.Text == "")
            {
                label6.Text = "O";
                vez = true;
                O_venceu();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (vez == true && label7.Text == "")
            {
                label7.Text = "X";
                vez = false;
                X_venceu();
            }
            else if (label7.Text == "")
            {
                label7.Text = "O";
                vez = true;
                O_venceu();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (vez == true && label8.Text == "")
            {
                label8.Text = "X";
                vez = false;
                X_venceu();
            }
            else if (label8.Text == "")
            {
                label8.Text = "O";
                vez = true;
                O_venceu();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (vez == true && label9.Text == "")
            {
                label9.Text = "X";
                vez = false;
                X_venceu();
            }
            else if (label9.Text == "")
            {
                label9.Text = "O";
                vez = true;
                O_venceu();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Restard";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            panel1.Visible = true;
            button1.Text = "Restard";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                label12.Text = "0X0";
                num1 = 0;
                num2 = 0;
                label10.Text = String.Format("Player1: {0}", textBox1.Text);
                label11.Text = String.Format("Player2: {0}", textBox2.Text);
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Escreva os nomes dos players.");
            }
        }
    }
}
