using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qtde de litros gasta em uma viagem");
            Console.WriteLine("-----------------------------------\n");

            Console.Write("Quantos litros por KM seu veículo consome? ");
            double ltPorKm = double.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.Write("Qual foi o tempo total da viagem? (em horas)");
            double fullTime = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Qual foi a velocidade média? (em km/h)");
            double velocity = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double distance = fullTime * velocity;

            double usedLiters = distance / ltPorKm;

            Console.WriteLine("De acordo com as informações passadas, nessa viagem foi gasto {0:f2} litros, referente a uma viagem de {1} Hrs com velocidade média de {2} km/h e {3} km's percorridos.", usedLiters.ToString("F1"), fullTime, velocity, distance.ToString("F1"));

        }

    }
}