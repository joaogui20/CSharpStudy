// Exercicio 8
// Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
// que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
// qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
// Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
// mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
// 0.00 até 2000.00 -> Isento
// 2000.01 até 3000.00 -> 8%
// 3000.01 até 4500.00 -> 18%
// acima de 4500.00 -> 28%

using System.Globalization;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
