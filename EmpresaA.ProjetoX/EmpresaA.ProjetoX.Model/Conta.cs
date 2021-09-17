using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaA.ProjetoX.Model
{
    public abstract class Conta
    {
        private int codcliente;
        private int numagencia;
        private int numconta;
        private int digConta;

        public Conta()
        {
            numconta = 11100;
        }

        public int Codcliente
        {
            set { codcliente = value; }
            get { return codcliente; }
        }

        public int Agencia
        {
            set { numagencia = value; }
            get { return numagencia; }
        }

        public int NumeroConta
        {
            set { numconta = value; }
            get { return numconta; }
        }

        public int DigConta
        {
            set { digConta = value; }
            get { return digConta; }
        }

        public void calculaDigConta()
        {
            if (numconta > 10000)
            {
                digConta = 9;
            }
            else
            {
                digConta = 1;
            }
        }
        public abstract string NumContaCompleta();
    }
}
