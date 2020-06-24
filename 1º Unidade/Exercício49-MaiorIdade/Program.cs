using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício49_MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, idade = 0, numPessoasMaiores = 0;

            for (contador = 1; contador <=10; contador++)
            {
                Console.WriteLine("Qual a {0}º idade? ",contador);
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade>=18)
                {
                    numPessoasMaiores = numPessoasMaiores + 1;
                }
            }
            Console.WriteLine("O número de pessoas maiores de idade foi {0}.", numPessoasMaiores);
            Console.ReadKey();



        }
    }
}
