using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaInvestimento : Conta
    {
        public override double CalculaTarifaManutencao()
        {
            return Saldo * 0.2;
        }
    }
}
