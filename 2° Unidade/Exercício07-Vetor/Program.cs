using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício07_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nota = { 2, 10, 6, 8, 7 };
            double aux = 0;

            for (int i = 0; i <= nota.Length - 2; i++)
            {
                for (int j = i + 1; j <= nota.Length - 1; j++)
                {
                    if (nota[j] > nota[i])
                    {
                        aux = nota[j];
                        nota[j] = nota[i];
                        nota[i] = aux;
                    }
                }
            }
            Console.Write("As três maiores notas são: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" " + nota[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
