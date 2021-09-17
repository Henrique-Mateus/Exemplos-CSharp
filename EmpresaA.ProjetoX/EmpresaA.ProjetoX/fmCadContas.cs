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
    public partial class fmCadContas : Form
    {
        public fmCadContas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conta co = new Conta();
            //co.Agencia = Convert.ToInt16(textBox2.Text);
            //co.Codcliente = Convert.ToInt16(textBox1.Text);
            //co.NumeroConta = 990;

            Poupansa po = new Poupansa(44400,System.DateTime.Now.Date);
            po.Agencia = Convert.ToInt32(textBox2.Text);
            MessageBox.Show(po.NumContaCompleta());

            ContaCorrente cc = new ContaCorrente();
            cc.Agencia = 12333;

            //co = po;
        }

        private void fmCadContas_Load(object sender, EventArgs e)
        {

        }
    }
}