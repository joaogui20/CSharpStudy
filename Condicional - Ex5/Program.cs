// Exercicio 5
// Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
// seguir, calcule e mostre o valor da conta a pagar.

using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            double total;
            string[] valores = Console.ReadLine().Split(' ');
            cod = int.Parse(valores[0]);
            qtd = int.Parse(valores[1]);

            if (cod == 1)
            {
                total = qtd * 4.00;
            }
            else if (cod == 2)
            {
                total = qtd * 4.50;
            }
            else if (cod == 3)
            {
                total = qtd * 5.00;
            }
            else if (cod == 4)
            {
                total = qtd * 2.00;
            }
            else
            {
                total = qtd * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}