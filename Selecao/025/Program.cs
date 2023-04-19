using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Peso Ideal");
            Console.WriteLine("---------------------");

            Console.Write("\nDigite uma altura em Metros: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nDigite um sexo (M ou F): ");
            string sexo = Console.ReadLine();

            if (sexo == "M")
            {
                double pesoIdeal = (72.7 * altura) - 58;

                Console.WriteLine("\nO peso ideal é: {0}", pesoIdeal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (sexo == "F")
            {
                double pesoIdeal = (62.1 * altura) - 44.7;

                Console.WriteLine("\nO peso ideal é: {0}", pesoIdeal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else 
            {
                Console.WriteLine("Sexo inválido");
            }

            
        }

    }
}