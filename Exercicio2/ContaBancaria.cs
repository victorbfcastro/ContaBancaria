using System;


namespace Exercicio2
{
    class ContaBancaria
    {
        //public Cliente Titular { get; set; }
        public double Saldo { get; private set; }
        public string NumeroConta { get; private set; }
        public string NomeTitular { get; set; }

        public ContaBancaria(string numeroConta, Cliente cliente)
        {
            NumeroConta = numeroConta;
            NomeTitular = cliente.Nome;
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

        public void InformaDados(int inicio, ContaBancaria cliente)
        {
            if (inicio == 1)
            {
                Console.WriteLine("\nDados da Conta:");
                Console.WriteLine($"Conta: {NumeroConta}, Titular: {cliente.NomeTitular}, Saldo: $ {Saldo.ToString("F2")}");
            }

            else
            {
                Console.WriteLine("\nDados da Conta atualizados:");
                Console.WriteLine($"Conta: {NumeroConta}, Titular: {cliente.NomeTitular}, Saldo: $ {Saldo.ToString("F2")}");
            }
        }

    }

}
