using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReturnOperacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer[M-multiplicação/A-adição/S-subtração/D-divisão]");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o primeiro valor:");
            double valorUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double valorDois = double.Parse(Console.ReadLine());

            Console.WriteLine("O resultado da operação é "+resolverOperacao(operacao,valorUm,valorDois));

            Console.ReadKey();
        }

        static double resolverOperacao(string operacao, double valorUm , double valorDois)
        {
            switch (operacao)
            {
                case "m":
                    return valorUm * valorDois;

                case "s":
                    return valorUm - valorDois;

                case "a":
                    return valorUm + valorDois;

                case "d":
                    return valorUm / valorDois;

                default:
                    return 0;
            }
        }
    }
}
