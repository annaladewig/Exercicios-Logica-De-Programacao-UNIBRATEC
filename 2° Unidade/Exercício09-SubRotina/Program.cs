using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício09_SubRotina
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioBruto, salarioLiquido;

            Console.Write("Qual o valor do salário bruto do empregado? R$ ");
            salarioBruto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O valor do INSS pago é de R$ {0}.", CalculoINSS(salarioBruto));
            Console.WriteLine("O valor do Imposto de Renda é de R$ {0}", CalculoIR(salarioBruto));

            salarioLiquido = salarioBruto - (CalculoINSS(salarioBruto)) - CalculoIR(salarioBruto);
            Console.WriteLine("O valor do salário líquido é de R$ {0}.", salarioLiquido);
            Console.ReadKey();
        }

        static double CalculoINSS (double salarioBruto)
        {
            double valorINSS;
            if (salarioBruto > 0 && salarioBruto <= 1693.72)
            {
                valorINSS = salarioBruto * 0.08;
            }
            else if (salarioBruto >= 1693.73 && salarioBruto <= 2822.90)
            {
                valorINSS = salarioBruto * 0.09;
            }
            else if (salarioBruto >= 2822.91 && salarioBruto <= 5645.80)
            {
                valorINSS = salarioBruto * 0.11;
            }
            else
            {
                valorINSS = 5645.80 * 0.11;
            }
            return valorINSS;
        }

        static double CalculoIR (double salarioBruto)
        {
            double valorIR;

            if (salarioBruto > 0 && salarioBruto <= 1903.98)
            {
                valorIR = 0;
            }
            else if (salarioBruto > 1903.98 && salarioBruto <= 2826.66)
            {
                valorIR = salarioBruto * 0.075;
            }
            else if (salarioBruto >= 2826.67 && salarioBruto <= 3751.05)
            {
                valorIR = salarioBruto * 0.15;
            }
            else if (salarioBruto >= 3751.06 && salarioBruto <= 4664.68)
            {
                valorIR = salarioBruto * 0.225;
            }
            else
            {
                valorIR = salarioBruto * 0.275;
            }
            return valorIR;
        }
    }
}
