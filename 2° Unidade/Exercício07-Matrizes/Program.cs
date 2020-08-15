using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício07_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabela = { {"Maria", "Feminino"},
                                  {"Francisco", "Masculino"},
                                  {"José", "Masculino"},
                                  {"Margarida", "Feminino"},
                                  {"Jorge","Masculino"} };

            int qtdSexoMasc = 0, qtdSexoFem = 0;
            string aux = "";

            for (int i = 0; i < 5; i++)
            {
                if (tabela[i, 1] == "Feminino")
                {
                    qtdSexoFem = qtdSexoFem + 1;
                }
                if (tabela[i, 1] == "Masculino")
                {
                    qtdSexoMasc = qtdSexoMasc + 1;
                }
            }

            Console.WriteLine("Existem {0} pessoas do sexo masculino.", qtdSexoMasc);
            Console.WriteLine("Existem {0} pessoas do sexo feminino.", qtdSexoFem);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (tabela [j,0].Length > tabela [i,0].Length)
                    {
                        aux = tabela[i, 0];
                        tabela[i, 0] = tabela[j, 0];
                        tabela[j, 0] = aux;
                    }
                    
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(tabela[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            { 
                if (tabela[i,0].Length == tabela[4,0].Length)
                    Console.Write(tabela[i,0] + ", ");
            }
            Console.WriteLine(" é (são) a(s) pessoa(s) com a(s) maior(es) quantidade(s) de caracteres no nome.");
            Console.ReadKey();
        }
    }
}
