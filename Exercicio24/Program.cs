//Escreva um programa que leia dois números inteiros e apresente as 
//opções para usuário escolher o que deseja realizar: 
//1 – Verificar se um dos números lidos é ou não múltiplo do outro 
//2 – Verificar se os dois números lidos são pares 
//3 – Verificar se a média dos dois números é maior ou igual a 7.
//4 – Sair
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            int media, num1, num2, opcoes;

            Console.WriteLine("Informe o primeiro numero: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 – Verificar se um dos números lidos é ou não múltiplo do outro \n");
            Console.WriteLine("2 – Verificar se os dois números lidos são pares \n");
            Console.WriteLine("3 – Verificar se a média dos dois números é maior ou igual a 7. \n ");
            Console.WriteLine("4 – Sair");

            opcoes = Int32.Parse(Console.ReadLine());
            switch (opcoes)
            {
                case 1:
                    if (num1 % num2 == 0 && num2 % num1 == 0)
                    {
                        Console.WriteLine("São multiplos");
                    }
                    else
                    {
                        Console.WriteLine("Não são multiplos");
                    }
                    break;
                case 2:
                    if (num1 % 2 == 0 && num2 % 2 == 0)
                    {
                        Console.WriteLine("Os numeros são pares");
                    }
                    else
                    {
                        Console.WriteLine("Os numeros não são pares");
                    }
                    break;
                case 3:
                    media = (num1 + num2)/2;
                    if (media >= 7)
                    {
                        Console.WriteLine("Média é maior ou igual a 7");
                    }
                    else
                    {
                        Console.WriteLine("Média menor que 7");
                    }
                    break;
                case 4:
                        Console.WriteLine("Você digitou SAIR");
                    break;
                default:
                        Console.WriteLine("Opção invalida!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
