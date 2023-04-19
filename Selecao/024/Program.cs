using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opção de Lógicas");
            Console.WriteLine("----------------");

            Console.Write("\nDigite um número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite outro número: ");
            double n2 = double.Parse(Console.ReadLine());

            Boolean menu = true;

            while (menu) 
            {
                Console.WriteLine("\n\nEscolha uma opção: \n\n1- Verificar se um dos números é ou não mútiplo do outro \n2- Verificar se os dois números lidos são pares \n3- Verificar se a média dos dois números é maior ou igual a 7 \n4- Sair");

                Console.Write("\nDigite um opção: ");
                int num = int.Parse(Console.ReadLine());


                switch (num)
                {
                    case 1:

                        if (n1 % n2 == 0 || n2 % n1 == 0)
                        {
                            Console.WriteLine("\nSim, um dos números é multiplo do outro");
                        }
                        else
                        {
                            Console.WriteLine("\nNão, nenhum dos números é multiplo do outro");
                        }
                        break;

                    case 2:

                        if (n1 % 2 == 0 && n2 % 2 == 0)
                        {
                            Console.WriteLine("\nSim, os dois números são pares");
                        }
                        else
                        {
                            Console.WriteLine("\nNão, os dois números não são pares");
                        }
                        break;

                    case 3:

                        double media = (n1 + n2) / 2;

                        if (media >= 7) Console.WriteLine("\nSim, a média dos dois números é maior ou igual a 7");

                        else Console.WriteLine("\nNão, a média dos dois números não é maior ou igual a 7");

                        break;

                    case 4:

                        menu = false;
                        Console.WriteLine("\nSaiu do programa!");
                        break;
                }
            }

            
        }

    }
}