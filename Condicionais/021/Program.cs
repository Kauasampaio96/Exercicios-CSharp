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

            Console.Write("\nDigite um número: ");
            int a = int.Parse(Console.ReadLine());

            if (a < 0) Console.WriteLine("\nNúmero Negativo");

            if (a >= 0) Console.WriteLine("\nNúmero Positivo");
        }

    }
}