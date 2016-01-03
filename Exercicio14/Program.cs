using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Escreva um programa que leia dois números 
//e apresente a diferença do maior para o menor. 
namespace Exercicio14
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int valor1, valor2;

            Console.WriteLine("Informe um valor: ");
            valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            valor2 = Int32.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("O valor " + valor1 + " é maior que o valor " + valor2);

                if (valor1 %2 == 0)
                {
                    Console.WriteLine("E " + valor1 + " é par");
                }
                else
                {
                    Console.WriteLine("E " + valor1 + " é impar");
                }

                
            }
            else
            {
                Console.WriteLine("O valor " + valor2 + " é maior que o valor " + valor1);

                if (valor2 %2 == 0)
                {
                    Console.WriteLine("E " + valor2 + " é par");
                }
                else
                {
                    Console.WriteLine("E " + valor2 + " é impar");
                }
            }

            Console.ReadKey();
        }
    }
}
