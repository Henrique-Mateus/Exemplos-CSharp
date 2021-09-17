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
    public partial class Login1 : Form
    {
        string[] Senha = new string[100];
        string[] Nome = new string[100];
        bool Erro1 = false;
        bool Erro2 = false;
        public Login1()
        {
            InitializeComponent();
        }

        //Feito---verificar se na minha base de dados existe o usuario e se a senha é a mesma.

        //Feito---base: vai ser um arquivo com usuarios e senha
        //Feito---base: de cadastro

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader vleitor = new StreamReader("c:/temp/SenhaNome.txt");

            int i = 0;
            while (!vleitor.EndOfStream)
            {
                string registro = vleitor.ReadLine();
                i++;
                Senha[i] = registro.Substring(0, 10);
                Nome[i] = registro.Substring(10, 15);

                label3.Text = (Nome[i]);
                label4.Text = (Senha[i]);
            }

            if (Erro1 == false)
            {
                MessageBox.Show("Porfavor Cloque Seu Nome");
                return;
            }
            else
            {
                if (Erro2 == false)
                {
                    MessageBox.Show("Porfavor Cloque Sua Senha");
                    return;
                }
                else
                {
                    if (label3.Text == (""))
                    {
                        MessageBox.Show("Dados de login nao emcomtrados");
                        return;
                    }
                    else
                    {
                        if (textBox1.Text.Length < 15)
                        {
                            // preciso colocar espaços em branco
                            int qdtEspacos = 0;
                            string espacoVazio = "";

                            qdtEspacos = 15 - textBox1.Text.Length;

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

                                case 7:
                                    espacoVazio = "       ";
                                    break;

                                case 8:
                                    espacoVazio = "        ";
                                    break;

                                case 9:
                                    espacoVazio = "         ";
                                    break;

                                case 10:
                                    espacoVazio = "          ";
                                    break;

                                case 11:
                                    espacoVazio = "           ";
                                    break;

                                case 12:
                                    espacoVazio = "            ";
                                    break;

                                default:
                                    break;
                            }


                            textBox1.Text = textBox1.Text + espacoVazio;
                        }


                            if (textBox1.Text == label3.Text)
                            {
                                    if (textBox2.Text.Length < 10)
                                    {
                                        // preciso colocar espaços em branco
                                        int qdtEspacos = 0;
                                        string espacoVazio = "";

                                        qdtEspacos = 10 - textBox2.Text.Length;

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


                                        textBox2.Text = textBox2.Text + espacoVazio;
                                    }

                                        if (textBox2.Text == label4.Text)
                                        {
                                            Form fmCadastro = new Form1();
                                            fmCadastro.Show();
                                            this.Hide();
                                        }
                                        else
                                        {
                                            textBox2.Text = "";
                                            MessageBox.Show("Senha imcoreta");
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
        private void button2_Click(object sender, EventArgs e)
        {
            Form fmCadastro = new Cadastro1();
            fmCadastro.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Visible = true;
                Erro1 = false;
            }
            else
            {
                label1.Visible = false;
                Erro1 = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label2.Visible = true;
                Erro2 = false;
            }
            else
            {
                label2.Visible = false;
                Erro2 = true;
            }
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            
        }
        private void Login1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

