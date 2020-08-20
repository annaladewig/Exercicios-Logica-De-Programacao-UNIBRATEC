using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício08_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nota = { 10, 7, 8, 10, 5};
            double aux;
            int contador = 0;

            for (int i = 0; i < nota.Length -2; i++)
            {
                for (int j = i+1; j < nota.Length -1; j++)
                {
                    if (nota[j] > nota[i])
                    {
                        aux = nota[j];
                        nota[j] = nota[i];
                        nota[i] = aux;     
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nota[i]);   
            }

            for (int i = 0; i < 5; i++)
            {
                if (contador == 3)
                {
                    break;
                }
                else if (i == 0)
                {
                    Console.Write(nota[i] + " ");
                    contador = 1;
                }
                else if (i != 0 && nota[i] != nota[i - 1])
                {
                    Console.Write(nota[i] + " ");
                    contador = contador + 1;
                }
                else
                {
                    continue;
                }
            }
            Console.Write("são as três maiores notas, podendo haver notas repetidas.");
            Console.ReadKey();
        }
    }
}
