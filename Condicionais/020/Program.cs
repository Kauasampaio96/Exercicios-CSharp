using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo");
            Console.WriteLine("----------");

            Console.Write("\nDigite um valor maior que zero: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\nDigite outro valor maior que zero: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("\nDigite outro valor maior que zero: ");
            int c = int.Parse(Console.ReadLine());

            int maior = a;
            int menor = a;

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("\nValor inválido, tente novemente:");
            }
            else
            {
                if (b > maior) maior = b;
                if (c > maior) maior = c;
                if (b < menor) menor = b;
                if (c < menor) menor = c;

                Console.WriteLine($"\nO Maior número é o {maior}, e o menor é o {menor}");

                Console.WriteLine($"\nO Menor multiplicado pelo Maior é: {menor * maior}");

                Console.WriteLine($"\nO Maior divido pelo Menor é: {maior / menor}");
            }
        }

    }
}