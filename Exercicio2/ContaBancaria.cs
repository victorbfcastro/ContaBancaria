using System;


namespace Exercicio2
{
    class ContaBancaria
    {
        public Cliente cliente = new Cliente();
        public double Saldo { get; private set; }

        public ContaBancaria(string numeroConta, string nome)
        {
            cliente.NumeroConta = numeroConta;
            cliente.Nome = nome;
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

        public void InformaDados(int inicio, ContaBancaria conta)
        {
            if (inicio == 1)
            {
                Console.WriteLine("\nDados da Conta:");
                Console.WriteLine($"Conta: {conta.cliente.NumeroConta}, Titular: {conta.cliente.Nome}, Saldo: $ {Saldo.ToString("F2")}");
            }

            else
            {
                Console.WriteLine("\nDados da Conta atualizados:");
                Console.WriteLine($"Conta: {conta.cliente.NumeroConta}, Titular: {conta.cliente.Nome}, Saldo: $ {Saldo.ToString("F2")}");
            }
        }

    }

}
