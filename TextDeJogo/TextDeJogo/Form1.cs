using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextDeJogo
{
    public partial class Form1 : Form
    {
        int jp2;
        int jp1;
        int HFT;
        int PFT;
        public Form1()
        {
            InitializeComponent();
        }
        private void bt5_Click(object sender, EventArgs e)
        {
            label1.Text = pessoa.Location.X.ToString();
            PFT = Convert.ToInt16(label1.Text);
            PFT = PFT - 9;
            pessoa.Location = new Point(PFT, jp1);
            label1.Text = "";
            label3.Text = Convert.ToString(PFT);
            jp2 = Convert.ToInt16(label3.Text);
            if ((pessoa.Location.Y >= 163 && pessoa.Location.Y <= 204) && (pessoa.Location.X >= 637 && pessoa.Location.X <= 727))
            {
                btCava.Visible = true;
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            label1.Text = pessoa.Location.X.ToString();
            PFT = Convert.ToInt16(label1.Text);
            PFT = PFT + 9;
            pessoa.Location = new Point(PFT, jp1);
            label1.Text = "";
            label3.Text = Convert.ToString(PFT);
            jp2 = Convert.ToInt16(label3.Text);
            if ((pessoa.Location.Y >= 163 && pessoa.Location.Y <= 204) && (pessoa.Location.X >= 637 && pessoa.Location.X <= 727))
            {
                btCava.Visible = true;
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            label2.Text = pessoa.Location.Y.ToString();
            HFT = Convert.ToInt16(label2.Text);
            HFT = HFT + 9;
            pessoa.Location = new Point(jp2, HFT);
            label2.Text = "";
            label4.Text = Convert.ToString(HFT);
            jp1 = Convert.ToInt16(label4.Text);
            if ((pessoa.Location.Y >= 163 && pessoa.Location.Y <= 204) && (pessoa.Location.X >= 637 && pessoa.Location.X <= 727))
            {
                btCava.Visible = true;
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            label2.Text = pessoa.Location.Y.ToString();
            HFT = Convert.ToInt16(label2.Text);
            HFT = HFT - 9;
            pessoa.Location = new Point(jp2, HFT);
            label2.Text = "";
            label4.Text = Convert.ToString(HFT);
            jp1 = Convert.ToInt16(label4.Text);
            if ((pessoa.Location.Y >= 163 && pessoa.Location.Y <= 204) && (pessoa.Location.X >= 637 && pessoa.Location.X <= 727))
            {
                btCava.Visible = true;
            }
        }

        private void btCava_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true; 
            MessageBox.Show ("Para bemis vc comseguil 1% da populasao mudial nao com seguiu ganha esse jogo esse jogo é de sorti ou inteligemsia nem eu progamado com seguie ganha");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = pessoa.Location.X.ToString();
            label2.Text = pessoa.Location.Y.ToString();
        }

        private void pessoa_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == false)
            {
                listBox1.Visible = true;
                pictureBox2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == true)
            {
                listBox1.Visible = false;
                pictureBox2.Visible = false;
            }
        }
    }
}
