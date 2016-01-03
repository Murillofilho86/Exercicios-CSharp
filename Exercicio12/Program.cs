using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escreva um programa que leia um número inteiro e exiba o seu módulo. 
//O módulo de um número x é: 
//x se x é maior ou igual a zero 
//x * (-1) se x é menor que zero

namespace Exercicio12
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Informe um valor: ");
            numero = Int32.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("Valor informado: " + numero);
            }
            else
            {
                numero = numero * (-1);
                Console.WriteLine("Valor informado: " + numero);
            }
            Console.ReadKey();
        }
    }
}
