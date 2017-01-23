using System;

namespace Exercicio07
{
    /// <summary>
    /// Ler uma temperatura em graus Fahrenheit e apresentá-Ia 
    /// convertida em graus Celsius. A fórmula de conversão de temperatura 
    /// a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura
    /// em graus Fahrenheit e a variável C é a temperatura em graus Celsius. 
    /// </summary>
    public class Program
    {

        static void Main(string[] args)
        {
            double celsius, fahrenheit;


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("|   Sistema de conversão de temperatura   |");
            Console.WriteLine("-------------------------------------------");


            Console.WriteLine("Informe a Temperatura: ");
            fahrenheit = Double.Parse(Console.ReadLine());
            
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Celsius é: " + celsius);



            Console.ReadKey();
        }
    }
}
