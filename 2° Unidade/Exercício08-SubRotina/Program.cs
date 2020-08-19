using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício08_Sub_Rotina
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;

            Console.WriteLine("Digite a placa do veículo no formato AAA-9999: ");
            placa = Console.ReadLine();

            Console.WriteLine("O seu mês de pagamento do IPVA é {0}.", MesPgtoIpva(placa));
            Console.ReadKey();
        }
        static string MesPgtoIpva (string placaEmAnalise)
        {
            string mesPgto;
            if (Convert.ToInt32(placaEmAnalise.Substring(7,1)) == 1 || Convert.ToInt32(placaEmAnalise.Substring(7, 1)) == 2 || Convert.ToInt32(placaEmAnalise.Substring(7, 1)) == 3)
            {
                mesPgto = "fevereiro";
            }
            else if (Convert.ToInt32(placaEmAnalise.Substring(7, 1)) == 4 || Convert.ToInt32(placaEmAnalise.Substring(7, 1)) == 5 || Convert.ToInt32(placaEmAnalise.Substring(7, 1)) == 6)
            {
                mesPgto = "março";
            }
            else
            {
                mesPgto = "abril";
            }

            return mesPgto;
        }
    }
}
