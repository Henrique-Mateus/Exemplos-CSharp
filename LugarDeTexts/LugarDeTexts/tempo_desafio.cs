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

namespace LugarDeTexts
{
    public partial class tempo_desafio : Form
    {
        SoundPlayer p = new SoundPlayer();
        int descanso = 0;
        int segundo = 0;
        int minuto = 0;
        int hora = 0;
        int play = 0;
        int JPV = 0;
        public tempo_desafio()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            segundo = 0;
            minuto = 0;
            hora = 0;

            LblTempo1.Text = "00";
            LblTempo1.Text = "00";

            timer1.Enabled = true;

            btnPlay.Enabled = false;
            btnDescanso.Enabled = false;
            BtnPara.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo++;
            if (segundo == 59)
            {
                segundo = 0;

                minuto++;
                LblTempo2.Text = minuto.ToString();

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

                if (hora == Convert.ToInt16(CmbHora.Text) && minuto == Convert.ToInt16(CmbMinuto.Text))
                {
                    minuto = 0;

                    string h = String.Format("0{0}:", hora);

                    LblTempo1.Text = h.ToString();

                    p.SoundLocation = @"D:\Musica\efeito-sonoro.wav";
                    p.PlayLooping();

                    timer1.Enabled = false;

                    btnPlay.Enabled = false;
                    btnDescanso.Enabled = true;
                    BtnPara.Enabled = true;
                }
            }
        }                  

        private void tempo_desafio_Load(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void BtnPara_Click(object sender, EventArgs e)
        {

            p.Stop();

            timer1.Enabled = false;

            btnPlay.Enabled = true;
            btnDescanso.Enabled = false;
            BtnPara.Enabled = false;
        }

        private void btnDescanso_Click(object sender, EventArgs e)
        {
            segundo = 0;
            minuto = 0;
            hora = 0;
            JPV = 1;
            p.Stop();

            LblTempo1.Text = "00";
            LblTempo1.Text = "00";

            timer1.Enabled = true;

            btnPlay.Enabled = false;
            btnDescanso.Enabled = false;
            BtnPara.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
