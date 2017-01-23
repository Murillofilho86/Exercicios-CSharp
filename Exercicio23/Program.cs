//Escreva um programa que exiba as seguintes opções e 
//realize os que se pede em cada uma delas:
//1 – Adição 2 – Subtração 3 – Multiplicação 4 – Divisão 

using System;

namespace Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            int adicao, subtracao, multiplicacao, divisao, opcao;
            int num1, num2;

            Console.WriteLine("Informe o primeiro numero: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo numero: ");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Selecione uma operação");
            Console.WriteLine("1 – Adição 2 – Subtração 3 – Multiplicação 4 – Divisão");
            opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    adicao = num1 + num2;
                    Console.WriteLine(adicao);
                    break;

                case 2:
                    subtracao = num1 - num2;
                    Console.WriteLine(subtracao);
                    break;

                case 3:
                    multiplicacao = num1*num2;
                    Console.WriteLine(multiplicacao);
                    break;

                case 4:
                    divisao = num1/num2;
                    Console.WriteLine(divisao);
                    break;

            }
            Console.ReadKey();

        }
    }
}
