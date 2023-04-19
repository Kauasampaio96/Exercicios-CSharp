using System;
using System.Linq;
using System.Collections.Generic;

namespace Program;

public static class Program
{
	public static void Main()
	{	
		
		Console.Write("Digite um valor: ");
		double a = double.Parse(Console.ReadLine());

		if(a <= 9)
		{
			Console.WriteLine("\nValor Valido");
		}
		else
		{
			Console.WriteLine("\nValor invalido");
		}

	}
}