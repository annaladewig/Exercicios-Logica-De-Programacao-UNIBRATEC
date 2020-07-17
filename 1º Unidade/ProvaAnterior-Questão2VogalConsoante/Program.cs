using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAnterior_Questão2VogalConsoante
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, ultimaLetra;
            Console.WriteLine("Escreva um nome: ");
            nome = Console.ReadLine();

            ultimaLetra = nome.Substring((nome.Length)-1, 1);
            ultimaLetra = ultimaLetra.ToUpper();
            if (ultimaLetra != "A" && ultimaLetra != "E" && ultimaLetra != "I" && ultimaLetra != "O" && ultimaLetra != "U")
            {
                Console.WriteLine("O nome termina com CONSOANTE.");
            }
            else
            {
                Console.WriteLine("O nome termina com VOGAL.");
            }
            Console.ReadKey();
        }
    }
}
