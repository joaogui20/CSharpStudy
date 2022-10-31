// Exercicio 1
// Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
// mensagem explicativa, conforme exemplos.

using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}