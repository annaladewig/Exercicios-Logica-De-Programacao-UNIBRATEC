using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício50_MaiorIdadeComCríticas
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, idade = 0, pessoasMaiorIdade = 0;

            while (contador <=10)
            {
                try
                {
                    Console.WriteLine("Qual a {0}º idade? ",contador);
                    idade = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Por favor, digite apenas NÚMEROS.");
                    continue;
                }
                if (idade < 0 || idade > 120) 
                {
                    Console.WriteLine("Por favor, digite uma idade válida.");
                    continue;
                }

                if (idade >= 18)
                {
                    pessoasMaiorIdade = pessoasMaiorIdade + 1;
                }

                contador += 1;

            }
            Console.WriteLine(" A quantidade de pessoas maiores de idade foi de {0}.", pessoasMaiorIdade);
            Console.ReadKey();
        }
    }
}
