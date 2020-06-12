using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício44_VencedorDaEleiçao
{
    class Program
    {
        static void Main(string[] args)
        {
            string candidato1, candidato2, candidato3;
            int votosCandidato1, votosCandidato2, votosCandidato3;

            Console.Write("Qual o nome do primeiro candidato? ");
            candidato1 = Console.ReadLine();
            Console.Write("Qual a quantidade de votos de {0}? ",candidato1);
            votosCandidato1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o nome do segundo candidato? ");
            candidato2 = Console.ReadLine();
            Console.Write("Qual a quantidade de votos de {0}? ", candidato2);
            votosCandidato2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o nome do terceiro candidato? ");
            candidato3 = Console.ReadLine();
            Console.Write("Qual a quantidade de votos de {0}? ", candidato3);
            votosCandidato3 = Convert.ToInt32(Console.ReadLine());

            if ((votosCandidato1 > votosCandidato2) && (votosCandidato1 > votosCandidato3))
            {
                Console.WriteLine("{0} é o vencedor da eleição.", candidato1);
            }
            else if ((votosCandidato2 > votosCandidato1) && (votosCandidato2 > votosCandidato3))
            {
                Console.WriteLine("{0} é o vencedor da eleição.", candidato2);
            }
            else
            {
                Console.WriteLine("{0} é o vencedor(a) da eleição.", candidato3);
            }
            Console.ReadKey();
        }
    }
}
