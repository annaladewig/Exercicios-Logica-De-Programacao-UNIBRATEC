using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício09_MediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, mediaPonderada;
            const int peso1 = 2;
            const int peso2 = 3;
            const int peso3 = 5;

            Console.Write("Qual o valor da primeira nota? ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor da segunda nota? ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor da terceira nota? ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            mediaPonderada = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
            Console.WriteLine("A média ponderada das notas é de {0:F}.", mediaPonderada);
            Console.ReadKey();

        }
    }
}
