// Exercicio 4
// Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
// hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
// decimais.

using System;
using System.Globalization;

namespace Exericio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, hours;
            double value, salary;

            number = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = hours * value;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}