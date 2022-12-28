using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
     class Funcionario
    { 
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, double salario )
        {
            Nome = nome;
            Salario = salario;
        }
        public override string ToString()
        {
            return Nome + " , Salario: " + Salario;
        }
    }
}
