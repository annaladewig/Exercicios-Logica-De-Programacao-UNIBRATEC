using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício04_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nota = new double[5];
            string[] nome = new string[5];
            double acumulado = 0, mediaGeral;
            int superiorMediaGeral = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nome do {0}º aluno: ", i + 1);
                nome[i] = Console.ReadLine();
                Console.Write("Nota do {0}º aluno: ", i + 1);
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
            Console.Write("O nomes dos alunos foram: ");
            for (int i = 0; i < 5; i++)
            {
                if (nota[i] >= mediaGeral)
                {
                    Console.Write(" " + nome[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("As notas foram: ");
            for (int i = 0; i < 5; i++)
            {
                if (nota[i] >= mediaGeral)
                {
                    Console.Write(" " + nota[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
