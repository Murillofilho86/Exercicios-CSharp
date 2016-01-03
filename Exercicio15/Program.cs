using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Escreva um programa que leia quatro notas escolares de um aluno 
//e apresentar uma mensagem que o aluno foi aprovado se o valor da média 
//escolar for maior ou igual a 7. Se o valor da média for menor que 7, 
//solicitar a nota do recuperação, somar com o valor da média e obter a nova média. 
//Se a nova média for maior ou igual a 7, apresentar uma mensagem informando 
//que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado, apresentar uma 
//mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do aluno.  

namespace Exercicio15
{
    public class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media1, media2, recuperacao;

            Console.WriteLine("Informe a nota do primeiro bimestre: " );
            nota1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do segundo bimenstre: ");
            nota2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do terceiro bimestre: ");
            nota3 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do quarto bimestre: ");
            nota4 = Double.Parse(Console.ReadLine());

            media1 = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media1 >= 7)
            {
                Console.WriteLine("Aluno provado!" );
                Console.WriteLine("Media final: " + media1);
            }
            else
            {
                Console.WriteLine("Será necessário fazer a prova de recuperação");
                Console.WriteLine("Media final: " + media1);
                Console.WriteLine("Informe a nota da recuperação: ");
                recuperacao = Double.Parse(Console.ReadLine());

                media2 = (nota1 + nota2 + nota3 + nota4 + recuperacao) / 4;

                if (media2 >= 7)
                {
                    Console.WriteLine("Aluno aprovado na recuperação");
                    Console.WriteLine("Nota final: " + media2);
                }
                else
                {
                    Console.WriteLine("Aluno não atingiu media satisfatoria");
                    Console.WriteLine("Nota final: " + media2);
                }
            }

            Console.ReadKey();
        }
    }
}
