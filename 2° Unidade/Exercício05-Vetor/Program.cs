using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício05_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = { "Anna", "Lícia", "Amanda", "Raphael", "Danielle", "Leon", "Júlia", "Ryan", "Afonso", "Gabriel" };

            string nomeProcurado = "";
            bool erro = false;

            Console.WriteLine("Qual o nome: ");
            nomeProcurado = Console.ReadLine();
            nomeProcurado = nomeProcurado.ToUpper();

            for (int i = 0; i < nome.Length; i++)
            {
                nome[i] = nome[i].ToUpper();

                if (nomeProcurado == nome[i])
                {
                    Console.WriteLine("Nome encontrado na {0}º posição.", i + 1);
                    erro = true;
                }
            }

            if (erro == false)
            {
                Console.WriteLine("Nome não encontrado.");
            }

            Console.ReadKey();
        }
    }
}
