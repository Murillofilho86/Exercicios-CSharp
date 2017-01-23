using System;


//10) Escrever um programa que leia dois números inteiros e 
//mostre todos os relacionamentos de ordem existentes entre eles. 
//Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.   

namespace Exercicio10
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suporte;

            Console.WriteLine("Informe o primeiro numero: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------");

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " maior que " + num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num1 + " menor que " + num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine(num1 + " é igual " + num2);
            }
            else if (num1 != num2)
            {
                Console.WriteLine(num1 + " diferente de " + num2);
            }

            Console.ReadKey();
        }
    }
}
