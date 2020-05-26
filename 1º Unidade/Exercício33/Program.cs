using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício33
{
    class Program
    {
        static void Main(string[] args)
        {
            const int X = 5, Y = 3, Z = 8;
            bool A, B, C, D, E;

            A = (X < Y) && (Y < Z);
            B = (X > Y) && (Y < Z);
            C = (X < Y) || (Y < Z);
            D = (X < Y) || (Y > Z);
            E = (X > Y) || (Y < Z);

            Console.WriteLine("O valor de A é {0}.", A);
            Console.WriteLine("O valor de B é {0}.", B);
            Console.WriteLine("O valor de C é {0}.", C);
            Console.WriteLine("O valor de D é {0}.", D);
            Console.WriteLine("O valor de E é {0}.", E);
            Console.ReadKey();


        }
    }
}
