using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA_InverterTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int contador;

            Console.Write("Escreva um texto: ");
            texto = Console.ReadLine();
            texto.ToUpper();

            for (contador = (texto.Length) - 1; contador >= 0; contador = contador - 1)
            {
                Console.Write(texto.Substring(contador, 1));
            }
            Console.ReadKey();
        }
    }
}
