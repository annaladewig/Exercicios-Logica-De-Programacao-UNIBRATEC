using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício17_PercentualDeJurosPago
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorParcela, valorPago, valorDoJuros, percentualDeJuros;

            //Entradas
            Console.Write("Qual o valor da parcela: R$ ");
            valorParcela = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor pago: R$ ");
            valorPago = Convert.ToDouble(Console.ReadLine());
            
            //Procesamento
            valorDoJuros = valorPago - valorParcela;
            percentualDeJuros = 100 * valorPago / valorParcela;
            
            //Saídas
            Console.WriteLine("O valor pago a mais de juros foi de R$ {0}.", valorDoJuros);
            Console.WriteLine("O percentual de juros cobrado foi de {0}%.", percentualDeJuros);
            Console.ReadKey();
        }
    }
}
