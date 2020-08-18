using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício08_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabelaPopulacao = {  { 100, 20, 30, 50, 20 },
                                        { 200, 45, 60, 20, 37 },
                                        { 130, 20, 40, 30, 43 },
                                        { 120, 40, 90, 130, 20},
                                        { 145, 78, 38, 29, 80 },
                                        { 210, 45, 60, 77, 37 },
                                        { 194, 20, 80, 30, 43 },
                                        { 126, 70, 95, 69, 20 } };
            int estadoMaisPopuloso = 0, linhaEstadoMaisPopuloso = -1;
            int municipioMaisPopulosoEstado1 = 0, colunaMunicipioMaisPopulosoEstado1 = 0,
                municipioMaisPopulosoEstado2 = 0, colunaMunicipioMaisPopulosoEstado2 = 0,
                municipioMaisPopulosoEstado3 = 0, colunaMunicipioMaisPopulosoEstado3 = 0,
                municipioMaisPopulosoEstado4 = 0, colunaMunicipioMaisPopulosoEstado4 = 0,
                municipioMaisPopulosoEstado5 = 0, colunaMunicipioMaisPopulosoEstado5 = 0,
                municipioMaisPopulosoEstado6 = 0, colunaMunicipioMaisPopulosoEstado6 = 0,
                municipioMaisPopulosoEstado7 = 0, colunaMunicipioMaisPopulosoEstado7 = 0,
                municipioMaisPopulosoEstado8 = 0, colunaMunicipioMaisPopulosoEstado8 = 0;
            int somaPopulacaoCapitais = 0, populacaoCapitaisMaiorQueMedia = 0;
            double mediaPopulacaoCapitais = 0;

            for (int i = 0; i < 8; i++)
            {
                for(int j= 0; j < 5; j++)
                {
                    Console.Write(tabelaPopulacao[i, j] + "  ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                 if (tabelaPopulacao[i,j] > estadoMaisPopuloso)
                    {
                        estadoMaisPopuloso = tabelaPopulacao[i, j];
                        linhaEstadoMaisPopuloso = i;
                    }
                }
            }
            Console.WriteLine("O Estado mais populoso encontra-se na linha {0}.", linhaEstadoMaisPopuloso + 1);
            // Tem que colocar o + 1, porque para o usuário ele começa a contar as linhas de 1 e não de 0.
            
           for (int j = 1; j < 5; j++)
           {
             municipioMaisPopulosoEstado1 = tabelaPopulacao[0, 1];
              if (tabelaPopulacao[0, j] > municipioMaisPopulosoEstado1)
              {
                municipioMaisPopulosoEstado1 = tabelaPopulacao[0, j];
                colunaMunicipioMaisPopulosoEstado1 = j;
              }

             municipioMaisPopulosoEstado2 = tabelaPopulacao[1, 1];
              if (tabelaPopulacao[1, j] > municipioMaisPopulosoEstado2)
              {
               municipioMaisPopulosoEstado2 = tabelaPopulacao[1, j];
               colunaMunicipioMaisPopulosoEstado2 = j;
              }

              municipioMaisPopulosoEstado3 = tabelaPopulacao[2, 1];
              if (tabelaPopulacao[2, j] > municipioMaisPopulosoEstado3)
              {
               municipioMaisPopulosoEstado3 = tabelaPopulacao[2, j];
               colunaMunicipioMaisPopulosoEstado3 = j;
              }

              municipioMaisPopulosoEstado4 = tabelaPopulacao[3, 1];
              if (tabelaPopulacao[3, j] > municipioMaisPopulosoEstado4)
              {
                municipioMaisPopulosoEstado4 = tabelaPopulacao[3, j];
                colunaMunicipioMaisPopulosoEstado4 = j;
              }

                municipioMaisPopulosoEstado5 = tabelaPopulacao[4, 1];
                if (tabelaPopulacao[4, j] > municipioMaisPopulosoEstado5)
                {
                    municipioMaisPopulosoEstado5 = tabelaPopulacao[4, j];
                    colunaMunicipioMaisPopulosoEstado5 = j;
                }

                municipioMaisPopulosoEstado6 = tabelaPopulacao[5, 1];
                if (tabelaPopulacao[5, j] > municipioMaisPopulosoEstado6)
                {
                    municipioMaisPopulosoEstado6 = tabelaPopulacao[5, j];
                    colunaMunicipioMaisPopulosoEstado6 = j;
                }

                municipioMaisPopulosoEstado7 = tabelaPopulacao[6, 1];
                if (tabelaPopulacao[6, j] > municipioMaisPopulosoEstado7)
                {
                    municipioMaisPopulosoEstado7 = tabelaPopulacao[6, j];
                    colunaMunicipioMaisPopulosoEstado7 = j;
                }

                municipioMaisPopulosoEstado8 = tabelaPopulacao[7, 1];
                if (tabelaPopulacao[7, j] > municipioMaisPopulosoEstado8)
                {
                    municipioMaisPopulosoEstado8 = tabelaPopulacao[7, j];
                    colunaMunicipioMaisPopulosoEstado8 = j;
                }
            }
           
            Console.WriteLine("O Município mais populoso do Estado 1 encontra-se na coluna {0}.", colunaMunicipioMaisPopulosoEstado1 + 1);
            Console.WriteLine("O Município mais populoso do Estado 2 encontra-se na coluna {0}.", colunaMunicipioMaisPopulosoEstado2 + 1);
            Console.WriteLine("O Município mais populoso do Estado 3 encontra-se na coluna {0}.", colunaMunicipioMaisPopulosoEstado3 + 1);
            Console.WriteLine("O Município mais populoso do Estado 4 encontra-se na coluna {0}.", colunaMunicipioMaisPopulosoEstado4 + 1);
            Console.WriteLine("O Município mais populoso do Estado 5 encontra-se na coluna {0}.", colunaMunicipioMaisPopulosoEstado5 + 1);
            Console.WriteLine("O Município mais populoso do Estado 6 encontra-se na coluna {0}.", colunaMunicipioMaisPopulosoEstado6 + 1);
            Console.WriteLine("O Município mais populoso do Estado 7 encontra-se na coluna {0}.", colunaMunicipioMaisPopulosoEstado7 + 1);
            Console.WriteLine("O Município mais populoso do Estado 8 encontra-se na coluna {0}.", colunaMunicipioMaisPopulosoEstado8 + 1);

            for (int i = 0; i < 8; i++)
            {
                somaPopulacaoCapitais = somaPopulacaoCapitais + tabelaPopulacao[i, 0]; 
            }
            mediaPopulacaoCapitais = somaPopulacaoCapitais / 8;
            Console.WriteLine("A média geral das populações das capitais foi de {0}.", mediaPopulacaoCapitais);

            for(int i = 0; i < 8; i++)
            {
                if( tabelaPopulacao[i,0] > mediaPopulacaoCapitais)
                {
                    populacaoCapitaisMaiorQueMedia = populacaoCapitaisMaiorQueMedia + 1;
                }
            }
            Console.Write("Existem {0} capitais com a população maior que a médias das capitais.", populacaoCapitaisMaiorQueMedia);

            Console.ReadKey();
        }
        

    }
}
