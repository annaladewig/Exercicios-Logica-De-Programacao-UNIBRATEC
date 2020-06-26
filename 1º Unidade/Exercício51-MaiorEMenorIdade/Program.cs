using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício51_MaiorEMenorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, idade = 0, maior = 0, menor = 0;

            while (contador <= 5)
            {
                try
                {
                    Console.WriteLine("Qual a {0}° idade? ", contador);
                    idade = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Por favor, digite apenas NÚMEROS, amiguinho ;)");
                }

                if (idade < 0 || idade > 150)
                {
                    Console.WriteLine("Idade inválida, amiguinho. :( ");
                    continue;
                }

                if (contador == 1)
                {
                    maior = idade;
                    menor = idade;
                }

                if (idade > maior)
                {
                    maior = idade;
                }

                if (idade < menor)
                {
                    menor = idade;
                }

                contador += 1;
            }
            Console.WriteLine("A MENOR idade foi: {0}.", menor);
            Console.WriteLine("A MAIOR idade foi: {0}.", maior);
            Console.ReadKey();
        }

    }
}
