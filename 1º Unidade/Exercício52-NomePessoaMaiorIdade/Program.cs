using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício52_NomePessoaMaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, nomeMaiorIdade = "";
            int  contador, idade = 0, maiorIdade = 0;

            for (contador = 1; contador <= 5; contador++)
            {
                Console.WriteLine("Qual o nome da {0}º pessoa? ", contador);
                nome = Console.ReadLine();
                Console.WriteLine("Qual a idade da {0}º pessoa?", contador);
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                    nomeMaiorIdade = nome;
                }
            }
            Console.WriteLine("A pessoa com a maior idade é {0}.", nomeMaiorIdade);
            Console.ReadKey();

        }
    }
}
