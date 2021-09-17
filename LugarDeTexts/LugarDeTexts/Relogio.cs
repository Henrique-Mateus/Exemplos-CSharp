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


    public partial class Relogio : Form
    {
        int click3 = 1;
        int alarme;
        int segund;
        int minut;
        int Hor;
        int click2 = 1;
        int click = 1;
        int d;
        string test;
        int minuto;
        int segundo;
        int Hora;
        int dia;
        int mes;
        int s;
        int m;
        int h;

        public Relogio()
        {
            InitializeComponent();
        }       

        private void Relogio_Load(object sender, EventArgs e)
        {
            lblDia.Text = DateTime.Now.Day.ToString();
            
            lblMes.Text = DateTime.Now.Month.ToString();

            DiasSemana.Text = DateTime.Now.DayOfWeek.ToString();

            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;
            s = DateTime.Now.Second;
            if (h < 10 || m < 10 || s < 10)
            {
                if (h < 10)
                {
                    string H = String.Format("0{0}:", DateTime.Now.Hour.ToString());
                    lblHora.Text = H;
                    Hora = Convert.ToInt16(DateTime.Now.Hour);
                }
                else
                {
                    string H = String.Format("{0}:", DateTime.Now.Hour.ToString());
                    lblHora.Text = H;
                    Hora = Convert.ToInt16(DateTime.Now.Hour);
                }

                if (m < 10)
                {
                    string M = String.Format("0{0}:", DateTime.Now.Minute.ToString());
                    lblMinuto.Text = M;
                    minuto = Convert.ToInt16(DateTime.Now.Minute);
                }
                else
                {
                    string M = String.Format("{0}:", DateTime.Now.Minute.ToString());
                    lblMinuto.Text = M;
                    minuto = Convert.ToInt16(DateTime.Now.Minute);
                }

                if (s < 10)
                {
                   string S = String.Format("0{0}:", DateTime.Now.Second.ToString());
                   lblSegundo.Text = S;
                   segundo = Convert.ToInt16(DateTime.Now.Second);
                }
                else
                {
                    string S = String.Format("{0}:", DateTime.Now.Second.ToString());
                    lblSegundo.Text = S;
                    segundo = Convert.ToInt16(DateTime.Now.Second);
                }
            }
            else
            {
                string H = String.Format("{0}:", DateTime.Now.Hour.ToString());
                lblHora.Text = H;

                string M = String.Format("{0}:", DateTime.Now.Minute.ToString());
                lblMinuto.Text = M;                     

                string S = String.Format("{0}:", DateTime.Now.Second.ToString());
                lblSegundo.Text = S;

                Hora = Convert.ToInt16(DateTime.Now.Hour);
                minuto = Convert.ToInt16(DateTime.Now.Minute);
                segundo = Convert.ToInt16(DateTime.Now.Second);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (alarme == 1)
            {
                if (Hora == Convert.ToInt16(comboBox1.Text) && minuto == Convert.ToInt16(comboBox2.Text))
                {
                    SoundPlayer p = new SoundPlayer();
                    p.SoundLocation = @"D:\Musica\efeito-sonoro.wav";
                    p.Play();
                    alarme = 2;
                }
                else
                {

                }
            }

            if (click2 == 1)
            {
                h = DateTime.Now.Hour;
                m = DateTime.Now.Minute;
                s = DateTime.Now.Second;
                if (h < 10 || m < 10 || s < 10)
                {
                    if (h < 10)
                    {
                        string H = String.Format("0{0}:", DateTime.Now.Hour.ToString());
                        lblHora.Text = H;
                        Hora = Convert.ToInt16(DateTime.Now.Hour);
                    }
                    else
                    {
                        string H = String.Format("{0}:", DateTime.Now.Hour.ToString());
                        lblHora.Text = H;
                        Hora = Convert.ToInt16(DateTime.Now.Hour);
                    }

                    if (m < 10)
                    {
                        string M = String.Format("0{0}:", DateTime.Now.Minute.ToString());
                        lblMinuto.Text = M;
                        minuto = Convert.ToInt16(DateTime.Now.Minute);
                    }
                    else
                    {
                        string M = String.Format("{0}:", DateTime.Now.Minute.ToString());
                        lblMinuto.Text = M;
                        minuto = Convert.ToInt16(DateTime.Now.Minute);
                    }

                    if (s < 10)
                    {
                        string S = String.Format("0{0}:", DateTime.Now.Second.ToString());
                        lblSegundo.Text = S;
                        segundo = Convert.ToInt16(DateTime.Now.Second);
                    }
                    else
                    {
                        string S = String.Format("{0}:", DateTime.Now.Second.ToString());
                        lblSegundo.Text = S;
                        segundo = Convert.ToInt16(DateTime.Now.Second);
                    }
                }
                else
                {
                    string H = String.Format("{0}:", DateTime.Now.Hour.ToString());
                    lblHora.Text = H;

                    string M = String.Format("{0}:", DateTime.Now.Minute.ToString());
                    lblMinuto.Text = M;

                    string S = String.Format("{0}:", DateTime.Now.Second.ToString());
                    lblSegundo.Text = S;

                    Hora = Convert.ToInt16(DateTime.Now.Hour);
                    minuto = Convert.ToInt16(DateTime.Now.Minute);
                    segundo = Convert.ToInt16(DateTime.Now.Second);
                }
            }

            segundo++;
            lblSegundo.Text = segundo.ToString();

            if (segundo < 10)
            {
                string s = String.Format("0{0}", segundo);
                lblSegundo.Text = s.ToString();
            }
            else
            {
                lblSegundo.Text = segundo.ToString();
            }

            if (segundo == 59)
            {
                segundo = 0;

                minuto++;
                lblMinuto.Text = minuto.ToString();

                if (minuto < 10)
                {
                    string m = String.Format("0{0}:", minuto);
                    lblMinuto.Text = m.ToString();
                }
                else
                {
                    lblMinuto.Text = minuto.ToString();
                }

                if (minuto == 59)
                {
                    minuto = 0;

                    Hora++;
                    lblHora.Text = Hora.ToString();

                    if (Hora < 10)
                    {
                        string h = String.Format("0{0}:", Hora);
                        lblHora.Text = h.ToString();
                    }
                    else
                    {
                        lblHora.Text = Hora.ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (click == 1)
            {
                panel1.BackColor = Color.Turquoise;
                click=2;
                return;
            }

            if (click == 2)
            {
                panel1.BackColor = Color.LightSeaGreen;
                click = 1;
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (click2 == 1)
            {
                button7.Text = "Alarme";
                button2.Text = "Hora";
                button7.Visible = true;

                comboBox1.Visible = false;
                comboBox2.Visible = false;
                button8.Visible = false;
                lblHora.Visible = true;
                lblMinuto.Visible = true;
                lblSegundo.Visible = true;
                button3.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;

                lblDia.Visible = false;
                lblMes.Visible = false;
                DiasSemana.Visible = false;
                lblSegundo.Text = "00";
                lblMinuto.Text = "00:";
                lblHora.Text = "00:";
                timer1.Enabled = false;
                click2 = 2;
                return;
            }

            if (click2 == 2)
            {
                button2.Text = "Cronômetro";
                button7.Visible = true;

                button6.Visible = false;

                lblDia.Visible = true;
                lblMes.Visible = true;
                DiasSemana.Visible = true;
                timer1.Enabled = true;
                timer2.Enabled = false;
                click2 = 1;
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            segund++;
            lblSegundo.Text = segund.ToString();

            if (segund < 10)
            {
                string s = String.Format("0{0}", segund);
                lblSegundo.Text = s.ToString();
            }
            else
            {
                lblSegundo.Text = segund.ToString();
            }

            if (segund == 59)
            {
                segund = 0;

                minut++;
                lblMinuto.Text = minut.ToString();

                if (minut < 10)
                {
                    string m = String.Format("0{0}:", minut);
                    lblMinuto.Text = m.ToString();
                }
                else
                {
                    string m = String.Format("{0}:", minut);
                    lblMinuto.Text = m.ToString();
                }

                if (minut == 59)
                {
                    minut = 0;

                    Hor++;
                    lblHora.Text = Hor.ToString();

                    if (Hor < 10)
                    {
                        string h = String.Format("0{0}:", Hor);
                        lblHora.Text = h.ToString();
                    }
                    else
                    {
                        string h = String.Format("{0}:", Hor);
                        lblHora.Text = h.ToString();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(click2 == 2)
            {
                button3.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = false;

                timer2.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click2 == 2)
            {
                timer2.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click2 == 2)
            {
                segund = 0;
                minut = 0;
                Hor = 0;
                lblSegundo.Text = "00";
                lblMinuto.Text = "00:";
                lblHora.Text = "00:";

                button3.Visible = false;
                button2.Visible = true;
                button1.Visible = true;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = true;

                timer2.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;

            button3.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click3 == 1)
            {
                timer1.Enabled = true;
                click3 = 2;
                button2.Text = "Cronômetro";
                button7.Text = "Hora";
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                button8.Visible = true;
                lblDia.Visible = false;
                lblMes.Visible = false;
                lblSegundo.Visible = false;
                lblMinuto.Visible = false;
                lblHora.Visible = false;
                DiasSemana.Visible = false;
                return;
            }
            else
            {
                button7.Text = "Alarme";
                button7.Visible = true;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                button8.Visible = false;
                lblSegundo.Visible = true;
                lblMinuto.Visible = true;
                lblHora.Visible = true;
                lblDia.Visible = true;
                lblMes.Visible = true;
                DiasSemana.Visible = true;
                timer1.Enabled = true;
                click3 = 1;
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            alarme = 1;
            button7.Text = "Alarme";
            button7.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            button8.Visible = false;
            lblSegundo.Visible = true;
            lblMinuto.Visible = true;
            lblHora.Visible = true;
            lblDia.Visible = true;
            lblMes.Visible = true;
            DiasSemana.Visible = true;
            timer1.Enabled = true;
            click3 = 1;
            return;
        }

        private void lblSegundo_Click(object sender, EventArgs e)
        {

        }
    }
}
