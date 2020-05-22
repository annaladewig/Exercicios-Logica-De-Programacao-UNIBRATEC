using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício26_Votos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            int totalVotos, votosBrancos, votosNulos, votosValidos;
            double percentualBrancos, percentualNulos, percentualValidos;

            //Entradas
            try
            {
                Console.Write("Qual o total de votos BRANCOS? ");
                votosBrancos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o total de votos NULOS? ");
                votosNulos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o total de votos VÁLIDOS? ");
                votosValidos = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Por favor, digite apenas NÚMEROS.");
                Console.ReadKey();
                return;
            }

            //Processamento
            totalVotos = votosBrancos + votosNulos + votosValidos;
            percentualBrancos = (double) votosBrancos / totalVotos;
            percentualNulos = (double) votosNulos / totalVotos;
            percentualValidos = (double) votosValidos / totalVotos;
            
            //Saída
            Console.WriteLine();
            Console.WriteLine("O percentual de votos BRANCOS foi de {0:P}.", percentualBrancos);
            Console.WriteLine("O percentual de votos NULOS foi de {0:P}.", percentualNulos);
            Console.WriteLine("O percentual de votos VÁLIDOS foi de {0:P}.", percentualValidos);
            Console.ReadKey();

        }
    }
}
