using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício43_2ºTurnoEleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int votosCandidato1, votosCandidato2, votosCandidato3;

            Console.Write("Qual a quantidade de votos do Candidato 1? ");
            votosCandidato1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a quantidade de votos do Candidato 2? ");
            votosCandidato2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a quantidade de votos do Candidato 3? ");
            votosCandidato3 = Convert.ToInt32(Console.ReadLine());

            if ((votosCandidato1 + votosCandidato2 >= votosCandidato3) && 
                (votosCandidato2 + votosCandidato3 >= votosCandidato1) && 
                (votosCandidato1 + votosCandidato3 >= votosCandidato2))
            {
                Console.WriteLine("Haverá segundo turno.");
            }
            else
            {
                Console.WriteLine("NÃO haverá segundo turno.");
            }
            Console.ReadKey();
        }

    }
}
