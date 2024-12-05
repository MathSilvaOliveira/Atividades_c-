using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }

        public double Saldo  { get; set; }

        public double Limite { get; set; }

        public string Nome { get; set; }

        public virtual double CalculaTarifaManutencao()
        {
            var calculo = Saldo * 0.1;
            return calculo;
        }

        public virtual bool Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Transfere(Conta contaDestino, double valor)
        {
            Conta destino = new Conta();
            destino.Saldo += valor;
        }
    }

}
