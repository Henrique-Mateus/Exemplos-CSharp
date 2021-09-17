using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaticoes
{
    public partial class Fatorial : Form
    {
        public Fatorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int x = 1; x <= Convert.ToInt32(textBox1.TextLength); x++)
            {
                fatorial = fatorial * x;
            }
            textBox2.Text = Convert.ToString(fatorial);
        }
    }
}
