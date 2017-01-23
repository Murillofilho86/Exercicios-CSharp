using System;

//Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). 
//Verificar se cada lado é menor que a soma dos outros dois lados. Se sim, saber de A==B e se B==C, 
//sendo verdade o triângulo é eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o 
//triângulo é isósceles; e caso contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem 
//um triângulo, avisar a ocorrência

namespace Exercicio19
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.WriteLine("Informe os valores dos lados de um triangulo");
            Console.WriteLine("Informe valor do lado A: ");
            ladoA = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado B: ");
            ladoB = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado C: ");
            ladoC = Int32.Parse(Console.ReadLine());



            if (ladoA < (ladoB + ladoC) || ladoB < (ladoA + ladoC) || ladoC < (ladoA + ladoB))
            {
                if (ladoA == ladoB && ladoB==ladoC)
                {
                    Console.WriteLine("O triangolo é equilatero");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("O triângulo é isósceles");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um triangulo");
            }

            Console.ReadKey();
        }
    }
}
