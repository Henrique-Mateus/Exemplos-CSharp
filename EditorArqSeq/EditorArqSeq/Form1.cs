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

namespace EditorArqSeq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            

            if (textBox1.Text != "")
            {
                System.IO.StreamReader vLeitor = new System.IO.StreamReader(textBox1.Text);
                richTextBox1.Clear();

                //richTextBox1.Text = vLeitor.ReadToEnd();
                textBox2.Text = vLeitor.ReadLine();
                vLeitor.ReadLine();

                string vlinha = "";
                int c = 0;
                while (!(vLeitor.EndOfStream))
                {
                    c = c + 1;
                    vlinha = vLeitor.ReadLine();
                    if (!(vlinha.Contains("@")))
                    {
                        richTextBox1.Text = richTextBox1.Text + vlinha + "\r\n";
                    }
                }
                vLeitor.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = textBox1.Text;

            if (textBox1.Text != "")
            {
                gravacao();
            }
            else
            {
                saveFileDialog1.ShowDialog();
                textBox1.Text = saveFileDialog1.FileName;
                gravacao();
            }
        }
        private void gravacao()
        {
            System.IO.StreamWriter vgravado = new System.IO.StreamWriter(textBox1.Text);
            vgravado.Write(richTextBox1.Text);
            vgravado.Close();
            MessageBox.Show("Arquivo gravado com sucesso!");
        }
    }
}
