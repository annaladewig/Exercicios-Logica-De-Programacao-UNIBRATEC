using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício18_ValorEPercentualPagoPorMorador
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdApartamentos;
            double valorContaEnergia, valorContaAgua, valorRateioEnergia, valorRateioAgua, percentualPagoPorAptAgua, percentualPagoPorAptEnergia;
           
            //Entrada
            Console.Write("Qual a quantidade de apartamentos?");
            qtdApartamentos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Qual o valor da conta de energia? R$ ");
            valorContaEnergia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor da conta de água? R$ ");
            valorContaAgua = Convert.ToDouble(Console.ReadLine());
            
            //Procesamento
            valorRateioEnergia = (double) valorContaEnergia / qtdApartamentos;
            valorRateioAgua = (double) valorContaAgua / qtdApartamentos;
            percentualPagoPorAptAgua = valorRateioAgua/valorContaAgua *100;
            percentualPagoPorAptEnergia = valorRateioEnergia/valorContaEnergia * 100;

            //Saída
            Console.WriteLine("O valor que cada apartamento irá pagar de energia é R$ " + valorRateioEnergia);
            Console.WriteLine("O valor que cada apartamento irá pagar de água é R$ " + valorRateioAgua);
            Console.WriteLine("O valor do percentual que cada apartamento pagará pela água é de {0:F2}%.", percentualPagoPorAptAgua);
            Console.WriteLine("O valor do percentual que cada apartamento pagará pela energia é de {0:F2}%.", percentualPagoPorAptEnergia);
            Console.ReadKey();
        }
    }
}
