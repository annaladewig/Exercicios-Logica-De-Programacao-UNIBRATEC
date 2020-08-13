using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício06_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabela = { {"Maria", "Feminino"},
                                  {"João", "Masculino"},
                                  {"José", "Masculino"},
                                  {"Margarida", "Feminino"},
                                  {"Jorge","Masculino"} };
            string nomeMaiorQtdCarac = "";
            int qtdSexoMasc = 0, qtdSexoFem = 0;

            for (int i = 0; i < 5; i++)
            {
                    if (tabela[i,1] == "Feminino")
                    {
                        qtdSexoFem = qtdSexoFem + 1;
                    }
                    if (tabela[i,1] == "Masculino")
                    {
                        qtdSexoMasc = qtdSexoMasc + 1;
                    }
                    if (i==0)
                    {
                        nomeMaiorQtdCarac = tabela[i,0];
                    }
                    if (tabela[i,0].Length > nomeMaiorQtdCarac.Length)
                    {
                        nomeMaiorQtdCarac = tabela[i,0];
                    }
            }

            Console.WriteLine("Existem {0} pessoas do sexo masculino.", qtdSexoMasc);
            Console.WriteLine("Existem {0} pessoas do sexo feminino.", qtdSexoFem);
            Console.WriteLine("{0} é a pessoa com a maior quantidade de caracteres no nome.", nomeMaiorQtdCarac);
            Console.ReadKey();

        }
    }
}
