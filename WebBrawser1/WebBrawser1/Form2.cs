using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrawser1
{
    public partial class Form2 : Form
    {
        int tt = 0;
        string letr = "Vc Esta quase no Final";
        int clet = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            label2.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.Green)
            {
                panel1.BackColor = Color.Red;
            }
            else
            {
                panel1.BackColor = Color.Blue;
            }

            tt++;
            label1.Text = Convert.ToString(tt);

            if (clet < letr.Length)
            {
                label2.Text = label2.Text + letr.Substring(clet, 1);
                clet++;
            }
            else
            {
                label2.Text = "";
                clet = 0;
            }
        }
    }
}
