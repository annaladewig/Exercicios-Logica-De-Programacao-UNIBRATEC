using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA_IntercalarTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1, texto2, intercalamento, textoIntercalado = "";
            int contador;
            while (true)
            {
                Console.WriteLine("Digite um texto: ");
                texto1 = Console.ReadLine();
                texto1.ToUpper();
                texto1 = texto1.ToUpper();
                Console.WriteLine("Digite outro texto de mesmo tamanho do anterior: ");
                texto2 = Console.ReadLine();
                texto2 = texto2.ToUpper();

                if (texto1.Length != texto2.Length)
                {
                    Console.WriteLine("Os dois textos devem ter o mesmo tamanho.");
                    continue;
                }

                for (contador = 0; contador < texto1.Length; contador++)
                {
                    intercalamento = texto1.Substring(contador, 1) + texto2.Substring(contador, 1);
                    textoIntercalado = textoIntercalado + intercalamento;
                }
                Console.WriteLine(textoIntercalado);
                Console.ReadKey();
            }

        }
    }
}
