using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LugarDeTexts
{
    public partial class Form1 : Form
    {
        bool Tirrodetank = true;

        int pVelocidade = 0;

        int jp2;
        int jp1;
        int HFT;
        int PFT;

        int jp3;
        int jp4;
        int HT;
        int PT;
        public Form1()
        {
            InitializeComponent();
        }

        private void direita_Click(object sender, EventArgs e)
        {
            Direita();
        }

        private void isquerda_Click(object sender, EventArgs e)
        {
            Esquerda();
        }

        private void sima_Click(object sender, EventArgs e)
        {
            Subir();
        }

        private void baixo_Click(object sender, EventArgs e)
        {
            Descer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

                switch (e.KeyCode)
                {
                    case Keys.W:
                        Subir();
                        break;

                    case Keys.S:
                        Descer();
                        break;

                    case Keys.D:
                        Direita();
                        break;

                    case Keys.A:
                        Esquerda();
                        break;
                    case Keys.E:
                        Tirro();
                        break;
                        
                }

                switch (e.KeyCode)
                {
                    case Keys.I:
                        SubirT2();
                        break;

                    case Keys.K:
                        DescerT2();
                        break;

                    case Keys.L:
                        DireitaT2();
                        break;

                    case Keys.J:
                        EsquerdaT2();
                        break;

                    case Keys.O:
                        TirroT2();
                        break;
                }    
        }
        private void Subir() {
            label2.Text = tank1.Location.Y.ToString();
            HFT = Convert.ToInt16(label2.Text);
            HFT = HFT - 9;
            tank1.Location = new Point(jp2, HFT);
            label2.Text = "";
            label4.Text = Convert.ToString(HFT);
            jp1 = Convert.ToInt16(label4.Text);
        
        }
        private void Descer() {
            label2.Text = tank1.Location.Y.ToString();
            HFT = Convert.ToInt16(label2.Text);
            HFT = HFT + 9;
            tank1.Location = new Point(jp2, HFT);
            label2.Text = "";
            label4.Text = Convert.ToString(HFT);
            jp1 = Convert.ToInt16(label4.Text);
        
        }
        private void Esquerda() {
            tank1.ImageLocation = "d:/imagens/tank de texts1.png";
            label1.Text = tank1.Location.X.ToString();
            PFT = Convert.ToInt16(label1.Text);
            PFT = PFT - 9;
            tank1.Location = new Point(PFT, jp1);
            label1.Text = "";
            label3.Text = Convert.ToString(PFT);
            jp2 = Convert.ToInt16(label3.Text);
        
        }
        private void Direita() {
            tank1.ImageLocation = "d:/imagens/Tank de texts.jpg";
            label1.Text = tank1.Location.X.ToString();
            PFT = Convert.ToInt16(label1.Text);
            PFT = PFT + 9;
            tank1.Location = new Point(PFT, jp1);
            label1.Text = "";
            label3.Text = Convert.ToString(PFT);
            jp2 = Convert.ToInt16(label3.Text);
        
        }
        private void Tirro(){
            if (HPTANK2.Value == 0)
            {
                MessageBox.Show("TANK1 WIN");
                return;
            }
            if (tank1.Location.Y == tank2.Location.Y)
            {
                TirroDoTank1.Visible = true;
                TirroDoTank1.Location = new Point(tank1.Location.Y,tank1.Location.X);
                TirroDoTank1.Refresh();
                TirroDoTank1.Location = new Point(tank2.Location.Y, tank2.Location.X);
                //TirroDoTank1.Visible = false;

                HPTANK2.Value = HPTANK2.Value - 20;
            }

        }




        private void SubirT2()
        {
            // informações do segundo tanque
            label8.Text = tank2.Location.Y.ToString();
            HT = Convert.ToInt16(label8.Text);
            HT = HT - 9;
            tank2.Location = new Point(jp3, HT);
            label8.Text = "";
            label6.Text = Convert.ToString(HT);
            jp4 = Convert.ToInt16(label6.Text);

        }
        private void DescerT2()
        {
            label8.Text = tank2.Location.Y.ToString();
            HT = Convert.ToInt16(label8.Text);
            HT = HT + 9;
            tank2.Location = new Point(jp3, HT);
            label8.Text = "";
            label6.Text = Convert.ToString(HT);
            jp4 = Convert.ToInt16(label6.Text);

        }
        private void EsquerdaT2()
        {
            tank2.ImageLocation = "d:/imagens/tank de texts1.png";
            label9.Text = tank2.Location.X.ToString();
            PT = Convert.ToInt16(label9.Text);
            PT = PT - 9;
            tank2.Location = new Point(PT, jp4);
            label9.Text = "";
            label7.Text = Convert.ToString(PT);
            jp3 = Convert.ToInt16(label7.Text);

        }
        private void DireitaT2()
        {
            tank2.ImageLocation = "d:/imagens/Tank de texts.jpg";
            label9.Text = tank2.Location.X.ToString();
            PT = Convert.ToInt16(label9.Text);
            PT = PT + 9;
            tank2.Location = new Point(PT, jp4);
            label9.Text = "";
            label7.Text = Convert.ToString(PT);
            jp3 = Convert.ToInt16(label7.Text);

        }
        private void TirroT2()
        {
            if (HPTANK1.Value == 0)
            {
                MessageBox.Show("TANK2 WIN");
                return;
            }
            if (tank2.Location.Y == tank1.Location.Y)
            {
                TirroDoTank1.Visible = true;
                TirroDoTank1.Location = new Point(tank1.Location.Y, tank1.Location.X);
                TirroDoTank1.Refresh();
                TirroDoTank1.Location = new Point(tank2.Location.Y, tank2.Location.X);
                //TirroDoTank1.Visible = false;

                HPTANK1.Value = HPTANK1.Value - 20;
            }

        }

        private void tirro_Click(object sender, EventArgs e)
        {
            Tirro();
        }

        private void TirroDoTank1_Click(object sender, EventArgs e)
        {

        }




    }
}

