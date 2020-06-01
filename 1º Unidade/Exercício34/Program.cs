using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício34
{
    class Program
    {
        static void Main(string[] args)
        {
            const int X = 5, Y = 10, P = 60, K = 100;
            const string A = "ADN", B = "ADS", C = "AM", S = "AS";
            bool L1, L2, L3, L4, L5, L6, L7;
            bool Z1, Z2, Z3, Z4, Z5;

            L1 = X % 2 == 0;
            L2 = X * 2 == Y;
            L3 = A < S;
            L4 = "X" == S;
            L5 = "X" < S;
            L6 = B > C;
            L7 = P * 2 <= K;

            Z1 = L1 && L2;
            Z2 = L4 && L3 || L5;
            Z3 = L2 && (L3 || L5);
            Z4 = L2 && !L7;
            Z5 = !false || true;

            Console.WriteLine("O valor de L1 é: ", L1);
            Console.WriteLine("O valor de L2 é: ", L2);
            Console.WriteLine("O valor de L3 é: ", L3);
            Console.WriteLine("O valor de L4 é: ", L4);
            Console.WriteLine("O valor de L5 é: ", L5);
            Console.WriteLine("O valor de L6 é: ", L6);
            Console.WriteLine("O valor de L7 é: ", L7);

            Console.WriteLine("O valor de Z1 é: ", Z1);
            Console.WriteLine("O valor de Z2 é: ", Z2);
            Console.WriteLine("O valor de Z3 é: ", Z3);
            Console.WriteLine("O valor de Z4 é: ", Z4);
            Console.WriteLine("O valor de Z5 é: ", Z5);

            Console.ReadKey();





        }
    }
}

