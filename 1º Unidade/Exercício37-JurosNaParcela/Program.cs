using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício37_JurosNaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            const double juros = 0.004;
            double valorParcela, valorJuros, valorTotalPagamento;
            int diaVencimento, diaPagamento, diasAtraso;

            Console.Write("Qual o valor da parcela? R$ ");
            valorParcela = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o dia do vencimento? ");
            diaVencimento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o dia do pagamento? ");
            diaPagamento = Convert.ToInt32(Console.ReadLine());

            if (diaPagamento > diaVencimento)
            {
                diasAtraso = diaPagamento - diaVencimento;
                Console.WriteLine("Existe um total de {0} dias de atraso.", diasAtraso);
                valorJuros = diasAtraso * valorParcela * juros;
                Console.WriteLine("O valor do juros a ser pago é de {0:}.", valorJuros);
                valorTotalPagamento = valorParcela + valorJuros;
                Console.WriteLine("O valor total de pagamento foi de {0}.", valorTotalPagamento);
            }
            else
            {
                Console.WriteLine("O pagamento foi realizado dentro do prazo.");
                Console.WriteLine("O valor do pagamento foi de {0}", valorParcela);
            }
            Console.ReadKey();
        }
    }
}
