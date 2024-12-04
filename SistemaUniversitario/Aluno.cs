using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario
{
    internal class Aluno : Pessoa
    {
        public string Matricula { get; set; }

        public string Curso { get; set; }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Matrícula: {Matricula}\nCurso: {Curso}");
        }
    }
}
