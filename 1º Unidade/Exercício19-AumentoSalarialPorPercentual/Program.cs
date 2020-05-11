using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício19_AumentoSalarialPorPercentual
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario;
            double qtdHorasTrabalhadas, valorDaHora, percentualDeAumento,novoSalario;

            //Entrada
            Console.Write("Qual o nome do funcionário(a)? ");
            nomeFuncionario = Console.ReadLine();
            Console.Write("Quantas horas foram trabalhadas por esse funcionário? ");
            qtdHorasTrabalhadas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor da hora trabalhada? R$");
            valorDaHora = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o percentual de aumento por hora extra trabalhada? ");
            percentualDeAumento = Convert.ToDouble(Console.ReadLine());
            
            //Processamento
            novoSalario = qtdHorasTrabalhadas * valorDaHora * percentualDeAumento;
            
            //Saída
            Console.WriteLine(nomeFuncionario + ", seu salário é: " + novoSalario);
            Console.ReadKey();

        }
    }
}
