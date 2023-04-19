using System;
					
public class Program
{
	public static void Main()
	{
		
		Console.Write("Digite um número: ");
		int a = int.Parse(Console.ReadLine());
		
		Console.Write("Digite outro número: ");
		int b = int.Parse(Console.ReadLine());
		
		if( a == b)
		{
			Console.WriteLine("\nHá numeros iguais, tente novamente");
			return;
		}
		
		if (a > b)
		{
			Console.WriteLine("\nO maior número é: {0}", a);
		}
		else
		{
			Console.WriteLine("\nO maior número é: {0}", b);
		}
		
		
	}
}