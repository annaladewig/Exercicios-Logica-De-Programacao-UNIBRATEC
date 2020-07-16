using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA_QuantidadeDeSegundosComCríticas
{
    class Program
    {
        static void Main(string[] args)
        {
            string horario = "";
            int hora, min, seg, totalSeg, tamanho;

            while (true)
            {
                Console.Write("Insira o horário no formato (HH:MM:SS): ");
                horario = Console.ReadLine();
                tamanho = horario.Length;
                if (tamanho != 8)
                {
                    Console.Write("o horário deve ter no máximo 8 caracteres.");
                    Console.ReadKey();
                    continue;
                }
                try
                {
                    hora = Convert.ToInt32(horario.Substring(0, 2));
                    min = Convert.ToInt32(horario.Substring(3, 2));
                    seg = Convert.ToInt32(horario.Substring(6, 2));
                }
                catch
                {
                    Console.Write("digite os dados numéricos no formato indicado");
                    Console.ReadKey();
                    continue;
                }
                if (hora < 00 || hora > 23)
                {
                    Console.Write("digite um valor entre 00 e 23");
                    Console.ReadKey();
                    continue;
                }
                if (min < 00 || min > 59)
                {
                    Console.Write("digite um valor entre 00 e 59");
                    Console.ReadKey();
                    continue;
                }
                if (seg < 00 || seg > 59)
                {
                    Console.Write("digite um valor entre 00 e 59");
                    Console.ReadKey();
                    continue;
                }
                if ((horario.Substring(2, 1) != ":") || (horario.Substring(5, 1) != ":"))
                {
                    Console.Write("como separador utilize apenas o símbolo :");
                    Console.ReadKey();
                    continue;
                }
                totalSeg = seg + (hora * 3600) + (min * 60);

                Console.WriteLine("Esse horário em segundos é: {0}", totalSeg);
                Console.ReadKey();
                break;
            }
        }
    }
}
