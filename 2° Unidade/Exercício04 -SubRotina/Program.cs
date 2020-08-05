using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício04__SubRotina
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1, texto2;
            int soma;
            Console.WriteLine("digite o primeiro texto: ");
            texto1 = Console.ReadLine();
            Console.WriteLine("digite o segundo texto: ");
            texto2 = Console.ReadLine();
            soma = Vogais(texto1.ToUpper()) + Vogais(texto2.ToUpper());
            Console.WriteLine("Os textos possuem {0} vogais.", soma);
            Console.ReadKey();
        }

        static int Vogais(string frase1)
        {
            int qtdVogais = 0;
            for (int i = 0; i < frase1.Length; i++)
            {
                if (frase1.Substring(i, 1) == "A" || frase1.Substring(i, 1) == "E" || frase1.Substring(i, 1) == "I" || frase1.Substring(i, 1) == "O" || frase1.Substring(i, 1) == "U")
                {
                    qtdVogais++;
                }
            }
            return qtdVogais;
        }
    }
}
