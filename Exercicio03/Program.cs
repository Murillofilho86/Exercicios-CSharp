using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal comissao;
            int idVendendor;
            int codPeca;
            decimal precoUni;
            int quantidade;
            decimal valorTot;

            Console.WriteLine("Informme o codigo do vendedor :");
            idVendendor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o codigo da peça : ");
            codPeca = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço da peça: ");
            precoUni = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de peças da venda : ");
            quantidade = Int32.Parse(Console.ReadLine());

            valorTot = precoUni * quantidade;
            comissao = (valorTot * 5) / 100;


            Console.WriteLine("Valor total da venda: " + valorTot);
            Console.WriteLine("Valor da Comissao: " + comissao);
            Console.ReadKey();

        }
    }
}
