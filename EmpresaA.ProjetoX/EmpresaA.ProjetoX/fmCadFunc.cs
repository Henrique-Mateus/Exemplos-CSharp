using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresaA.ProjetoX.Model;

namespace EmpresaA.ProjetoX
{
    public partial class fmCadFunc : Form
    {
        public fmCadFunc()
        {
            InitializeComponent();
        }

        private void fmCadFunc_Load(object sender, EventArgs e)
        {
            IFuncionario ifun = new Funcionario();
            cb1.DataSource= ifun.TipoFucionarios;
        }
    }
}
