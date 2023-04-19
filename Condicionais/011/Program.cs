using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lógica de um Triângulo");
            Console.WriteLine("----------------------");

            Console.Write("\nDigite um valor para um lado do triangulo: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\nDigite outro valor para um lado do triangulo: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("\nDigite outro valor para um lado do triangulo: ");
            int c = int.Parse(Console.ReadLine());

            if ( (a < (b+c)) && (b < (a+c)) && (c < (b+a)))
            {
              Console.WriteLine("\nTriângulo Válido");
            }
            else
            {
              Console.WriteLine("\nTriângulo Inválido");
            }
        }
    }
}