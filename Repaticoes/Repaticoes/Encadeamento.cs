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
    public partial class Encadeamento : Form
    {
        public Encadeamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int c = 0; c <= 5000; c++)
            {
                for (int x = 0; x <= 50; x++)

                label2.Text = Convert.ToString(x);
                label2.Refresh();
                label1.Text = Convert.ToString(c);
                label1.Refresh();
            }
        }
    }
}
