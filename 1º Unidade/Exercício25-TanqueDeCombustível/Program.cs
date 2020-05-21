using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício25_TanqueDeCombustível
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            double inicialOdometro, finalOdometro, litrosAbastecidos, kmPercorridos, consumoKmPorLitro;

            //Entradas
            try
            {
                Console.Write("Qual o valor incial do odômetro em Km? ");
                inicialOdometro = Convert.ToDouble(Console.ReadLine());
                Console.Write("Qual o valor final do odômetro em Km? ");
                finalOdometro = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantos litros de gasolina foram abastecidos no final da viagem? ");
                litrosAbastecidos = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.Write("por favor, digite apenas NÚMEROS.");
                Console.ReadKey();
                return;
            }

            //Processamento
            kmPercorridos = finalOdometro - inicialOdometro;
            consumoKmPorLitro = kmPercorridos / litrosAbastecidos;

            //Saídas
            Console.WriteLine("O total de quilômetros percorridos foi de {0:F} km.", kmPercorridos);
            Console.WriteLine("O consumo total foi de {0:F} km por litro.", consumoKmPorLitro);
            Console.ReadKey();
        }
    }
}
