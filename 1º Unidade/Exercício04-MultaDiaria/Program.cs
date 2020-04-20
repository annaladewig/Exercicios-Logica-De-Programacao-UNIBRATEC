using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício04_MultaDiaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias;
            const double multa = 1.5;
            double total;

            Console.Write("Quantos foram os dias de atraso? ");
            dias = Convert.ToInt32(Console.ReadLine());
            total = dias * multa;
            Console.Write("A multa será de R$ " + total);
            Console.ReadKey();
        }
    }
}
