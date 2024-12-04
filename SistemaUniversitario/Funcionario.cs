using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario
{
    internal class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        public string Departamento { get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Cargo: {Cargo}\nDepartamento: {Departamento}");
        }

        public override double CalculaSalario(double valor)
        {
            return base.CalculaSalario(valor - (valor * 0.3));
        }
    }
}
