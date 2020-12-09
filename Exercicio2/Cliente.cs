using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Cliente
    {
        public string Nome { get; set; }
        public string NumeroConta { get; set; }

        public void Deposito(double valor, ContaBancaria conta)
        {
            conta.AtualizaSaldo(valor);
        }

        public void Saque(double valor, ContaBancaria conta)
        {
            double ValorSaque = -(valor);
            conta.AtualizaSaldo(ValorSaque);
        }
    }
}
