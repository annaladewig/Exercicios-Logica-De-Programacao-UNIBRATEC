using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício12_InversaoDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada

            int primeiro, segundo, temp;

            try
            {
                Console.Write("Digite o primeiro número: ");
                primeiro = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                segundo = Convert.ToInt32(Console.ReadLine());

            }

            catch
            {
                Console.Write("Por favor, digite apenas NÚMEROS.");
                Console.ReadKey();
                return;

            }

            // Processamento

            temp = primeiro;
            primeiro = segundo;
            segundo = temp;


            // Saída

            Console.WriteLine("O valor do primeiro número é: " + primeiro);
            Console.WriteLine("O valor do segundo número é: " + segundo);
            Console.ReadKey();
        }
    }
}
