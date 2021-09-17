using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaA.ProjetoX.Model
{
    public class ContaCorrente : Conta
    {
        private int nomegrerente;
        private int limte;

        public int Gerente
        {
            set { nomegrerente = value; }
            get { return nomegrerente; }
        }

        public int Limite
        {
            set { limte = value; }
            get { return limte; }
        }

        public override string NumContaCompleta()
        {
            return string.Format("{0}{1}-{2}", this.Agencia, this.NumeroConta, this.DigConta);
        }
    }
}
