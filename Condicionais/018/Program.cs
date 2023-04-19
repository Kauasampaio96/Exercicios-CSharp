using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Escreva um numero: ");
        int codigo = int.Parse(Console.ReadLine());
        
        switch(codigo)
        {
            case 1:
                Console.WriteLine("\nCodigo valido!");
                Console.WriteLine("Valor Digitado: um");
                break;
                
            case 2:
                Console.WriteLine("\nCodigo valido!");
                Console.WriteLine("Valor Digitado: dois");
                break;
                
            case 3:
                Console.WriteLine("\nCodigo valido!");
                Console.WriteLine("Valor Digitado: tres");
                break;
                
            default:
                Console.WriteLine("\nCodigo Invalido");
                break;
        }
    }
}