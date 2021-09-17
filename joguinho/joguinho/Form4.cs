using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joguinho
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int segundo = 0;
            string k = "";
            for (int f = 0; f < 1000; f++)
            {
                f = 0;
                segundo++;
                label2.Text = Convert.ToString(segundo);
                Refresh();
                if (label2.Text.Length == 4)
                {
                    k = label2.Text.Substring(0, 1);
                    label1.Text = "00:00:0" + k;
                }

                if (segundo == 60000)
                {
                    f = 1001;
                }                                                                                 
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
