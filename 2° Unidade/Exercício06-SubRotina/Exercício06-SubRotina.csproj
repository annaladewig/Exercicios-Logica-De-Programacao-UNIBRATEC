using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício06_SubRotina
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;

            Console.WriteLine("Escreva um texto contendo letras maiúsculas e minúsculas aleatoriamente: ");
            frase = Console.ReadLine();
            Console.WriteLine("Fazendo a troca, o texto fica: {0}", ConversorMaiuscMinusc(frase));
            Console.ReadKey();
        }

        static string ConversorMaiuscMinusc (string texto)
        {
            string novotexto = "";

            for (int i=0; i < texto.Length; i++)
            {

                if (texto.Substring(i,1) == texto.Substring(i,1).ToLower())
                {
                    novotexto += texto.Substring(i, 1).ToUpper();
                }
                else
                {
                    novotexto += texto.Substring(i, 1).ToLower();
                }
            }

            return novotexto;
        }
    }
}
