using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA_QuantidadeDeSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            string horario = "";
            int hora, min, seg, totalSeg;

            Console.Write("Insira o horário no formato (HH:MM:SS): ");
            horario = Console.ReadLine();
            hora = Convert.ToInt32(horario.Substring(0, 2));
            min = Convert.ToInt32(horario.Substring(3, 2));
            seg = Convert.ToInt32(horario.Substring(6, 2));

            totalSeg = seg + (hora * 3600) + (min * 60);

            Console.WriteLine("Esse horário em segundos é: {0}", totalSeg);
            Console.ReadKey();
        }
    }
}
