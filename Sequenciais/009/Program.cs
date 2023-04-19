using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Volume de Recipiente");
            Console.WriteLine("------------------------------\n");


            Console.Write("Digite o RAIO do recipiente (em cm): ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o ALTURA do recipiente (em cm): ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine();


            double volume = 3.14159 * r * r * h;

            Console.WriteLine("De acordo com as informações passadas o volume do recipiente é de {0:f2} cm3", volume);

        }

    }
}