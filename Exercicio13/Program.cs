using System;

//Escreva um programa que leia 3 números inteiros 
//e imprima na tela os valores em ordem decrescente. 
namespace Exercicio13
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3;
            

            Console.WriteLine("Informe o primeiro valor: ");
            valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            valor2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor: ");
            valor3 = Int32.Parse(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                if (valor2 > valor3)
                {
                    Console.WriteLine(valor1 +", " + valor2 + ", " + valor3);
                }
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                if (valor3 > valor1)
                {
                    Console.WriteLine(valor2 + ", " + valor1 + ", " + valor3);
                }
            }


            Console.WriteLine();

            
            Console.ReadKey();
        }
    }
}
