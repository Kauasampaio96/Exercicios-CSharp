using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("-----------");

            Console.WriteLine("\nEscolha uma opção: \n\n1- Adição \n2- Subtração \n3- Multiplicação \n4- Divisão");

            Console.Write("\nDigite um opção: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:

                    Console.Write("\nDigite o primeiro valor para realizar ADIÇÃO: ");
                    double n1adc = double.Parse(Console.ReadLine());

                    Console.Write("\nDigite o segundo valor para realizar ADIÇÃO: ");
                    double n2adc = double.Parse(Console.ReadLine());

                    double soma = n1adc + n2adc;

                    Console.WriteLine("\nO resultado é: {0}", soma.ToString("F2", CultureInfo.InvariantCulture));

                    break;

                case 2:

                    Console.Write("\nDigite o primeiro valor para realizar SUBTRAÇÃO: ");
                    double n1sub = double.Parse(Console.ReadLine());

                    Console.Write("\nDigite o segundo valor para realizar SUBTRAÇÃO: ");
                    double n2sub = double.Parse(Console.ReadLine());

                    double subtracao = n1sub - n2sub;

                    Console.WriteLine("\nO resultado é: {0}", subtracao.ToString("F2", CultureInfo.InvariantCulture));

                    break;

                case 3:

                    Console.Write("\nDigite o primeiro valor para realizar MULTIPLICAÇÃO: ");
                    double n1mul = double.Parse(Console.ReadLine());

                    Console.Write("\nDigite o segundo valor para realizar MULTIPLICAÇÃO: ");
                    double n2mul = double.Parse(Console.ReadLine());

                    double multiplicacao = n1mul * n2mul;

                    Console.WriteLine("\nO resultado é: {0}", multiplicacao.ToString("F2", CultureInfo.InvariantCulture));
                    break;

                case 4:

                    Console.Write("\nDigite o primeiro valor para realizar DIVISÃO: ");
                    double n1div = double.Parse(Console.ReadLine());

                    Console.Write("\nDigite o segundo valor para realizar DIVISÃO: ");
                    double n2div = double.Parse(Console.ReadLine());

                    double divisao = n1div / n2div;

                    Console.WriteLine("\nO resultado é: {0}", divisao.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }

        }

    }
}