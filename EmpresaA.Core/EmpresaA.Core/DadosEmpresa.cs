using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaA.Core
{
    public class DadosEmpresa
    {
        private string nomeempresa;
        private string razaosocil;

        public DadosEmpresa()
        {
            nomeempresa = "Empresa mendes Vieira";
            razaosocil = "Contrutora";
        }

        public string Nome
        {
            set { nomeempresa = value; }
            get { return nomeempresa; }
        }
        public string razao
        {
            set { razaosocil = value; }
            get { return razaosocil; }
        }
    }
}
