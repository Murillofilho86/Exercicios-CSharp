using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto;
            int estoqueMedio = 0;
            int quantidadeMin = 0;
            int quantidadeMax = 0;

            Console.WriteLine("Nome da peça: ");
            produto = Console.ReadLine();


            Console.WriteLine("Informe a quantidade Minima: ");
            quantidadeMin = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade Maxima: ");
            quantidadeMax = Int32.Parse(Console.ReadLine());

            estoqueMedio = (quantidadeMin + quantidadeMax) / 2;

            Console.WriteLine("O estoque medio: " + estoqueMedio + ", Produto: " + produto);

            Console.ReadKey();
        }
    }
}
