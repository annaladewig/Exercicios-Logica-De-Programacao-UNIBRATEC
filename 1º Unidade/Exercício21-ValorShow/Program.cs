using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício21_ValorShow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada

            int qtdHoraApresentação;
            const double valorPorKm = 8.0, comissãoPorKm = 0.35;
            double valorHoraApresentação, quilometragem, transporteEqui, valorTotalShow, valorShow;

            try
            {
                Console.Write("Qual a duração do show em horas? ");
                qtdHoraApresentação = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o valor por hora de apresentação? R$ ");
                valorHoraApresentação = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantos km são percorridos para a apresentação? ");
                quilometragem = Convert.ToDouble(Console.ReadLine());

            }

            catch
            {
                Console.Write("Por favor, digite apenas »» NÚMEROS ««");
                Console.ReadKey();
                return;
            }

            // Processamento

            valorShow = qtdHoraApresentação * valorHoraApresentação;
            valorTotalShow = valorShow + (quilometragem * valorPorKm);
            transporteEqui = quilometragem * valorPorKm * comissãoPorKm;

            // Saída 

            Console.WriteLine(" O valor cobrado por um show é de R$ {0:N}", valorTotalShow);
            Console.WriteLine("A comissão do transportador é de R$ {0:N}", transporteEqui);
            Console.ReadKey();
        }
    }
}
