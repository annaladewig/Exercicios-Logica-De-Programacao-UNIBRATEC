using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício55_IPVA
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;
            double valorVeiculo, ipva = 0, ipvaJaneiro = 0, ipvaFevereiro = 0, ipvaMarço = 0, ipvaAbril = 0, ipvaTotal = 0;
            string placaVeiculo;

            for (contador = 1; contador <= 6; contador++)
            {
                Console.WriteLine("Qual a placa do {0}° veículo? ", contador);
                placaVeiculo = Console.ReadLine();
                placaVeiculo.ToUpper();
                Console.WriteLine("Qual o valor do {0}° veículo? ", contador);
                valorVeiculo = Convert.ToDouble(Console.ReadLine());

                if (placaVeiculo.Substring(6, 1) == "1" || placaVeiculo.Substring(6, 1) == "2" ||
                    placaVeiculo.Substring(6, 1) == "3")
                {
                    Console.WriteLine("Seu mês de pagamento é JANEIRO.");
                    ipva = valorVeiculo * 0.10;
                    ipvaJaneiro = ipvaJaneiro + ipva;

                }
                if (placaVeiculo.Substring(6, 1) == "4" || placaVeiculo.Substring(6, 1) == "5" ||
                    placaVeiculo.Substring(6, 1) == "6")
                {
                    Console.WriteLine("Seu mês de pagamento é FEVEREIRO.");
                    ipva = valorVeiculo * 0.10;
                    ipvaFevereiro = ipvaFevereiro + ipva;
                }
                if (placaVeiculo.Substring(6, 1) == "7" || placaVeiculo.Substring(6, 1) == "8" ||
                    placaVeiculo.Substring(6, 1) == "9")
                {
                    Console.WriteLine("Seu mês de pagamento é MARÇO.");
                    ipva = valorVeiculo * 0.10;
                    ipvaMarço = ipvaMarço + ipva;
                }
                if (placaVeiculo.Substring(6, 1) == "0")
                {
                    Console.WriteLine("Seu mês de pagamento é ABRIL.");
                    ipva = valorVeiculo * 0.10;
                    ipvaAbril = ipvaAbril + ipva;
                }
            }
                Console.WriteLine("O total arrecadado de IPVA em JANEIRO foi de {0:N}.", ipvaJaneiro);
                Console.WriteLine("O total arrecadado de IPVA em FEVEREIRO foi de {0:N}.", ipvaFevereiro);
                Console.WriteLine("O total arrecadado de IPVA em MARÇO foi de {0:N}.", ipvaMarço);
                Console.WriteLine("O total arrecadado de IPVA em Abril foi de {0:N}.", ipvaAbril);

                ipvaTotal = ipvaJaneiro + ipvaFevereiro + ipvaMarço + ipvaAbril;
                Console.WriteLine("O total arrecadado de IPVA foi de {0:N}.", ipvaTotal);

                Console.ReadKey();
            
        }
    }
}
