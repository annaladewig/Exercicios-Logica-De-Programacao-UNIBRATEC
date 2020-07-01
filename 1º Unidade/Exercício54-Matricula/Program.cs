using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício54_Matricula
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno = "  ";
            int contador =1 , idadeAluno, numRejeitadas = 0;
            double percentualRejeitadas;

            while (nomeAluno.Substring(0,2) != "XX")
            {
                Console.WriteLine("Qual o nome do {0}° aluno? ",contador);
                nomeAluno = Console.ReadLine();
                nomeAluno = nomeAluno.ToUpper();
                if (nomeAluno.Substring(0,2) == "XX")
                {
                    break;
                }
                Console.WriteLine("Qual a idade do {0}° aluno? ",contador);
                idadeAluno = Convert.ToInt32(Console.ReadLine());

                if (idadeAluno <15)
                {
                    Console.WriteLine("O aluno NÃO PODE SE MATRICULAR.");
                    numRejeitadas = numRejeitadas + 1;
                }
                else if (idadeAluno >=15 && idadeAluno<21)
                {
                    Console.WriteLine("O aluno SÓ PODERÁ SE MATRICULAR COM O RESPONSÁVEL.");
                }
                else // idade do aluno for >=21
                {
                    Console.WriteLine("O aluno PODE SE MATRICULAR.");
                }

                contador = contador + 1;
            }
                percentualRejeitadas = (double) numRejeitadas / (contador - 1);
                Console.WriteLine("O percentual de matrículas rejeitadas foi de {0:P}.",percentualRejeitadas);
                Console.ReadKey();

        }
    }
}
