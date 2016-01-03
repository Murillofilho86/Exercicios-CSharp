using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    /// <summary>
    /// Calcular e apresentar o valor do volume de uma lata de óleo, 
    /// utilizando a fórmula:  V =  3.14159 * R * R * A Onde as variáveis: V, R e A 
    /// representam respectivamente o volume, o raio e a altura.  
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            double volume, raio, altura;


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("|   Sistema para calcular o volume    |");
            Console.WriteLine("|       de uma lata de oleo           |");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Informe o raio da lata: ");
            raio = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da lata: ");
            altura = Double.Parse(Console.ReadLine());

            volume = (3.14 *( raio * raio) * altura) / 3;
            Console.WriteLine("O volume total da lata é: {0:2}" + volume);

            Console.ReadKey();
        }
    }
}
