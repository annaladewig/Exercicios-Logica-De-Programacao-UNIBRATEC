using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] idade = new int[3, 3];
            int contador18 = 0, contador65 = 0;

            for (int lin = 0; lin < 3; lin++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine("Escreva a idade: ");
                    idade[lin, col] = Convert.ToInt32(Console.ReadLine());

                    if (idade[lin, col] >= 18)
                    {
                        contador18 = contador18 + 1;
                    }

                    if (idade[lin, col] >= 65)
                    {
                        contador65 = contador65 + 1;
                    }
                }

            }
            Console.WriteLine("As idades iguais ou maiores de 18 anos são: " + contador18);
            Console.WriteLine("As idades iguais ou maiores de 65 anos são: " + contador65);
            Console.ReadKey();
        }
    }
}
