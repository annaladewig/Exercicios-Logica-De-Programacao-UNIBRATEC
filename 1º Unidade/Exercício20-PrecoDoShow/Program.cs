using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício20_PrecoDoShow
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Entrada

            int n, l, b;
            double q, p, t, gastoNescau, gastoLeite, gastoBanana, gastoTotal;

            try
            {
                Console.Write("Quantas latas de Nescau foram compradas? ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o valor de cada lata de Nescau? R$");
                q = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantos litros de leite foram comprados? ");
                l = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o valor de cada litro de leite? R$ ");
                p = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantos quilos de banana foram comprados? ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o valor de cada quilo de banana? R$ ");
                t = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Por favor, digite apenas »»NÚMEROS««.");
                Console.ReadKey();
                return;
            }
            // Processamento

            gastoNescau = n * q;
            gastoLeite = l * p;
            gastoBanana = b * t;
            gastoTotal = gastoNescau + gastoLeite + gastoBanana;

            // Saída

            Console.WriteLine("O gasto com nescau foi de: R$ {0:N}", gastoNescau);
            Console.WriteLine("O gasto com leite foi de: R$ {0:N}", gastoLeite);
            Console.WriteLine("O gasto com bananas foi de: R$ {0:N}", gastoBanana);
            Console.WriteLine("O gasto total foi de: R$ {0:N}", gastoTotal);
            Console.ReadKey();


        }
    }
}
