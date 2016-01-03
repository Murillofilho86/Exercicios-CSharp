using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal cotacao;
            decimal valorDolar;
            decimal valorReal;

            Console.WriteLine("Informe o valor em dolares: ");
            valorDolar = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Inforne a cotação do dolar: ");
            cotacao = Decimal.Parse(Console.ReadLine());


            valorReal = valorDolar * cotacao;

            Console.WriteLine("Valor equivalente em reais: " + valorReal);

            Console.ReadKey();

        }
    }
}
