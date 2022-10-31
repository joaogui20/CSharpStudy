// Exercicio 1
// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
// incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 2002)
            {
                Console.WriteLine("Senha Invalida");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}