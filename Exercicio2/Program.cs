using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            CadastraCliente();
            Console.Read();
            //teste commit
        }

        static void CadastraCliente()
        {
            Cliente cliente = new Cliente();

            Console.Write("Entre o número da conta: ");
            string numero = Console.ReadLine();  

            Console.Write("Entre o nome do titular: ");
            string nome = Console.ReadLine();
            cliente.Nome = nome;
            ContaBancaria conta = new ContaBancaria(numero, cliente);

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resp = Console.ReadLine();
            if (resp.ToLower() == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());

                cliente.Deposito(deposito, conta);

            }
            conta.InformaDados(1, conta);

            Deposito(cliente, conta);

        }

        static void Deposito(Cliente cliente, ContaBancaria conta)
        {
            Console.Write("\nEntre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());

            cliente.Deposito(valor, conta);
            conta.InformaDados(0, conta);

            Saque(cliente, conta);
        }

        static void Saque(Cliente cliente, ContaBancaria conta)
        {
            Console.Write("\nEntre um valor para saque: ");
            double valor = double.Parse(Console.ReadLine());

            cliente.Saque(valor, conta);
            conta.InformaDados(0, conta);
        }
    }
}
