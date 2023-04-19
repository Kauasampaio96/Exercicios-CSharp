using System;
using System.Globalization;

namespace ExercicioBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comissão de Venderores");
            Console.WriteLine("-----------------------\n");

            Console.Write("Digite Nome do vendedor, Código da peça, Preço unitário e Quantidade vendida (Na ordem descrita): ");

            string[] dadosVendedor = Console.ReadLine().Split(' ');

            string nome = dadosVendedor[0];
            int codigo = int.Parse(dadosVendedor[1]);
            double precoUnit = double.Parse(dadosVendedor[2], CultureInfo.InvariantCulture);
            double QtdeVendida = double.Parse(dadosVendedor[3], CultureInfo.InvariantCulture);


            double vendas = precoUnit * QtdeVendida;
            double comissao = vendas * 0.05;


            Console.WriteLine($"\nDe acordo com as informações a comissão do vendedor(a) {nome} é de: R$ {comissao:f2} referente a um total de R$ {vendas:f2} em vendas!");

        }

    }
}