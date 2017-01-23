using System;

namespace Exercicio06
{
    /// <summary>
    /// Ler uma temperatura em graus Celsius e apresentá-Ia convertida 
    /// em graus Fahrenheit. A fórmula de conversão de temperatura a ser 
    /// utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a 
    /// temperatura em graus Fahrenheit e a variável C representa é a temperatura em graus Celsius.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit, kelvin;
            int opcao;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("|   Sistema de conversão de temperatura   |");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Informe a temperatura:");
            celsius = Double.Parse(Console.ReadLine());


            Console.WriteLine("Selecione 1 para converter para Fahrenheint e 2 para kelvin:");
            opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    fahrenheit = (9 * celsius + 160.00) / 5;
                    Console.WriteLine("A temperatura em Fahrenheit equivale: " + fahrenheit);
                    break;
                case 2:
                    kelvin = celsius + 273;
                    Console.WriteLine("A temperatura em Kelvin equivale: " + kelvin);
                    break;
            }


            Console.ReadKey();
        }
    }
}
