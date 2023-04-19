using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Estoque médio");
            Console.WriteLine("-----------------------\n");

            Console.Write("Digite a quantidade Mínima da peça: ");
            double qmin = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Digite a quantidade Máxima da peça: ");
            double qmax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
						
						double media = (qmin + qmax) /2;

						Console.Write($"\nO estoque médio é de = {media}");

        }

    }
}