using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício11_SubRotina
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Escreva um texto contendo apenas números: ");
            texto = Console.ReadLine();

            if (ParImpar(texto) == "P")
            {
                Console.WriteLine("Números Pares");
            }
            else if (ParImpar(texto) == "I")
            {
                Console.WriteLine("Números Ímpares");
            }
            else
            {
                Console.WriteLine("Números Pares e Ímpares");
            }
            Console.ReadKey();
        }

        static string ParImpar(string textonum)
        {
            int par = 0, impar = 0;
            string parImpar = "";

            for (int i = 0; i < textonum.Length; i++)
            {
                if (Convert.ToDouble(textonum.Substring(i, 1)) % 2 == 0)
                {
                    par++;
                }
                if (Convert.ToDouble(textonum.Substring(i, 1)) % 2 == 1)
                {
                    impar++;
                }
            }

            if (par == Convert.ToInt32(textonum.Length))
            {
                parImpar = "P";
            }
            else if (impar == Convert.ToInt32(textonum.Length))
            {
                parImpar = "I";
            }
            else
            {
                parImpar = "X";
            }

            return parImpar;
        }
    }
}
 
