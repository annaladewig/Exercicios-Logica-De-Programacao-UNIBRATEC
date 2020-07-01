using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA_AlunosPorTurma
{
    class Program
    {
        static void Main(string[] args)
        {
            string informacaoTurma, curso, turno, cursoMaiorQtdAlunos = "";
            int contador = 1, qtdAlunos = 0, qtdAlunosManha = 0, qtdAlunosTarde = 0, maiorQtdAlunos = 0 ;
            while (true)
            {
                Console.Write("Qual a informação da {0}º turma? ", contador);
                informacaoTurma = Console.ReadLine();
                informacaoTurma = informacaoTurma.ToUpper();
                if (informacaoTurma == "FIM")
                {
                    break;
                }
                if (informacaoTurma.Length != 7)
                {
                    Console.WriteLine("Escreva a informação com 7 dígitos e no seguinte formato: CCCTNNN.");
                    continue;
                }

                curso = informacaoTurma.Substring(0,3);
                turno = informacaoTurma.Substring(3,1);
                qtdAlunos = Convert.ToInt32(informacaoTurma.Substring(4,3));
                
                if (String.Compare(curso, "AAA") == -1 || String.Compare(curso,"ZZZ") == 1)
                {
                    Console.WriteLine("Por favor, digite apenas letras na parte de curso.");
                    continue;
                }
                if (turno != "M" && turno != "T")
                {
                    Console.WriteLine("Na parte do turno, escreva apenas M para manhã ou T para tarde.");
                    continue;
                }
                if (turno == "M")
                {
                    qtdAlunosManha = qtdAlunosManha + qtdAlunos;
                }
                if (turno == "T")
                {
                    qtdAlunosTarde = qtdAlunosTarde + qtdAlunos;
                }

                if (qtdAlunos < 000 || qtdAlunos > 999)
                {
                    Console.WriteLine("Na parte de quantidade de alunos, escreva um número de 000 à 999.");
                    continue;
                }
                if (qtdAlunos > maiorQtdAlunos)
                {
                    maiorQtdAlunos = qtdAlunos;
                    cursoMaiorQtdAlunos = curso;
                }

                contador++;
            }
            Console.WriteLine("O curso com a maior quantidade de alunos é o curso de {0}.", cursoMaiorQtdAlunos);
            Console.WriteLine("A quandidade de alunos no turno da MANHÃ é de {0} alunos.", qtdAlunosManha);
            Console.WriteLine("A quandidade de alunos no turno da TARDE é de {0} alunos.", qtdAlunosTarde);
            Console.ReadKey();

        }
    }
}
