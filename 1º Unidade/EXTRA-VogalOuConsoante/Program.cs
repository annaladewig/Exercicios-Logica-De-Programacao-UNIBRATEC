using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA_VogalOuConsoante
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra = "";
            while (true)
            {
                Console.WriteLine("Digite um letra: ");
                letra = Console.ReadLine();
                letra = letra.ToUpper();
                if ((string.Compare(letra, "A") == -1) || string.Compare(letra, "Z") == 1)
                {
                    Console.WriteLine("digite apenas letras!!!");
                    Console.ReadKey();
                    continue;
                }
                break;
            }
            if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                Console.WriteLine("Vogal");
            }
            else
            {
                Console.WriteLine("Consoante");
            }
            Console.ReadKey();
        }
    }
}
