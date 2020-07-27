using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] nota = new double[5];
            double acumulado = 0, mediaGeral;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nota do {0}º aluno: ", i+1);
                nota[i] = Convert.ToDouble(Console.ReadLine());
                acumulado = acumulado + nota[i];
            }
            mediaGeral = acumulado / 5;
            Console.WriteLine("A média geral foi de {0:F}.", mediaGeral);
            Console.ReadKey();

        }
    }
}
