using System;

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
            int numero, modulo;

            Console.WriteLine("Informe um valor: " );
            numero = Int32.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("Valor informado: " + numero + ", por ser positivo, não possui modulo!");
            }
            else
            {
                modulo = numero * (-1);
                Console.WriteLine("O modulo de " +numero+" é: " + modulo);
            }
            Console.ReadKey();
        }
    }
}
