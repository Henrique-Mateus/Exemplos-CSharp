using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form2 : Form
    {
        //-----------------Tipos de vitorias de O
        decimal t8 = 0;
        decimal t7 = 0;
        decimal t6 = 0;
        decimal t5 = 0;
        decimal t4 = 0;
        decimal t3 = 0;
        decimal t2 = 0;
        decimal t1 = 0;
        //-----------------Tipos de vitorias de X
        decimal v8 = 0;
        decimal v7 = 0;
        decimal v6 = 0;
        decimal v5 = 0;
        decimal v4 = 0;
        decimal v3 = 0;
        decimal v2 = 0;
        decimal v1 = 0;
        //------------------Pleies
        bool Pleier = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.LavenderBlush;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            VerLabelEntrada();

            if (Pleier == true)
            {
                this.panel1.Visible = false;
                lb1.Text = "X";
                Pleier = false;
                v2++;
                v3++;
                v4++;
                if (v2 > 2)
                {
                    MessageBox.Show("Player 1 ganho");
                }
                if (v3 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v4 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
            }
            else
            {
                this.panel1.Visible = false;
                lb1.Text = "O";
                Pleier = true;
                t2++;
                t3++;
                t4++;
                if (t2 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t3 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t4 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
            } VerLabelSaida();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {    
            this.panel2.BackColor = Color.LavenderBlush;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {

            VerLabelEntrada(); 

            if (Pleier == true)
            {
                this.panel2.Visible = false;
                lb2.Text = "X";
                Pleier = false;
                v3++;
                v1++;
                if (v3 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v1 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
            }
            else
            {
                this.panel2.Visible = false;
                lb2.Text = "O";
                Pleier = true;
                t3++;
                t1++;
                if (t3 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t1 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
            } VerLabelSaida();
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            this.panel3.BackColor = Color.LavenderBlush;         
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {

            VerLabelEntrada(); 

            if (Pleier == true)
            {
                this.panel3.Visible = false;
                lb3.Text = "X";
                Pleier = false;
                v3++;
                v6++;
                v7++;
                if (v3 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v6 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v7 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
            }
            else
            {
                this.panel3.Visible = false;
                lb3.Text = "O";
                Pleier = true;
                t3++;
                t6++;
                t7++;
                if (t3 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t6 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t7 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }

            } VerLabelSaida();
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            this.panel4.BackColor = Color.LavenderBlush;
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {

            VerLabelEntrada(); 

            if (Pleier == true)
            {
                this.panel4.Visible = false;
                lb4.Text = "X";
                Pleier = false;
                v4++;
                v8++;
                if (v4 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v8 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
            }
            else
            {
                this.panel4.Visible = false;
                lb4.Text = "O";
                Pleier = true;
                t4++;
                t8++;
                if (t4 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t8 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
            } VerLabelSaida();
        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            this.panel9.BackColor = Color.LavenderBlush;          
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            VerLabelEntrada();

            if (Pleier == true)
            {
                this.panel9.Visible = false;
                lb9.Text = "X";
                Pleier = false;
                v2++;
                v7++;
                v1++;
                if (v2 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v7 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v1 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
            }
            else
            {
                this.panel9.Visible = false;
                lb9.Text = "O";
                Pleier = true;
                t2++;
                t7++;
                t1++;
                if (t2 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t7 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t1 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
            } VerLabelSaida();
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {            
           this.panel6.BackColor = Color.LavenderBlush;
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {

            VerLabelEntrada(); 

            if (Pleier == true)
            {
                this.panel6.Visible = false;
                lb6.Text = "X";
                Pleier = false;
                v6++;
                v8++;
                if (v6 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v8 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
            }
            else
            {
                this.panel6.Visible = false;
                lb6.Text = "O";
                Pleier = true;
                t6++;
                t8++;
                if (t6 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t8 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
            } VerLabelSaida();
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.LavenderBlush;
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {

            VerLabelEntrada(); 

            if (Pleier == true)
            {
                this.panel5.Visible = false;
                lb5.Text = "X";
                Pleier = false;
                v4++;
                v5++;
                v7++;
                if (v4 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v5 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v7 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
            }
            else
            {
                this.panel5.Visible = false;
                lb5.Text = "O";
                Pleier = true;
                t4++;
                t5++;
                t7++;
                if (t4 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t5 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t7 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
            } VerLabelSaida();
        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            this.panel8.BackColor = Color.LavenderBlush;
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {

            VerLabelEntrada(); 

            if (Pleier == true)
            {
                this.panel8.Visible = false;
                lb8.Text = "X";
                Pleier = false;
                v5++;
                v1++;
                v8++;
                if (v5 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v1 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v8 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
            }
            else
            {
                this.panel8.Visible = false;
                lb8.Text = "O";
                Pleier = true;
                t5++;
                t1++;
                t8++;
                if (t5 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t1 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t8 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
            }
            VerLabelSaida();
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            this.panel7.BackColor = Color.LavenderBlush;
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {

            VerLabelEntrada(); 

            if (Pleier == true)
            {
                this.panel7.Visible = false;
                lb7.Text = "X";
                Pleier = false;
                v2++;
                v5++;
                v6++;
                if (v2 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v5 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
                if (v6 > 2)
                {
                    MessageBox.Show("Pleyer 1 ganho");
                }
            }
            else
            {
                this.panel7.Visible = false;
                lb7.Text = "O";
                Pleier = true;
                t2++;
                t5++;
                t6++;
                if (t2 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t5 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
                if (t6 > 2)
                {
                    MessageBox.Show("Pleyer 2 ganho");
                }
            }

            VerLabelSaida();


        }

        private void VerLabelEntrada()
        {
            if (Pleier)
            {
                label1.Text = "X";
            } 
            else
            {
                label1.Text = "0";
            }
        }

        private void VerLabelSaida()
        {
            if (Pleier)
            {
                label2.Text = "X";
            }
            else
            {
                label2.Text = "0";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

