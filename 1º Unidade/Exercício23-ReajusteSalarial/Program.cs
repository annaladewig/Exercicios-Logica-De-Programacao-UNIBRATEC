using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício23_ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            double salarioMensal, valorReajuste, novoSalario;

            try
            {
                Console.Write("Qual o valor mensal do salário? R$ ");
                salarioMensal = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Por favor digite apenas números.");
                Console.ReadKey();
                return;
            }
            try

            {
                Console.Write("Qual o percentual de reajuste? ");
                valorReajuste = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Por favor, digite apenas números e sem o símbolo de porcentagem(%).");
                Console.ReadKey();
                return;
            }

            //Processamento
            novoSalario = salarioMensal + salarioMensal * valorReajuste / 100;

            //Saídas
            Console.WriteLine("O valor do nova salário é de R$ {0:N}.", novoSalario);
            Console.ReadKey();

            }
    }
}
