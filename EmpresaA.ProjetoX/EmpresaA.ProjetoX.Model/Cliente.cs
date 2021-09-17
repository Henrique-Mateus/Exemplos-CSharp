using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaA.ProjetoX.Model
{
    public class Cliente
    {
        private string at_nome;
        private string at_telefone;
        private string at_endereso;
        static int contador;

        public Cliente()
        {
            contador += 1;
        }

        public Cliente(string Nome, string Telefone, string Endereso)
        {
            contador += 1;
            at_nome = Nome;
            at_telefone = Telefone;
            at_endereso = Endereso;
        }

        public string Nome
        {
            get { return at_nome; }
            set { at_nome = value; }
        }
        public string Telefone
        {
            get { return at_telefone; }
            set { at_telefone = value; }
        }
        public string Endereso
        {
            get { return at_endereso; }
            set { at_endereso = value; }
        }

        public string DisplayDDD()
        {
            return at_telefone.Substring(1,2);
        }

        public static bool verficar_cadastro()
        {
            return true;
        }
    }
}