using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario
{
    internal class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Disciplina: {Disciplina}");
        }

        public override double CalculaSalario(double salario)
        {
            return base.CalculaSalario(salario - (salario * 0.2));
        }
    }
}
