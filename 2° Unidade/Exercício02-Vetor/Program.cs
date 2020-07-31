using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] nota = new double[5];
            double acumulado = 0, mediaGeral;
            int superiorMediaGeral = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nota do {0}º aluno: ", i + 1);
                nota[i] = Convert.ToDouble(Console.ReadLine());
                acumulado = acumulado + nota[i];
            }

            mediaGeral = acumulado / 5;

            for (int i = 0; i < 5; i++)
            {
                if (nota[i] >= mediaGeral)
                {
                    superiorMediaGeral = superiorMediaGeral + 1;
                }
            }
            Console.WriteLine("A média geral foi de {0:F}.", mediaGeral);
            Console.WriteLine("Houveram {0} notas iguais ou superiores à média geral.", superiorMediaGeral);
            Console.ReadKey();

        }
    }
}
