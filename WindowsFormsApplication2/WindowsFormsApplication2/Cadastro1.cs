using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Cadastro1 : Form
    {
        string[] Senha = new string[100];
        string[] Nome = new string[100];
        bool gmail = false;
        bool nome = false;
        bool senhas = false;
        bool radio = false;
        public Cadastro1()
        {
            InitializeComponent();
        }

        private void Cadastro2_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;

            //StreamReader vleitor = new StreamReader("c:/temp/SenhaNome.txt");

            //int i = 0;
            //while (!vleitor.EndOfStream)
            //{
            //    string registro = vleitor.ReadLine();
            //    i++;
            //    Senha[i] = registro.Substring(0, 5);
            //    Nome[i] = registro.Substring(5, 2);
            //}
        }

        private void gravaArquivo()
        {
            System.IO.StreamWriter vgravador = new System.IO.StreamWriter("c:/temp/SenhaNome.txt");

            for (int da = 1; da < Nome.Length; da++)
            {
                if (Nome[da] != null)
                {
                    string LD = "";
                    LD += Senha[da];
                    LD += Nome[da];
                    vgravador.WriteLine(LD);
                }
            }
            vgravador.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qdtEspacos = 0;
            string espacoVazio = "";
            string senha = "";
            string nome = "";

            if (textBox1.Text == "" || textBox1.TextLength < 3  )
            {
                 label6.Text = "Digite um Nome Válido! ";
                 return;
            
            }

            if (textBox3.Text == "")
            {
                return;
            }

             if (textBox4.Text == "" || textBox5.Text == "" )  
             {
                    textBox5.Text = "";
                    label7.Text = "";
                    label6.Text = "Senha inválida! ";
                    return;
             }


            if (textBox4.Text != textBox5.Text)
            {
                label6.Text = "As Senhas não correspondem! ";
                return;
            }

           

            nome = textBox1.Text;
            senha = textBox4.Text;

                   
                if (senha.Length < 10)
                {
                    // preciso colocar espaços em branco
                           
                    qdtEspacos = 10 - textBox4.Text.Length;

                    switch (qdtEspacos)
                    {
                        case 1:
                            espacoVazio = " ";
                            break;

                        case 2:
                            espacoVazio = "  ";
                            break;

                        case 3:
                            espacoVazio = "   ";
                            break;

                        case 4:
                            espacoVazio = "    ";
                            break;

                        case 5:
                            espacoVazio = "     ";
                            break;

                        case 6:
                            espacoVazio = "      ";
                            break;

                        default:
                            break;
                    }
                            
                    senha =  senha + espacoVazio;
                }


                            
               nome =  nome.Length <= 15 ? nome.PadRight(15, ' ') : nome.Substring(0, 15);


                if (label9.Visible == true)
                {
                    Senha[1] = senha;
                    Nome[1] = nome;
                    gravaArquivo();
                    this.Hide();
                    Form fm = new Form1();
                    fm.Show();
                }
               


                                    
        }
          
                
            
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form fmLogin1 = new Login1();
            fmLogin1.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == (""))
            {
                gmail = false;
                label9.Visible = false;
            }
            else
            {
                gmail = true;
                label9.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                nome = false;
            }
            else
            {
                nome = true;
            }
        }
    }
}
