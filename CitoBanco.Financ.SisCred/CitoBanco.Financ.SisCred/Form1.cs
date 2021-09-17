using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitoBanco.Financ.SisCred
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ff = new Form1();
            ff.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fc = new Form2();
            fc.Show();
        }
    }
}
