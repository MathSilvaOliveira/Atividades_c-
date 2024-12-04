using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Endereco { get; set; }

        public double Salario { get; set; }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nEndereço: {Endereco}\nSalário: {CalculaSalario(Salario)}");
        }

        public virtual double CalculaSalario(double valor)
        {
            return valor;
        }
    }
}
