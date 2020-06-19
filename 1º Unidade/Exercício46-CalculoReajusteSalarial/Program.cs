using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício46_CalculoReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoServico;
            double salario, novoSalario;

            Console.WriteLine("Tempo de Serviço (em anos): ");
            tempoServico = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (tempoServico >= 10 && salario > 3000)
            {
                novoSalario = salario + salario * 0.10;
            }
            else if (tempoServico <= 9 && salario > 3000)
            {
                novoSalario = salario + salario * 0.08;
            }
            else
            {
                novoSalario = salario + salario * 0.05;

            }
            Console.WriteLine("O novo salário será de {0:N}", novoSalario);
            Console.ReadKey();
        }
    }
}
