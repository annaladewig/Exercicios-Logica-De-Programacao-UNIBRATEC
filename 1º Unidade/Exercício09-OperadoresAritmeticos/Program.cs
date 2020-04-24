using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício09_OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, Z, W, K, R, S ;
            double O, P;
            X = 15;
            Y = 4;
            Z = 50;

            W = X + 2;
            Console.WriteLine("O valor da variável W é " + W);

            K = X * Y;
            Console.WriteLine("O valor da variável K é " + K);

            O = 10 + Y + Z / 2;
            Console.WriteLine("O valor da variável O é " + O);

            P = 10 + (Y + Z) / 2;
            Console.WriteLine("O valor da variável P é " + P);

            R = W % 3;
            Console.WriteLine("O valor da variável R é " + R);

            S = Z % X;
            Console.WriteLine("O valor da variável S é " + S);

            Console.ReadKey();

        }
    }
}
