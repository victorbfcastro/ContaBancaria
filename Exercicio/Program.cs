using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            LeituraDados();

            //while (true)
            //{
            //    Console.WriteLine("\nCadastrar nova conta? (s/n)");
            //    string resp = Console.ReadLine();

            //    if (resp.ToLower() == "s")
            //    {
            //        Console.WriteLine("");
            //        LeituraDados();
            //    }
            //    else if (resp.ToLower() == "n")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opção Inválida! Responda com 's' ou 'n'");
            //    }
            //}

            Console.Read();

        }
        public static void LeituraDados()
        {
            Console.Write("Entre o número da conta: ");
            string conta = Console.ReadLine();

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resp = Console.ReadLine();

            double deposito = 0.0;

            if (resp.ToLower() == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine());

            }

            CriarConta(conta, titular, deposito);

        }

        public static void CriarConta(string numconta, string titular, double saldo = 0.0)
        {

            ContaBancaria conta = new ContaBancaria(numconta, titular, saldo);

            InformaDados(1, conta);
            Deposito(conta);

        }

        public static void InformaDados(int inicio, ContaBancaria conta)
        {
            if (inicio == 1)
            {
                Console.WriteLine("\nDados da conta: ");
                Console.WriteLine($"Conta {conta.NumeroConta}, Titular: {conta.NomeTitular}, Saldo: $ {conta.Saldo.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine($"Conta {conta.NumeroConta}, Titular: {conta.NomeTitular}, Saldo: $ {conta.Saldo.ToString("F2")}");
            }

        }

        public static void Deposito(ContaBancaria conta)
        {
            Console.Write("\nEntre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());

            conta.AtualizaSaldo(deposito);
            InformaDados(0, conta);
            Saque(conta);
        }

        public static void Saque(ContaBancaria conta)
        {
            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());

            saque = -(saque);
            conta.AtualizaSaldo(saque);
            InformaDados(0, conta);

        }

    }
}


