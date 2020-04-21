using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício05_AreaDoTrapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseMaior, baseMenor, altura, areaDoTrapezio;

            Console.Write("Qual o tamanho da base maior em centímetros? ");
            baseMaior = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o tamanho da base menor em centímetros? ");
            baseMenor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o tamanho da altura em centímetros? ");
            altura = Convert.ToDouble(Console.ReadLine());

            areaDoTrapezio = (baseMaior + baseMenor) * altura / 2;
            Console.WriteLine("A área do trapézio é de {0:F} cm.", areaDoTrapezio);
            Console.ReadKey();

        }
    }
}
