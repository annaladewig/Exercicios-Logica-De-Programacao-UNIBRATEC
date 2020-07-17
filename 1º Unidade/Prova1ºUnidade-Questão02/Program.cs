using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1ºUnidade_Questão02
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, parteDecimal, soma = 0;
            double parteInteira;

            for (int contador = 1; contador <= 6; contador++)
            {
                Console.WriteLine("Escreva um número real: ");
                num = Convert.ToDouble(Console.ReadLine());

                parteInteira = Math.Truncate(num);
                parteDecimal = num - parteInteira;
                Console.WriteLine(parteDecimal);
                Console.WriteLine(parteInteira);

                soma = soma + parteDecimal;
            }
            Console.WriteLine("A soma das partes decimais dos números digitados foi {0}.",soma);
            Console.ReadKey();
        }
    }
}
