using System;

//Faça um programa que leia um número. Se positivo armazene-o em A, 
//se for negativo, em B. No final mostrar o resultado. 


namespace Exercicio22
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero, A, B;

            Console.WriteLine("Informe um numero: ");
            numero = Int32.Parse(Console.ReadLine());

            if (numero >= 0)
                A = numero;
            else
                B = numero;

            Console.WriteLine("O valor informado é: " + numero);

            Console.ReadKey();
        }
    }
}
