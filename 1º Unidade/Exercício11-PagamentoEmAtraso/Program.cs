using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício11_PagamentoEmAtraso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada

            double valorParcela, valorJurosDia, valorMulta, valorTotalJuros, valorEncargo, valorPagamento;
            int diasAtraso;

            Console.Write("Qual o valor da parcela? R$ ");
            valorParcela = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantos dias de atraso? ");
            diasAtraso = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual valor dos juros por dia de atraso? R$ ");
            valorJurosDia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor da multa? R$ ");
            valorMulta = Convert.ToDouble(Console.ReadLine());

            // Processamento

            valorTotalJuros = diasAtraso * valorJurosDia;
            valorEncargo = valorTotalJuros + valorMulta;
            valorPagamento = valorParcela + valorEncargo;

            //Saída

            Console.WriteLine("O valor total dos juros é de R$ {0:N}", valorTotalJuros);
            Console.WriteLine("O valor total do encargo é de R$ {0:N}", valorEncargo);
            Console.WriteLine("O valor total do pagamento é de R$ {0:N}", valorPagamento);
            Console.ReadKey();      
        }


    }
}
