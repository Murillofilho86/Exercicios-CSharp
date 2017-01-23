using System;

//Faça um algoritmo que leia a idade de uma pessoa expressa em anos, 
//meses e dias e escreva a idade dessa pessoa expressa apenas em dias. 
//Considerar ano com 365 dias e mês com 30 dias. 
namespace Exercicio09
{

    public class Program
    {
        static void Main(string[] args)
        {
            int dias, meses, anos, idade;
            Console.WriteLine("Informe a sua idade: ");
            idade = Int32.Parse(Console.ReadLine());

            dias = 1;
            meses = dias * 30;
            anos = (meses * 12) + 5;
            idade = idade * anos;
            Console.WriteLine("Idade equivalente em Dias: " + idade);
            
            Console.ReadKey();
        }
    }
}
