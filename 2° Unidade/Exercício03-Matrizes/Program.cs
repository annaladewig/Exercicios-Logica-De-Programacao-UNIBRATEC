using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 20, 30, 40 }, { 05, 10, 15 }, { 12, 23, 54 } };

            Console.Write("Os números das linhas pares são:  ");
            for (int lin = 0; lin < 3; lin++)
            {
                for (int col = 0; col < 3; col++)
                {

                    if (lin % 2 == 0)
                    {
                        Console.Write(" " + num[lin, col] + " ");
                    }
                }
            }
            Console.ReadKey();

            /* OU
             * int[,] num = { { 20, 30, 40 }, { 05, 10, 15 }, { 12, 23, 54 } };

            Console.Write("Os números das linhas pares são:  ");
            for (int lin = 0; lin < 3; lin=lin+2)  
            {
                for (int col = 0; col < 3; col++)
                {
                        Console.Write(" " + num[lin, col] + " ");
                }
            }
            Console.ReadKey();

            E, se fosse pra linhas ímpares, era só começar da linha "1" e incrementar de 2 em 2 também.
            */
        }
    }
}
            
