using System;
using System.Linq;
using System.Collections.Generic;

namespace Program;

public static class Program
{
	public static void Main()
	{
		Console.Write("Escreva um numero: ");
		int a = int.Parse(Console.ReadLine());

		Console.Write("\nEscreva outro numero: ");
		int b = int.Parse(Console.ReadLine());

		Console.Write("\nEscreva outro numero: ");
		int c = int.Parse(Console.ReadLine());

		if (a > b && a > c && b > c)
		{
			Console.WriteLine("\nA ordem decrescente e: {0} {1} {2}", a, b, c);
		}
		
		else if (a > b && a > c && b < c) 
		{
			Console.WriteLine("\nA ordem decrescente e: {0} {1} {2}", a, c, b);
		}
		else if (b > a && b > c && a > c) 
		{
			Console.WriteLine("\nA ordem decrescente e: {0} {1} {2}", b, a, c);
		}
		
		else if (b > a && b > c && a < c) 
		{
			Console.WriteLine("\nA ordem decrescente e: {0} {1} {2}", b, c, a);
		}
		
		else if (c > a && c > b && b > a)
		{
			Console.WriteLine("\nA ordem decrescente e: {0} {1} {2}", c, b, a);
		}
		
		else if (c > a && c > b && b < a)
		{
			Console.WriteLine("\nA ordem decrescente e: {0} {1} {2}", c, a, b);
		}
		
		else if((a == b && a == c) || (b == a || b == c) || (c == a || c == b))
		{
			Console.WriteLine("\nHa numeros iguais, tente novamente");
		}

	}
}