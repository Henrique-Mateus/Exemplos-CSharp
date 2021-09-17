using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSoma.Text = Convert.ToString(Convert.ToDecimal(txtNota1.Text) +
                Convert.ToDecimal(txtNota2.Text)
                + Convert.ToDecimal(txtNota3.Text)
                + Convert.ToDecimal(txtNota4.Text)
                + Convert.ToDecimal(txtNota5.Text)
                + Convert.ToDecimal(txtNota6.Text) );
            
            txtMedia.Text = Convert.ToString( (Convert.ToDecimal(txtNota1.Text) +
                Convert.ToDecimal(txtNota2.Text)
                + Convert.ToDecimal(txtNota3.Text) 
                + Convert.ToDecimal(txtNota4.Text)
                + Convert.ToDecimal(txtNota5.Text)
                + Convert.ToDecimal(txtNota6.Text) ) / 3);

            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtNota5.Text = "";
            txtNota6.Text = "";
            txtNota1.Focus();
        }
    }
}
