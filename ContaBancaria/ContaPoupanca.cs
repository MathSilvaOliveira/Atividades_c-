using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaPoupanca : Conta
    {
        public override double CalculaTarifaManutencao()
        {
            return Saldo * 0.5;
        }

        public override bool Sacar(double valor)
        {
            if (valor > 1000)
            {
                Console.WriteLine("Valor excede o limite");
            }
            return base.Sacar(valor + 0.10);
            
        }
    }
}
