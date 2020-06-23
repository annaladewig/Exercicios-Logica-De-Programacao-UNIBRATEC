using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício48_Catraca
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicialContador, finalContador, diferencaContador, qtdPassageiros;
            double valorTotalApurado;
            const double valorPassagem = 4.50;

            Console.WriteLine("Qual o número inicial do contador da catraca?");
            inicialContador = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o número final do contador da catraca?");
            finalContador = Convert.ToInt32(Console.ReadLine());

            diferencaContador = finalContador - inicialContador;

            if (diferencaContador < 0)
            {
                finalContador = finalContador + 999999;
                diferencaContador = finalContador - inicialContador;
            }

            qtdPassageiros = diferencaContador;
            valorTotalApurado = qtdPassageiros * valorPassagem;
            Console.WriteLine("A quantidade total de passageiros foi de {0}.", qtdPassageiros);
            Console.WriteLine("O valor total apurado foi de R$ {0:N}.", valorTotalApurado);
            Console.ReadKey();




        }
    }
}
