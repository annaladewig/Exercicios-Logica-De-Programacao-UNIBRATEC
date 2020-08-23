using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício10_SubRotina
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double valorPedido, distanciaEntrega;

                Console.WriteLine("Digite o valor do pedido: ");
                valorPedido = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a distância de entrega: ");
                distanciaEntrega = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("O valor do frete é:{0}", CalculoFrete(distanciaEntrega));
                Console.ReadKey();
            }
        }
            static double CalculoFrete(double distancia)
            {
                double valorFreteFinal = 0;

                if (distancia > 0 && distancia <= 1000)
                {
                    valorFreteFinal = 20 + (distancia * 0.50);
                }
                if (distancia > 1000)
                {
                    valorFreteFinal = 20 + (distancia * 0.40);
                }
                return valorFreteFinal;
            }
        
    }

}
    

