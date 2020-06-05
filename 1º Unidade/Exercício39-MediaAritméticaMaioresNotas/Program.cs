using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício39_MediaAritméticaMaioresNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, mediaAritmetica;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            if ((nota1 > nota3) && (nota2 > nota3))
            {
                mediaAritmetica = (nota1 + nota2) / 2;
            }
            else if ((nota2 > nota1) && (nota3 > nota1))
            {
                mediaAritmetica = (nota2 + nota3) / 2;
            }
            else // ((nota3 > nota2) && (nota1 > nota2))
            {
                mediaAritmetica = (nota3 + nota1) / 2;
            }
            Console.WriteLine("A media do aluno foi de {0:F}.", mediaAritmetica);
            Console.ReadKey();
        }

    }
}
