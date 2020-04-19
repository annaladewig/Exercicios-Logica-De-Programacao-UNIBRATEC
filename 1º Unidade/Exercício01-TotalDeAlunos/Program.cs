using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01_TotalDeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int curso1, curso2, curso3, curso4, total;

            Console.Write("Qual a quantidade de alunos do curso 1? ");
            curso1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a quantidade de alunos do curso 2? ");
            curso2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(("Qual a quantidade de alunos do curso 3? "));
            curso3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual a quantidade de alunos do curso 4? ");
            curso4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A quantidade de alunos do curso 1 é " + curso1 +
            ", do curso 2 é " + curso2 + ", do curso 3 é " + curso3 +
            " e do curso 3 é " + curso4);
            total = curso1 + curso2 + curso3 + curso4;
            Console.WriteLine("O total de alunos de todos os cursos é " + total);
            Console.ReadKey();
        }
    }
}
