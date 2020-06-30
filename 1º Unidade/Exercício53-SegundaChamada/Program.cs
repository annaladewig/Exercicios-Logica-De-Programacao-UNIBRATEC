using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício53_SegundaChamada
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdAlunos, contador=1;
            double nota, mediaGeral=0, acumuladoNotas=0;

            Console.WriteLine("Quantos alunos estão na segunda chamada?");
            qtdAlunos = Convert.ToInt32(Console.ReadLine());

            while (contador <= qtdAlunos && qtdAlunos != 0)
            {
                Console.WriteLine("Qual a nota do {0}° aluno? ", contador);
                nota = Convert.ToDouble(Console.ReadLine());

                acumuladoNotas = acumuladoNotas + nota;
                contador = contador + 1;
            }
            mediaGeral = acumuladoNotas / qtdAlunos;
            if (qtdAlunos == 0)
            {
                Console.WriteLine("Não houveram alunos na segunda chamada.");
            }
            else
            {
                Console.WriteLine("A média geral da 2º chamada foi de {0:F}.", mediaGeral);
            }
            Console.ReadKey();

        }
    }
}
