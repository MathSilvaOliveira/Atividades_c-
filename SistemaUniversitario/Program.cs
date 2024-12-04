
using SistemaUniversitario;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Jão";
pessoa.Salario = 3500;
pessoa.Endereco = "Rua 123";
pessoa.Idade = 35;
pessoa.ExibirInformacoes();

Console.WriteLine("-------------------------------");

Aluno aluno = new Aluno();
aluno.Nome = "Matheus";
aluno.Salario = 0;
aluno.Endereco = "Rua 456";
aluno.Idade = 22;
aluno.Curso = "Ciência da Computação";
aluno.Matricula = "578932";

aluno.ExibirInformacoes();

Console.WriteLine("-------------------------------");

Professor professor = new Professor();
professor.Nome = "Caio";
professor.Idade = 39;
professor.Salario = 2000;
professor.Disciplina = "Estrutura de dados";
professor.ExibirInformacoes();

Console.WriteLine("-------------------------------");

Funcionario funcionario = new Funcionario();
funcionario.Nome = "Joaquim";
funcionario.Idade = 53;
funcionario.Salario = 3000;
funcionario.Endereco = "Rua abc";
funcionario.Cargo = "Segurança";
funcionario.Departamento = "Unimar";

funcionario.ExibirInformacoes();