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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string link = "www.google.com/search?q=" + textBox1.Text + "&rlz=1C1EJFC_enBR907BR907&oq=7899732100323&aqs=chrome.0.69i59j69i57j35i39i362l5j69i60...5.97j0j7&sourceid=chrome&ie=UTF-8";
                System.Diagnostics.Process.Start(link);
                timer1.Enabled = false;
            }
        }
    }
}
