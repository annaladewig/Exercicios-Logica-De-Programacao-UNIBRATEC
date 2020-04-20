using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03_TotaisDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, somaInt;
            double num3, num4, somaReais, somaTotal;

            Console.Write("Digite um número inteiro: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um segundo número inteiro: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um número real: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um segundo número real: ");
            num4 = Convert.ToDouble(Console.ReadLine());
            somaInt = num1 + num2;
            somaReais = num3 + num4;
            somaTotal = somaInt + somaReais;
            Console.WriteLine("A soma dos números inteiros é " + somaInt);
            Console.WriteLine("A soma dos números reais é " + somaReais);
            Console.WriteLine("A soma de todos os números é " + somaTotal);
            Console.ReadKey();
        }
    }
}
