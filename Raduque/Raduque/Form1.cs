using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Raduque
{
    public partial class Form1 : Form
    {
        int Y = 0;
        int X = 181;
        int giro = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Y = pt2.Location.Y;
            pt2.Location = new Point(X,Y);
            X += 10;
            pt2.Refresh();
            if (giro > 19)
            {
                timer1.Enabled = false;
            }
            giro += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Enabled = true;
        }

        private void pt1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Enabled = true;
        }

        private void pt2_Click(object sender, EventArgs e)
        {

        }
    }
}


