using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício38_Mensalidade
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorParcela, totalPagamentoComJuros, totalPagamentoComDesconto; ;
            int diaPagamento, diasAtraso;
            const int diaVencimento = 5;
            const double jurosPorDia = 0.004;
            const double percentualDesconto = 0.05;

            Console.Write("Qual o valor da parcela? R$ ");
            valorParcela = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o dia do pagamento? ");
            diaPagamento = Convert.ToInt32(Console.ReadLine());

            if (diaPagamento > diaVencimento)
            {
                diasAtraso = diaPagamento - diaVencimento;
                Console.WriteLine("Você teve um total de {0} dias de atraso.", diasAtraso);
                totalPagamentoComJuros = valorParcela + (valorParcela * jurosPorDia * diasAtraso);
                Console.WriteLine("O total do pagamento com juros será de R${0:N}.", totalPagamentoComJuros);
            }
            else
            {
                Console.WriteLine("Você fez o pagamento dentro do prazo.");
                totalPagamentoComDesconto = valorParcela - (valorParcela * percentualDesconto);
                Console.WriteLine("O total de pagamento com desconto será de R${0:N}", totalPagamentoComDesconto);
            }
            Console.ReadKey();
        }
    }
}
