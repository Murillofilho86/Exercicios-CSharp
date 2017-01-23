//Tendo como dados de entrada a altura e o sexo de uma pessoa, 
//faça um programa que calcule seu peso ideal, utilizando as seguintes 
//fórmulas: 
//(h = altura) - Para homens: (72.7* h) - 58
//- Para mulheres: (62.1 * h) - 44.7 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, pesoIdeal;
            int opcao;

            Console.WriteLine("Infome a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso: ");
            peso = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Homem");
            Console.WriteLine("2 - Mulher");
            opcao = Int32.Parse(Console.ReadLine());
            switch (opcao) 
            {
                case 1:
                    pesoIdeal = (72.7*altura) - 58;
                    Console.WriteLine("Peso ideal " + pesoIdeal);
                    break;
                case 2:
                    pesoIdeal = (62.1*altura) - 44.7;
                    Console.WriteLine("Peso ideal " + pesoIdeal);
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }

            Console.ReadKey();
        }
    }
}
