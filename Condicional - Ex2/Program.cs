// Exercicio 2
// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}