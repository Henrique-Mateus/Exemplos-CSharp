using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        SoundPlayer p = new SoundPlayer();
        int segundo = 0;
        int minuto = 0;
        int hora = 0;
        int play = 1;
        bool sem_continua = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPara_Click(object sender, EventArgs e)
        {
            p.Stop();
            
            timer1.Enabled = false;

            btnPlay.Enabled = true;
            if(sem_continua == false)
            {
                BtnContinue.Enabled = true;
            }
            BtnPara.Enabled = false;
            CmbSegundo.Enabled = true;
            CmbMinuto.Enabled = true;
            CmbHora.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            segundo = Convert.ToInt16(CmbSegundo.Text);
            minuto = Convert.ToInt16(CmbMinuto.Text);
            hora = Convert.ToInt16(CmbHora.Text);
            play = 0;

            LblTempo1.Text = CmbHora.Text;
            LblTempo2.Text = CmbMinuto.Text;
            LblTempo3.Text = CmbSegundo.Text;

            timer1.Enabled = true;

            btnPlay.Enabled = false;
            BtnPara.Enabled = true;
            BtnContinue.Enabled = false;
            CmbSegundo.Enabled = false;
            CmbMinuto.Enabled = false;
            CmbHora.Enabled = false;
            sem_continua = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            
            if (segundo < 10)
            {
                string s = String.Format("0{0}", segundo);
                LblTempo3.Text = s.ToString();
            }
            else
            {
                string s = String.Format("{0}", segundo);
                LblTempo3.Text = s.ToString();
            }

            if (minuto > 0)
            {
                if (segundo == 0)
                {
                    segundo = 59;
                    minuto--;
                }

                if (minuto < 10)
                {
                    string m = String.Format("0{0}", minuto);
                    LblTempo2.Text = m.ToString();
                }
                else
                {
                    string m = String.Format("{0}", minuto);
                    LblTempo2.Text = m.ToString();
                }
            }
            if (hora > 0)
            {
                if (minuto == 0)
                {
                    minuto = 59;
                    hora--;
                }

                if (hora < 10)
                {
                    string h = String.Format("0{0}", hora);
                    LblTempo1.Text = h.ToString();
                }
                else
                {
                    string h = String.Format("{0}", hora);
                    LblTempo1.Text = h.ToString();
                }
            }



            if (hora == 0 && minuto == 0 && segundo == 0)
            {
                p.SoundLocation = @"C:\Program Files (x86)\Alarme\sons\efeito-sonoro.wav";
                p.PlayLooping();

                timer1.Enabled = false;
                sem_continua = true;
                BtnPara.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            btnPlay.Enabled = false;
            BtnContinue.Enabled = false;
            BtnPara.Enabled = true;
            CmbSegundo.Enabled = false;
            CmbMinuto.Enabled = false;
            CmbHora.Enabled = false;
        }
    }
}
