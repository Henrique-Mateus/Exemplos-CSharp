using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace joguinho
{
    public partial class Form3 : Form
    {
        bool sair1 = false;
        bool sair2 = false;
        bool sair3 = false;
        bool vezPlayer1 =true;
        int repit = 1;
        int pontosPlayer1 = 0;
        int pontosPlayer2 = 0;
        int vez = 1;
        int tp = 0;
        int qt = 1;
        int vc1 = 0;
        int vc2 = 0;
        string[] lugares = { "pl", "pl", "pl", "pl", "pl", "pl", "pl", "pl", "pl", "pl", "pl", "pl", "pl", "pl" };
        string[] compara = { "pl", "pl" };
        int[] click = { 0, 0, -1 };
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRest_NnPartida_Click(object sender, EventArgs e)
        {
            for(int psp = 0; psp < 13; psp++)
            {
                lugares[psp] = "pl";
            }
            compara[0] = "pl";
            compara[1] = "pl";
            click[0] = 0;
            click[1] = 0;
            click[2] = -1;
            sair1 = false;
            sair2 = false;
            sair3 = false;
            repit = 1;
            vez = 1;
            tp = 0;
            qt = 1;
            pegar_todos_os_lugares();
            arruma_todos_os_luagares();
            deixa_todas_as_cartas_visiveis();
        }

        private void venceu()
        {
            if (ptbCarta1.Visible == false && ptbCarta2.Visible == false && ptbCarta3.Visible == false && ptbCarta4.Visible == false && ptbCarta5.Visible == false
                && ptbCarta6.Visible == false && ptbCarta7.Visible == false && ptbCarta8.Visible == false && ptbCarta9.Visible == false)
            {
                if (pontosPlayer1 > pontosPlayer2)
                {
                    vc1++;
                    MessageBox.Show(lblPlayer1 + "venceu");
                }
                else if (pontosPlayer2 > pontosPlayer1)
                {
                    vc2++;
                    MessageBox.Show(lblPlayer2 + "venceu");
                }
                else
                {
                    MessageBox.Show("Empate, Ninguem venceu");
                }
            }
            lblPlacar.Text = vc1 + "X" + vc2;
        }

        private void deixa_todas_as_cartas_visiveis()
        {
            ptbCarta1.Visible = true;
            ptbCarta2.Visible = true;
            ptbCarta3.Visible = true;
            ptbCarta4.Visible = true;
            ptbCarta5.Visible = true;
            ptbCarta6.Visible = true;
            ptbCarta7.Visible = true;
            ptbCarta8.Visible = true;
            ptbCarta9.Visible = true;
            ptbCarta10.Visible = true;
            ptbCarta11.Visible = true;
            ptbCarta12.Visible = true;
            ptbCarta13.Visible = true;
            ptbCarta14.Visible = true;

            ptk1.Visible = true;
            ptk2.Visible = true;
            ptk3.Visible = true;
            ptk4.Visible = true;
            ptk5.Visible = true;
            ptk6.Visible = true;
            ptk7.Visible = true;
            ptk8.Visible = true;
            ptk9.Visible = true;
            ptk10.Visible = true;
            ptk11.Visible = true;
            ptk12.Visible = true;
            ptk13.Visible = true;
            ptk14.Visible = true;
        }

        private void pegar_todos_os_lugares()
        {
            while (sair1 == false)
            {
                Random logares_escolhidos = new Random();
                int Pegar_logares = logares_escolhidos.Next(0, 13);

                if (lugares[Pegar_logares] == "pl")
                {
                    switch (vez)
                    {
                        case 1:
                            lugares[Pegar_logares] = "d:/cartas/carta1.jpg";
                            break;

                        case 2:
                            lugares[Pegar_logares] = "d:/cartas/carta2.jpg";
                            break;

                        case 3:
                            lugares[Pegar_logares] = "d:/cartas/carta3.jpg";
                            break;

                        case 4:
                            lugares[Pegar_logares] = "d:/cartas/carta4.jpg";
                            break;

                        case 5:
                            lugares[Pegar_logares] = "d:/cartas/carta5.jpg";
                            break;

                        case 6:
                            lugares[Pegar_logares] = "d:/cartas/carta6.jpg";
                            break;

                        case 7:
                            lugares[Pegar_logares] = "d:/cartas/carta7.jpg";
                            sair1 = true;
                            break;
                    }
                    if (repit == 2)
                    {
                        vez++;
                        repit = 0;
                    }
                    repit++;
                }
            }
        }

        private void desativar_click()
        {
            ptk1.Enabled = false;
            ptk2.Enabled = false;
            ptk3.Enabled = false;
            ptk4.Enabled = false;
            ptk5.Enabled = false;
            ptk6.Enabled = false;
            ptk7.Enabled = false;
            ptk8.Enabled = false;
            ptk9.Enabled = false;
            ptk10.Enabled = false;
            ptk11.Enabled = false;
            ptk12.Enabled = false;
            ptk13.Enabled = false;
            ptk14.Enabled = false;
        }

        private void ativar_click()
        {
            ptk1.Enabled = true;
            ptk2.Enabled = true;
            ptk3.Enabled = true;
            ptk4.Enabled = true;
            ptk5.Enabled = true;
            ptk6.Enabled = true;
            ptk7.Enabled = true;
            ptk8.Enabled = true;
            ptk9.Enabled = true;
            ptk10.Enabled = true;
            ptk11.Enabled = true;
            ptk12.Enabled = true;
            ptk13.Enabled = true;
            ptk14.Enabled = true;
        }

        private void arruma_todos_os_luagares()
        {
            while (sair2 == false)
            {
                switch (qt)
                {
                    case 1:
                        ptbCarta1.ImageLocation = lugares[tp];
                        break;

                    case 2:
                        ptbCarta2.ImageLocation = lugares[tp];
                        break;

                    case 3:
                        ptbCarta3.ImageLocation = lugares[tp];
                        break;

                    case 4:
                        ptbCarta4.ImageLocation = lugares[tp];
                        break;

                    case 5:
                        ptbCarta5.ImageLocation = lugares[tp];
                        break;

                    case 6:
                        ptbCarta6.ImageLocation = lugares[tp];
                        break;

                    case 7:
                        ptbCarta7.ImageLocation = lugares[tp];
                        break;

                    case 8:
                        ptbCarta8.ImageLocation = lugares[tp];
                        break;

                    case 9:
                        ptbCarta9.ImageLocation = lugares[tp];
                        break;

                    case 10:
                        ptbCarta10.ImageLocation = lugares[tp];
                        break;

                    case 11:
                        ptbCarta11.ImageLocation = lugares[tp];
                        break;

                    case 12:
                        ptbCarta12.ImageLocation = lugares[tp];
                        break;

                    case 13:
                        ptbCarta13.ImageLocation = lugares[tp];
                        break;

                    case 14:
                        ptbCarta14.ImageLocation = "d:/cartas/carta7.jpg";
                        sair2 = true;
                        break;
                }
                qt++;
                tp++;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pegar_todos_os_lugares();

            arruma_todos_os_luagares();
        }

        private void ptk1_Click(object sender, EventArgs e)
        {
            ptk1.Visible = false;

            if (click[0] != 1 || click[1] != 1)
            {
                if (click[0] == 0)
                {
                    click[0] = 1;
                }
                else if (click[1] == 0)
                {
                    click[1] = 1;
                }
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta1.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta1.ImageLocation.Substring(15, 1);
                
                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }


        }

        private void ptk2_Click(object sender, EventArgs e)
        {
            ptk2.Visible = false;

            if (click[0] != 2 || click[1] != 2)
            {
                if (click[0] == 0)
                {
                    click[0] = 2;
                }
                else if (click[1] == 0)
                {
                    click[1] = 2;
                }
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta2.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta2.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk3_Click(object sender, EventArgs e)
        {
            ptk3.Visible = false;

            if (click[0] != 3 || click[1] != 3)
            {
                    if (click[0] == 0)
                    {
                        click[0] = 3;
                    }
                    else if (click[1] == 0)
                    {
                        click[1] = 3;
                    }
                
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta3.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta3.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk4_Click(object sender, EventArgs e)
        {
            ptk4.Visible = false;

            if (click[0] != 4 || click[1] != 4)
            {
                    if (click[0] == 0)
                    {
                        click[0] = 4;
                    }
                    else if (click[1] == 0)
                    {
                        click[1] = 4;
                    }
                
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta4.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta4.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk5_Click(object sender, EventArgs e)
        {
            ptk5.Visible = false;

            if (click[0] != 5 || click[1] != 5)
            {
                    if (click[0] == 0)
                    {
                        click[0] = 5;
                    }
                    else if (click[1] == 0)
                    {
                        click[1] = 5;
                    }
                
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta5.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta5.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk6_Click(object sender, EventArgs e)
        {
            ptk6.Visible = false;

            if (click[0] != 6 || click[1] != 6)
            {
                    if (click[0] == 0)
                    {
                        click[0] = 6;
                    }
                    else if (click[1] == 0)
                    {
                        click[1] = 6;
                    }
                
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta6.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta6.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk7_Click(object sender, EventArgs e)
        {
            ptk7.Visible = false;

            if (click[0] != 7 || click[1] != 7)
            {
                    if (click[0] == 0)
                    {
                        click[0] = 7;
                    }
                    else if (click[1] == 0)
                    {
                        click[1] = 7;
                    }
                
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta7.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta7.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk8_Click(object sender, EventArgs e)
        {
            ptk8.Visible = false;

            if (click[0] != 8 || click[1] != 8)
            {
                    if (click[0] == 0)
                    {
                        click[0] = 8;
                    }
                    else if (click[1] == 0)
                    {
                        click[1] = 8;
                    }
                
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta8.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta8.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk9_Click(object sender, EventArgs e)
        {
            ptk9.Visible = false;

            if (click[0] != 9 || click[1] != 9)
            {
                if (click[0] == 0)
                {
                    click[0] = 9;
                }
                else if (click[1] == 0)
                {
                    click[1] = 9;
                }
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta9.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta9.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk10_Click(object sender, EventArgs e)
        {
            ptk10.Visible = false;

            if (click[0] != 10 || click[1] != 10)
            {
                if (click[0] == 0)
                {
                    click[0] = 10;
                }
                else if (click[1] == 0)
                {
                    click[1] = 10;
                }
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta10.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta10.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk11_Click(object sender, EventArgs e)
        {
            ptk11.Visible = false;

            if (click[0] != 11 || click[1] != 11)
            {
                if (click[0] == 0)
                {
                    click[0] = 11;
                }
                else if (click[1] == 0)
                {
                    click[1] = 11;
                }
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta11.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta11.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk12_Click(object sender, EventArgs e)
        {
            ptk12.Visible = false;

            if (click[0] != 12 || click[1] != 12)
            {
                if (click[0] == 0)
                {
                    click[0] = 12;
                }
                else if (click[1] == 0)
                {
                    click[1] = 12;
                }
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta12.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta12.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk13_Click(object sender, EventArgs e)
        {
            ptk13.Visible = false;

            if (click[0] != 13 || click[1] != 13)
            {
                if (click[0] == 0)
                {
                    click[0] = 13;
                }
                else if (click[1] == 0)
                {
                    click[1] = 13;
                }
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta13.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta13.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void ptk14_Click(object sender, EventArgs e)
        {
            ptk14.Visible = false;

            if (click[0] != 14 || click[1] != 14)
            {
                    if (click[0] == 0)
                    {
                        click[0] = 14;
                    }
                    else if (click[1] == 0)
                    {
                        click[1] = 14;
                    }
                
            }

            if (compara[0] == "pl")
            {
                compara[0] = ptbCarta14.ImageLocation.Substring(15, 1);
            }
            else if (compara[1] == "pl")
            {
                compara[1] = ptbCarta14.ImageLocation.Substring(15, 1);

                if (compara[0] == compara[1])
                {
                    timer1.Enabled = true;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            desativar_click();
            for (int pt = 0; pt < 3; pt++)
            {
                switch (click[pt])
                {
                    case 1:
                        ptbCarta1.Visible = false;
                        click[pt] = 0;
                        break;

                    case 2:
                        ptbCarta2.Visible = false;
                        click[pt] = 0;
                        break;

                    case 3:
                        ptbCarta3.Visible = false;
                        click[pt] = 0;
                        break;

                    case 4:
                        ptbCarta4.Visible = false;
                        click[pt] = 0;
                        break;

                    case 5:
                        ptbCarta5.Visible = false;
                        click[pt] = 0;
                        break;

                    case 6:
                        ptbCarta6.Visible = false;
                        click[pt] = 0;
                        break;

                    case 7:
                        ptbCarta7.Visible = false;
                        click[pt] = 0;
                        break;

                    case 8:
                        ptbCarta8.Visible = false;
                        click[pt] = 0;
                        break;

                    case 9:
                        ptbCarta9.Visible = false;
                        click[pt] = 0;
                        break;

                    case 10:
                        ptbCarta10.Visible = false;
                        click[pt] = 0;
                        break;

                    case 11:
                        ptbCarta11.Visible = false;
                        click[pt] = 0;
                        break;

                    case 12:
                        ptbCarta12.Visible = false;
                        click[pt] = 0;
                        break;

                    case 13:
                        ptbCarta13.Visible = false;
                        click[pt] = 0;
                        break;

                    case 14:
                        ptbCarta14.Visible = false;
                        click[pt] = 0;
                        break;
                }
                if (pt == 2)
                {
                    timer1.Enabled = false;
                }
                compara[0] = "pl";
                compara[1] = "pl";

                if (vezPlayer1 == true)
                {
                    pontosPlayer1++;
                }
                else
                {
                    pontosPlayer2++;
                }

                venceu();
            }
            ativar_click();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            desativar_click();
            for(int pt = 0; pt < 3; pt++)
            {
                switch (click[pt])
                {
                    case 1:
                        ptk1.Visible = true;
                        click[pt] = 0;
                        break;

                    case 2:
                        ptk2.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 3:
                        ptk3.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 4:
                        ptk4.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 5:
                        ptk5.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 6:
                        ptk6.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 7:
                        ptk7.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 8:
                        ptk8.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 9:
                        ptk9.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 10:
                        ptk10.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 11:
                        ptk11.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 12:
                        ptk12.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 13:
                        ptk13.Visible = true;
                        click[pt] = 0;
                        
                        break;

                    case 14:

                        ptk14.Visible = true;
                        click[pt] = 0;
                        
                        break;
                }
                if (pt == 2)
                {
                    timer2.Enabled = false;
                }
                compara[0] = "pl";
                compara[1] = "pl";

                if (vezPlayer1 == true)
                {
                    vezPlayer1 = false;
                }
                else
                {
                    vezPlayer1 = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string target = "http://magnet:?xt=urn:btih:9ff0f1f28c31a2da4134e45ecb6832256668b15b&dn=Cyberpunk.2077.v1.3-CODEX&tr=http%3A%2F%2Ftracker.trackerfix.com%3A80%2Fannounce&tr=udp%3A%2F%2F9.rarbg.me%3A2950&tr=udp%3A%2F%2F9.rarbg.to%3A2900&tr=udp%3A%2F%2Ftracker.slowcheetah.org%3A14710&tr=udp%3A%2F%2Ftracker.tallpenguin.org%3A15730";

            System.Diagnostics.Process.Start(target);
        }
    }
}
