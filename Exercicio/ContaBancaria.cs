using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio
{
    class ContaBancaria
    {
        public double Saldo { get; private set; }
        public string NumeroConta { get; private set; }
        public string NomeTitular { get; set; }

        public ContaBancaria(string conta, string nome, double saldo)
        {
            NomeTitular = nome;
            NumeroConta = conta;
            Saldo = saldo;
        }

        public void AtualizaSaldo(double valor)
        {
            if (valor < 0)
            {
                Saldo += valor - 5;
            }
            else
            {
                Saldo += valor;
            }

        }
    }
}
