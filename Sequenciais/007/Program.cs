using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Cº para Fº");
            Console.WriteLine("-------------------------\n");

            Console.Write("Digite um valor em Cº: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();


            double cForF = (9 * c + 160) / 5;

            Console.WriteLine("Em Fº a temperatura é de: {0}", cForF);

        }

    }
}