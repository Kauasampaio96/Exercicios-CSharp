using System;
using System.Linq;
using System.Collections.Generic;

namespace Program;

public static class Program 
{         
    public static void Main()
    {
      Console.Write("Escreva um numero: ");
			int num = int.Parse(Console.ReadLine());
			int numEditavel = num;
		
		
			Console.WriteLine("\nMaiores que o numero digitado: {0}, {1}, {2}, {3} ...", numEditavel++, numEditavel++, numEditavel++, numEditavel++);
			numEditavel = num;
			Console.WriteLine("\nMenores que o numero digitado: {0}, {1}, {2}, {3} ...", numEditavel--, numEditavel--, numEditavel--, numEditavel--);
			numEditavel = num;
			Console.WriteLine("\nMaiores ou igual o numero digitado: {0}, {1}, {2}, {3}, {4} ...", num, numEditavel++, numEditavel++, numEditavel++, numEditavel++);
			numEditavel = num;
			Console.WriteLine("\nMenores ou igual o numero digitado: {0}, {1}, {2}, {3}, {4} ...", num, numEditavel--, numEditavel--, numEditavel--, numEditavel--);
			numEditavel = num;
			Console.WriteLine("\nIgual ao numero digitado: {0}", num);
		
			//Console.WriteLine($"Menores que o numero digitado: {idadeEmDias} dias.");
    }
}