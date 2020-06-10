using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício42_MediaPonderada2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, mediaPonderada;
            const int peso1 = 4, peso2 = 6;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            if (nota1 > nota2 && nota3 > nota1)
            {
                mediaPonderada = (nota1 * peso1 + nota3 * peso2) / (peso1 + peso2);
            }
            else if (nota1 > nota3 && nota2 > nota1)
            {
                mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
            }
            else if (nota2 > nota1 && nota3 > nota2)
            {
                mediaPonderada = (nota2 * peso1 + nota3 * peso2) / (peso1 + peso2);
            }
            else if (nota3 > nota2 && nota1 > nota3)
            {
                mediaPonderada = (nota3 * peso1 + nota1 * peso2) / (peso1 + peso2);
            }
            else if (nota3 > nota1 && nota2 > nota3)
            {
                mediaPonderada = (nota3 * peso1 + nota2 * peso2) / (peso1 + peso2);
            }
            else
            {
                mediaPonderada = (nota2 * peso1 + nota1 * peso2) / (peso1 + peso2);
            }
            Console.WriteLine(mediaPonderada);
            Console.ReadKey();

        }
    }
}
