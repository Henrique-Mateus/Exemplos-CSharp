using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaA.ProjetoX.Model
{
    public class Poupansa : Conta
    {
        private double saldo;
        private DateTime vencimento;

        public Poupansa()
        {
            NumeroConta = 22200;
            calculaDigConta();
        }

        public Poupansa(int conta)
        {
            NumeroConta = conta;
            calculaDigConta();
        }

        public Poupansa(int conta, DateTime dtv)
        {
            NumeroConta = conta;
            vencimento = dtv;
            calculaDigConta();
        }

        public double ValorSaldo
        {
            set { saldo = value; }
            get { return saldo; }
        }

        public DateTime DataVemcimento
        {
            set { vencimento = value; }
            get { return vencimento; }
        }

        ~Poupansa()
        {

        }

        public override string NumContaCompleta()
        {
            return string.Format("{0}{1}-{2}", this.Agencia, this.NumeroConta, this.DigConta);
        }
    }
}
