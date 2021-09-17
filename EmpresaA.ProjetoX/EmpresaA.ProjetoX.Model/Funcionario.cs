using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using EmpresaA.ProjetoX.Model;

namespace EmpresaA.ProjetoX.Model
{
    public interface IFuncionario
    {
        double Salario
        {
            get;
            set;
        }
        ArrayList TipoFuncionarios();
        double CalculaImposto();
    }

    public class Funcionario:IFuncionario
    {
        double salario;
        int coddepartamento;
        double imposto;

        double Salario
        {
            set { salario = value; }
            get { return salario; }
        }

        public ArrayList TipoFuncionarios()
        {
            ArrayList tipos = new ArrayList();
            tipos.Add("Lucas");
            tipos.Add("Ana");
            tipos.Add("Marcos");
            tipos.Add("Mateus");
            tipos.Add("Bob");
            return tipos;
        }
    }
}
