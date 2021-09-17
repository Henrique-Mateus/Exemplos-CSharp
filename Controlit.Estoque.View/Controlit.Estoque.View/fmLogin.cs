using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlit.Estoque.View
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text == "123456" && txtNome.Text == "Henrique")
            {
                Form ftm = new Menu(txtNome.Text);
                ftm.Show();
                this.Close();
            }
        }
    }
}
