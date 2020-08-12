using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício05_SubRotina
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1, frase2;

            Console.WriteLine("Escreva um texto: ");
            frase1 = Console.ReadLine();
            Console.WriteLine("Escreva outro texto de igual tamanho do primeiro: ");
            frase2 = Console.ReadLine();

            Console.WriteLine("Existem {0} letras iguais na mesma posição dos textos.", QtdLetrasMesmaPosição(frase1, frase2));
            Console.ReadKey();
        }

        static int QtdLetrasMesmaPosição (string texto1, string texto2)
        {
            int contador = 0;
            for (int i=0; i< texto1.Length; i++)
            {
                if (texto1.Substring(i,1).ToUpper() == texto2.Substring(i,1).ToUpper())
                {
                    contador++;
                }

            }
            return contador;

        }
    }
}
