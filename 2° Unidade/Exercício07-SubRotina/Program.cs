using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício07_SubRotina
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Escreva um texto: ");
            texto = Console.ReadLine();
            texto = texto.ToUpper();

            Console.WriteLine("O texto escrito sem as vogais fica {0}.", TextoSemVogais(texto));
            Console.ReadKey();

        }

        static string TextoSemVogais(string frase)
        {
            string semVogais ="";
            for (int i=0; i < frase.Length; i++)
            {
                if (frase.Substring(i, 1) != "A" && frase.Substring(i, 1) != "E" && frase.Substring(i, 1) != "I" && frase.Substring(i, 1) != "O" && frase.Substring(i, 1) != "U")
                {
                    semVogais = semVogais + frase.Substring(i, 1);
                }
           
            }
            return semVogais;
        }
    }
}
