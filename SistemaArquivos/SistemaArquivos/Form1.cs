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
using System.Media;

namespace SistemaArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo di = new DriveInfo(@"c:\");
            textBox1.Text = Convert.ToString(di.AvailableFreeSpace);
            
            textBox2.Text = Convert.ToString(di.DriveType);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ld = Directory.GetLogicalDrives();

            foreach (string lista in ld)
            {
                comboBox1.Items.Add(lista);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo di = new DriveInfo(comboBox1.Text);
            textBox1.Text = Convert.ToString(di.AvailableFreeSpace);
            textBox2.Text = Convert.ToString(di.DriveType);

            Directory.SetCurrentDirectory(@"C:\Imagens");
            DirectoryInfo diri = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] ListaFiles = diri.GetFiles();

            listBox1.Items.Clear();
            foreach (FileInfo o in ListaFiles)
            {
                //if (o.Extension == ".exe")
                //{
                    listBox1.Items.Add(string.Format("{0}  {1:n0}", o.Name, o.Length));
                //}
            }

            textBox3.Text = Directory.GetCurrentDirectory();
            if (File.Exists(@"c:\Imagens \12345.jpg"))
            {
                MessageBox.Show("Arquivo existe");
            }
            else
            {
                MessageBox.Show("Arquivo não existe");
            }

            //File.Copy(@"c:\Imagens\12345.jpg", @"c:\Imagens\novo12345.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer p = new SoundPlayer();
            p.SoundLocation = @"D:\Musica\lvl-up.wav";
            p.Play();
        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(System.Globalization.CultureInfo.CurrentCulture);
            textBox5.Text = Convert.ToString(System.DateTime.Now);
        }
    }
}
