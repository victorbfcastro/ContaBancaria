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

        }

        static void CadastraCliente()
        {

            Console.Write("Entre o número da conta: ");
            string numero = Console.ReadLine();

            Console.Write("Entre o nome do titular: ");
            string nome = Console.ReadLine();

            ContaBancaria conta = new ContaBancaria(numero, nome);

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resp = Console.ReadLine();

            while (true)
            {
                if (resp.ToLower() == "s")
                {
                    Console.Write("Entre o valor de depósito inicial: ");
                    double deposito = double.Parse(Console.ReadLine());

                    conta.cliente.Deposito(deposito, conta);
                    conta.InformaDados(1, conta);
                    Deposito(0, conta);
                    break;
                }
                else if (resp.ToLower() == "n")
                {
                    conta.InformaDados(1, conta);
                    Deposito(0, conta);
                    break;
                }
                else
                {
                    Console.WriteLine("\nOpção inválida! Utilize 's' ou 'n'.\n");
                    Console.Write("Haverá depósito inicial (s/n)? ");
                    resp = Console.ReadLine();
                }
            }

        }

        static void Deposito(int inicio, ContaBancaria conta)
        {
            Console.Write("\nEntre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());

            conta.cliente.Deposito(valor, conta);
            conta.InformaDados(0, conta);

            Saque(conta);
        }

        static void Saque(ContaBancaria conta)
        {
            Console.Write("\nEntre um valor para saque: ");
            double valor = double.Parse(Console.ReadLine());

            conta.cliente.Saque(valor, conta);
            conta.InformaDados(0, conta);

        }
    }
}
