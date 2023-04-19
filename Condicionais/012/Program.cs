using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor Dolar($) para Real(R$)");
            Console.WriteLine("--------------------------------\n");

            double valorDolar = 5.07;

            Console.Write("Digite um valor em Dólar: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double dolarEmReal = dolar * valorDolar;

            Console.WriteLine($"\nEm reais o valor digitado é de = {dolarEmReal:f2}");

        }

    }
}