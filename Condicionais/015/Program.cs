using System;
using System.Linq;
using System.Collections.Generic;

namespace Program;

public static class Program
{
	public static void Main()
	{	
		
		Console.Write("Escreva a PRIMEIRA nota do aluno: ");
		double a = double.Parse(Console.ReadLine());

		Console.Write("\nEscreva a SEGUNDA nota do aluno: ");
		double b = double.Parse(Console.ReadLine());

		Console.Write("\nEscreva a TERCEIRA nota do aluno: ");
		double c = double.Parse(Console.ReadLine());
		
		Console.Write("\nEscreva a QUARTA nota do aluno: ");
		double d = double.Parse(Console.ReadLine());
		
		double media = (a + b + c + d)/4;
		
		if(media < 7)
		{
			Console.WriteLine($"\nA media do aluno e de: {media:f2}\n \nALUNO REPROVADO!");
			
			Console.Write("\nDigite a nota da prova de recuperacao: ");
			double ntRecu = double.Parse(Console.ReadLine());
			
			media = (media + ntRecu) / 2;
			
			if(media < 7)
			{
				Console.WriteLine($"\nCom media de {media:f2}, ALUNO REPROVADO, IRA REPETIR DE ANO");
			}
			
			else
			{
				Console.WriteLine($"\nCom media de {media:f2}, ALUNO APROVADO!!!");
			}
		}

		else
		{
			Console.WriteLine($"\nA media do aluno e de: {media:f2}\n \nALUNO APROVADO");
		}
		

	}
}