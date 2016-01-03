using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//11) Ler dois valores inteiros para as variáveis A e B, 
//efetuar a troca dos valores de modo que a variável A 
//passe a possuir o valor da variável B, e a variável B 
//passe a possuir o valor da variável A. Apresentar os valores trocados.  

namespace Exercicio11
{
   public class Program
    {
        static void Main(string[] args)
        {
            int a, b, reserva;

            Console.WriteLine("Informe um valor para A: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor para B: ");
            b = Int32.Parse(Console.ReadLine());

            reserva = a;
            a = b;
            b = reserva;

            Console.WriteLine("O valor atual de A: " + a);
            Console.WriteLine("O valor atual de B: " + b);
            Console.ReadKey();
        }
    }
}
