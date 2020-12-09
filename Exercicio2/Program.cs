using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastraCliente();
            Console.Read();
            
        }

        static void CadastraCliente()
        {
            Cliente cliente = new Cliente();

            Console.Write("Entre o número da conta: ");
            string numero = Console.ReadLine();
            ContaBancaria conta = new ContaBancaria(numero, cliente);
            

            Console.Write("Entre o nome do titular: ");
            string nome = Console.ReadLine();
            cliente.Nome = nome;           

            Console.Write("Haverá depósito inicial (s/n)? ");
            string resp = Console.ReadLine();
            if (resp.ToLower() == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());

                cliente.Deposito(1000, conta);

            }

            conta.InformaDados(1, conta);

        }
    }
}
