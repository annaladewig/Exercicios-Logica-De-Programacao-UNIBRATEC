using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAnterior_Questão1ParEImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, numPares = 0, numImpares = 0;

            for(int contador = 1; contador <= 6; contador++)
            {
                Console.WriteLine("Informe um número: ");
                numero = Convert.ToDouble(Console.ReadLine());

                numero = Convert.ToInt32(numero);
            
                if (numero % 2 == 0)
                {
                    numPares = numPares + 1;
                }
                else
                {
                    numImpares = numImpares + 1;
                }
            }
            if (numPares > numImpares)
            {
                Console.WriteLine("Existem mais números PARES.");
            }
            else if (numImpares > numPares)
            {
                Console.WriteLine("Existem mais números ÍMPARES.");
            }
            else
            {
                Console.WriteLine("Os números ímpares e pares são IGUAIS.");
            }
            Console.ReadKey();
        }
    }
}
