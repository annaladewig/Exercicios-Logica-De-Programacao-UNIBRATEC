using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício24_Caminhada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            int horaInicial, minutoInicial, horaFinal, minutoFinal;
            double distanciaPercorrida,totalMinutos, distanciaPorMinuto;

            //Entradas
            try
            {
                Console.Write("Qual a hora inicial da caminhada (sem os minutos)? ");
                horaInicial = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o minuto inicial da caminhada? ");
                minutoInicial = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual a hora final da caminhada (sem os minutos)? ");
                horaFinal = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o minuto final da caminhada? ");
                minutoFinal = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual a distância total percorrida em metros?");
                distanciaPercorrida = Convert.ToDouble(Console.ReadLine());

            }
            catch
            {
                Console.Write("Por favor, digite apenas NÚMEROS.");
                Console.ReadKey();
                return;
            }
            //Processamento
            totalMinutos = ((horaFinal * 60) + minutoFinal) - ((horaInicial * 60) + minutoInicial);
            distanciaPorMinuto = distanciaPercorrida / totalMinutos;

            //Saída
            Console.WriteLine("A quantidade total de tempo percorrido foi de {0} minutos.", totalMinutos);
            Console.WriteLine("A distância percorrida foi de {0:F} metros por minuto.", distanciaPorMinuto);
            Console.ReadKey();

        }

    }
}
