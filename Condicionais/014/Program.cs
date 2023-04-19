using System;
using System.Linq;
using System.Collections.Generic;

namespace Program;

public static class Program
{
	public static void Main()
	{
		int diferenca;
		
		Console.Write("Escreva um numero: ");
		int a = int.Parse(Console.ReadLine());

		Console.Write("\nEscreva outro numero: ");
		int b = int.Parse(Console.ReadLine());

		if (a > b)
		{
			diferenca = a - b;
			Console.WriteLine($"\nA diferenca do maior para o menor e de: {diferenca}");
		}
		else
		{
			diferenca = b - a;
			Console.WriteLine($"\nA diferenca do maior para o menor e de: {diferenca}");
		}

	}
}