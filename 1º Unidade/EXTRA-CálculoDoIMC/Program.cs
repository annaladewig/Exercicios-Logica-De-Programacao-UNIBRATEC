using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA_CálculoDoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, qtdObesidade = 0, qtdAbaixoDoPeso = 0;
            double peso, altura, imc;

            while (contador <=8)
            {
                try
                {
                    Console.WriteLine("Qual o peso da {0}º pessoa em Kg? ", contador);
                    peso = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Qual a altura da {0}º pessoa em metros? ", contador);
                    altura = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Por favor, digite apenas NÚMEROS.");
                    continue;
                }
                if (peso < 0 || altura < 0)
                {
                    Console.WriteLine("Digite um peso e/ou altura válido(s).");
                    continue;
                }

                imc = peso / (altura * altura);

                if (imc < 17)
                {
                    Console.WriteLine("MUITO ABAIXO DO PESO.");
                    qtdAbaixoDoPeso += 1;
                }
                else if (imc >= 17 && imc <= 18.49)
                {
                    Console.WriteLine("ABAIXO DO PESO.");
                    qtdAbaixoDoPeso += 1;
                }
                else if (imc >= 18.50 && imc <= 24.99)
                {
                    Console.WriteLine("PESO NORMAL.");
                }
                else if (imc >= 25 && imc <= 29.99) 
                {
                    Console.WriteLine("ACIMA DO PESO");
                }
                else if (imc >= 30 && imc <= 34.99)
                {
                    Console.WriteLine("Obesidade I.");
                    qtdObesidade += 1;
                }
                else if (imc >= 35 && imc <= 39.99)
                {
                    Console.WriteLine("Obesidade II (severa).");
                    qtdObesidade += 1;
                }
                else //imc >=40
                {
                    Console.WriteLine("Obesidade III (mórbida)");
                    qtdObesidade += 1;
                }
                
                contador++;
            }
            Console.WriteLine();
            Console.WriteLine(" Existe um total de {0} pessoas abaixo do peso.", qtdAbaixoDoPeso);
            Console.WriteLine(" Existe um total de {0} pessoas com algum grau de obesidade.", qtdObesidade);
            Console.ReadKey();
        }
        
    }
}
