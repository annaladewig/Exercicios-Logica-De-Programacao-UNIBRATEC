using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1ºUnidade_Questão01
{
    class Program
    {
        static void Main(string[] args)
        {
            string matricula;
            int ano, mes, numSequencial;

            Console.WriteLine("Digite a matrícula do aluno no formato (AAAMMNNNN): ");
            matricula = Console.ReadLine();

            ano = Convert.ToInt32(matricula.Substring(0, 4));
            mes = Convert.ToInt32(matricula.Substring(4, 2));
            ano = Convert.ToInt32(matricula.Substring(6, 4));

            if (mes >= 01 && mes <= 06)
            {
                Console.WriteLine("Matrícula do PRIMEIRO semestre.");
            }
            if (mes >= 07 && mes <= 12)
            {
                Console.WriteLine("Matrícula do SEGUNDO semestre.");
            }
            Console.ReadKey();
        }
    }
}
