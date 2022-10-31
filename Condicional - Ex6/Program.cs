// Exercicio 6
// Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
// seguintes intervalos([0,25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
// nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 0 && numero <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero >= 25 && numero <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero >= 50 && numero <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (numero >= 75 && numero <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}