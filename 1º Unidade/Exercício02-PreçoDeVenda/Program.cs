using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02_PreçoDeVenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double custo, frete, lucro, precoFinal;

            Console.Write("Qual o valor do custo do produto? R$");
            custo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor do frete? R$");
            frete = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o valor do lucro almejado? R$");
            lucro = Convert.ToDouble(Console.ReadLine());
            precoFinal = custo + frete + lucro;
            Console.Write("O preço de venda será de " + precoFinal);
            Console.ReadKey();
        }
    }
}
