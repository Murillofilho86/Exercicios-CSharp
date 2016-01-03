using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Escreva um programa que leia dois números e exiba mensagem 
//informando o valor do maior número e o valor do menor número. 
//Se os dois números forem iguais, o programa deve exibir 
//mensagem informando este fato. 
namespace Exercicio16
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;
            
            Console.WriteLine("Informe um valor: ");
            valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro valor: ");
            valor2 = Int32.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("Valor1: " + valor1 + " é maior que o Valor2: " + valor2);
            }
            else if (valor1 < valor2)
            {
                Console.WriteLine("Valor1: " + valor1 + " é menor que o Valor2: " + valor2);
            }
            else
            {
                Console.WriteLine("Valor1: " + valor1 + " é igual ao Valor2: " + valor2);
            }
            Console.ReadKey();
        }
    }
}
