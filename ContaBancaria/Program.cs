using Banco;

Conta conta1 = new Conta();
Conta conta2 = new Conta();

conta1.Numero = 45783;
conta1.Nome = "Matheus";

conta2.Numero = 79421;
conta2.Nome = "Elon Musk";


ContaPoupanca contaPoucanca = new ContaPoupanca();
contaPoucanca.Numero = 45798;
contaPoucanca.Nome = "Jão";
contaPoucanca.Saldo = 3000;

contaPoucanca.Sacar(500);
Console.WriteLine(contaPoucanca.Saldo);

ContaCorrente contaCorrente = new ContaCorrente();
contaCorrente.Saldo = 5000;
contaCorrente.Sacar(1000);
Console.WriteLine(contaCorrente.Saldo);

//ContaInvestimento contaInvestimento = new ContaInvestimento();

//var taxaPoucanca = contaPoucanca.CalculaTarifaManutencao();
//var taxaInvestimento = contaInvestimento.CalculaTarifaManutencao();

//conta1.Depositar(3000);
//var taxaConta = conta1.CalculaTarifaManutencao();


//Console.WriteLine($"Valor da taxa para conta no nome de {conta1.Nome}: " + taxaConta);
//if (conta1.Sacar(500))
//{
//    Console.WriteLine("Saque efetuado com sucesso!");
//    Console.WriteLine("Saldo atual: " + conta1.Saldo);
//}
//else
//{
//    Console.WriteLine("Problemas ao sacar, entre em contato com o seu Manager");
//}
