using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício40_ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número {0} é PAR.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é ÍMPAR.", numero);
            }
            Console.ReadKey();
        }
    }
}
