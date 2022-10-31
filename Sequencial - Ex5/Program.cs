// Exercicio 5
// Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
// código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, codigo2, qtd1, qtd2;
            double valor1, valor2, total;

            string[] valores = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(valores[0]);
            qtd1 = int.Parse(valores[1]);
            valor1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            valor2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = qtd1 * valor1 + qtd2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}