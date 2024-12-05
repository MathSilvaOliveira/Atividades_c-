using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaCorrente : Conta
    {
        public override bool Sacar(double valor)
        {
            return base.Sacar(valor + 0.20);
        }
    }
}
