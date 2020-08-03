using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_03___Sub_Rotina
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string texto;
                Console.WriteLine("digite o texto: ");
                texto = Console.ReadLine();
                Console.WriteLine("O texto possui {0} vogais.", Vogais(texto.ToUpper()));
                Console.ReadKey();
            }



        }
        static int Vogais(string frase)
        {
            int qtdVogais = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase.Substring(i, 1) == "A" || frase.Substring(i, 1) == "E" || frase.Substring(i, 1) == "I" || frase.Substring(i, 1) == "O" || frase.Substring(i, 1) == "U")
                {
                    qtdVogais++;
                }
            }
            return qtdVogais;

        }
    }
}
