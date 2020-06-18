using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício45_SituaçãoDoVoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Qual a sua idade? ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade == 16 || idade ==17)
            {
                Console.WriteLine("Voto OPCIONAL.");
            }
            else if (idade >=18 && idade <=65)
            {
                Console.WriteLine("Voto OBRIGATÓRIO.");
            }
            else if (idade > 65)
            {
                Console.WriteLine("Voto OPCIONAL.");
            }
            else // (idade <16)
            {
                Console.WriteLine("NÃO pode votar.");
            }
            Console.ReadKey();
        }
    }
}
