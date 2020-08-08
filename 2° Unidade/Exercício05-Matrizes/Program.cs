using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício05_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 20, 30, 40 }, { 05, 10, 15 }, { 12, 23, 54 } };

            Console.Write("Os números da diagonal secundária são:  ");

            for (int lin = 0; lin < 3; lin++)
            {
                for (int col = num.Length - 1; col >= 0; col--)
                {
                    if (lin + col == 2)

                        Console.Write(" " + num[lin, col] + " ");

                }
            }
            Console.ReadKey();
        }
    }
}
