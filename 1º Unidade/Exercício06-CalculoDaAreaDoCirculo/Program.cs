using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício06_CalculoDaAreaDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raioCirculo, areaCirculo;
            const double pi = 3.14;
            Console.Write("Qual o tamanho do raio do círculo em centímetros? ");
            raioCirculo = Convert.ToDouble(Console.ReadLine());
            areaCirculo = pi * (raioCirculo * raioCirculo);
            Console.WriteLine("A área do cículo é de {0} cm.", areaCirculo);
            Console.ReadKey();
        }
    }
}
