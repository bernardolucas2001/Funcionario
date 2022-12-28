using System;
using System.Globalization;

namespace Salario
{
    class Tabela
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios vão ser cadastrado? ");
            int n = int.Parse(Console.ReadLine());
            Funcionario[] vect = new Funcionario[50];

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Numero do funcionario: ");
                int func = int.Parse(Console.ReadLine());
                vect[func] = new Funcionario(nome, salario);

            }
            Console.WriteLine();
            Console.WriteLine("Funcionarios cadastrados:");
            for (int i = 0; i < 50; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);




                }

            }

        }
    }
}
