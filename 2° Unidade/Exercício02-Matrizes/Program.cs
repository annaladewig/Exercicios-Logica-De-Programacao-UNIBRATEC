using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 20, 30, 40 }, { 05, 10, 15 }, { 12, 23, 54 } };

            Console.Write("Os números pares são:  ");
            for (int lin = 0; lin < 3; lin++)
            {
                for (int col = 0; col < 3; col++)
                {

                    if (num[lin, col] % 2 == 0)
                    {
                        Console.Write(" " + num[lin, col] + " ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
