using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resultado dois a dois da adição e multiplicação");
            Console.WriteLine("-----------------------------------------------\n");

            int a = 2;
            int b = 4;
            int c = 6;
            int d = 8;

            // Operações de Soma

            int aPLusB = a + b;
            int aPLusC = a + c;
            int aPLusD = a + d;

            int bPlusC = b + c;
            int bPlusD = b + d;

            int cPlusD = c + d;


            // Operação de Multiplicação

            int aMultiB = a * b;
            int aMultiC = a * c;
            int aMultiD = a * d;

            int bMultiC = b * c;
            int bMultiD = b * d;

            int cMultiD = c * d;


            Console.WriteLine($"A+B = {aPLusB}, A*B = {aMultiB}");
            Console.WriteLine($"A+C = {aPLusC}, A*C = {aMultiC}");
            Console.WriteLine($"A+D = {aPLusD}, A*D = {aMultiD}");
            Console.WriteLine();

            Console.WriteLine($"B+C = {bPlusC}, B*C =  {bMultiC}");
            Console.WriteLine($"B+D = {bPlusD}, B*D = {bMultiD}");
            Console.WriteLine();

            Console.WriteLine($"C+D = {cPlusD}, C*D = {cMultiD}");

        }

    }
}