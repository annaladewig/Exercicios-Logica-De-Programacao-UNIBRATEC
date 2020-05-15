using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício22_JurosEscolaNatacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorJuros, valorMensalidade, valorTotalJuros, valorTotalPagamento; 
            int diasAtraso;
            try
            {
                Console.Write("Qual o valor dos juros cobrado? R$ ");
                valorJuros = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantos foram os dias de atraso? ");
                diasAtraso = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o valor da mensalidade da Escola de Natação? R$ ");
                valorMensalidade = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Por favor, insira apenas NÚMEROS.");
                Console.ReadKey();
                return;
            }
            valorTotalJuros = valorJuros * diasAtraso;
            valorTotalPagamento = valorMensalidade + valorTotalJuros;

            Console.WriteLine("O valor total do juros é de R$ {0:N}", valorTotalJuros);
            Console.WriteLine("O valor total do pagamento é de R$ {0:N}", valorTotalPagamento);
            Console.ReadKey();

        }
    }
}
