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
            int num = int.Parse(Console.ReadLine());

            if (num < 0) 
            {
                int b = num;
                Console.WriteLine("Armazenado na Variável B");
            }

            if (num >= 0)
            {
                int a = num;
                Console.WriteLine("Armazenado na Variável A");
            }

        }

    }
}