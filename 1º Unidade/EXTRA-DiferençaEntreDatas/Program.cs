using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA_DiferençaEntreDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia1, dia2, mes1, mes2, ano1, ano2, diferenca, somaData1, somaData2;
            string data1, data2;

            Console.Write("escreva a primeira data no formato DD/MM/AAAA: ");
            data1 = Console.ReadLine();
            Console.Write("escreva a segunda data no formato DD/MM/AAAA: ");
            data2 = Console.ReadLine();

            dia1 = Convert.ToInt32(data1.Substring(0, 2));
            dia2 = Convert.ToInt32(data2.Substring(0, 2));
            mes1 = Convert.ToInt32(data1.Substring(3, 2));
            mes2 = Convert.ToInt32(data2.Substring(3, 2));
            ano1 = Convert.ToInt32(data1.Substring(6, 4));
            ano2 = Convert.ToInt32(data2.Substring(6, 4));

            somaData1 = dia1 + (mes1 * 30) + (ano1 * 30 * 12);
            somaData2 = dia2 + (mes2 * 30) + (ano2 * 30 * 12);

            if (somaData1 > somaData2)
            {
                diferenca = somaData1 - somaData2;
            }
            else
            {
                diferenca = somaData2 - somaData1;
            }

            Console.Write("a diferença entre as datas é de {0} dias", diferenca);
            Console.ReadKey();
        }
    }
}
