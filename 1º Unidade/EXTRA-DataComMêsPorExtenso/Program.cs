using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA_DataComMêsPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string data, mesExtenso; 
            int apenasData, apenasMes, apenasAno;

            while (true)
            { 
            Console.Write("Escreva uma data no formato (DD/MM/AAAA): ");
            data = Console.ReadLine();
                if (data.Length != 10)
                {
                    Console.WriteLine("Por favor, escreva a data no formato (DD/MM/AAAA).");
                    continue;
                }
                apenasData = Convert.ToInt32(data.Substring(0, 2));
                apenasMes = Convert.ToInt32(data.Substring(3, 2));
                apenasAno = Convert.ToInt32(data.Substring(6, 4));

                if (apenasData < 0 || apenasData > 31)
                {
                    Console.WriteLine("Por favor, digite uma data válida.");
                    continue;
                }
                if (apenasMes < 0 || apenasMes > 12)
                {
                    Console.WriteLine("Por favor, digite um mês válido.");
                    continue;
                }
                if (apenasAno < 1000 || apenasAno > 9999)
                {
                    Console.WriteLine("Por favor, digite um ano válido.");
                    continue;
                }
                if (data.Substring(2,1) != "/" || data.Substring(5,1) != "/" )
                {
                    Console.WriteLine("Por favor, utilize a barra (/) como separador.");
                    continue;
                }

                break;
            }

            
            if (apenasMes == 01)
            {
                mesExtenso = "janeiro";
            }
            else if (apenasMes == 02)
            {
                mesExtenso = "fevereiro";
            }
            else if (apenasMes == 03)
            {
                mesExtenso = "março";
            }
            else if (apenasMes == 04)
            {
                mesExtenso = "abril";
            }
            else if (apenasMes == 05)
            {
                mesExtenso = "maio";
            }
            else if (apenasMes == 06)
            {
                mesExtenso = "junho";
            }
            else if (apenasMes == 07)
            {
                mesExtenso = "julho";
            }
            else if (apenasMes == 08)
            {
                mesExtenso = "agosto";
            }
            else if (apenasMes == 09)
            {
                mesExtenso = "setembro";
            }
            else if (apenasMes == 10)
            {
                mesExtenso = "outubro";
            }
            else if (apenasMes == 11)
            {
                mesExtenso = "novembro";
            }
            else
            {
                mesExtenso = "dezembro";
            }

            Console.WriteLine(apenasData + " de " + mesExtenso + " de " + apenasAno);
            Console.ReadKey();

        }
    }
}
