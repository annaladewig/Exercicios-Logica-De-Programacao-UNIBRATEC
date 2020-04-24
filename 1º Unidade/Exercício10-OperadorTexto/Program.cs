using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício10_OperadorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string A, B, C, S, D, E, F, G;

            A = "I";
            B = "BRA";
            C = "TEC";
            S = "X";

            D = A + B + C;
            Console.WriteLine(D);

            E = B + "SIL";
            Console.WriteLine(E);

            F = C + "NO" + B + "S";
            Console.WriteLine(F);

            G = C + "NO" + B + S;
            Console.WriteLine(G);

            Console.ReadKey();






        }
    }
}
