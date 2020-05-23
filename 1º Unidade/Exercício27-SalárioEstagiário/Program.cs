using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício27_SalárioEstagiário
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            double salarioMensalBruto, salarioBrutoTotal, descontoPlanoSaude, salarioMensalLiquido;
            int duracaoEstagioMeses, duracaoEmDias;
            const int mes = 30;

            //Entradas
            try
            {
                Console.Write("Qual o valor mensal do salário do estagiário? R$ ");
                salarioMensalBruto = Convert.ToDouble(Console.ReadLine());
                Console.Write("Qual o tempo de duração do estágio em meses?");
                duracaoEstagioMeses = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Por favor, digite apenas NÚMEROS.");
                Console.ReadKey();
                return;
            }
            //Processamento
            duracaoEmDias = duracaoEstagioMeses * mes;
            salarioBrutoTotal = salarioMensalBruto * duracaoEstagioMeses;
            descontoPlanoSaude = salarioMensalBruto * 10 / 100;
            salarioMensalLiquido = salarioMensalBruto - (salarioMensalBruto * 10 / 100);

            //Saídas
            Console.WriteLine("A duração total do estágio em dias é de {0}.", duracaoEmDias);
            Console.WriteLine("O salário bruto total é de R$ {0:N}.", salarioBrutoTotal);
            Console.WriteLine("O valor do desconto mensal do Plano de Saúde é de R$ {0:N}.", descontoPlanoSaude);
            Console.WriteLine("O valor do salário líquido mensal é de R$ {0:N}.", salarioMensalLiquido);
            Console.ReadKey();
          
        }
    }
}
