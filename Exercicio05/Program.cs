using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Program
    {
        //A cada litro de combustivel = 12KM
        //Formula1: Distancia = tempo * velocidade
        //Formula2: Litros_usados = Distancia / 12
      

        static void Main(string[] args)
        {
            double litros_usados, tempo, velocidade, distancia_inicial, distancia_final;

            Console.WriteLine("Informe o tempo de viagem: ");
            tempo = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a velocidade media: ");
            velocidade = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quilometragem Inicial: ");
            distancia_inicial = Double.Parse(Console.ReadLine());

            distancia_final = distancia_inicial + velocidade * tempo;
            Console.WriteLine("Distancia Percorrida: " + distancia_final);
            
            
            litros_usados = distancia_final / 12;
            Console.WriteLine("Total de litros Usados na viagem: " + litros_usados);
            Console.ReadKey();
        }
    }
}
