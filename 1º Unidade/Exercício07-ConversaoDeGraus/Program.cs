using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício07_ConversaoDeGraus
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempFahrenheit, tempCelsius;

            Console.Write("Qual a temperatura em graus Fahrenheit? ");
            tempFahrenheit = Convert.ToDouble(Console.ReadLine());
            tempCelsius = (tempFahrenheit - 32) * 5 / 9;
            Console.WriteLine("A temperatura de {0}°F equivale a {1}°C.", tempFahrenheit, tempCelsius);
            Console.ReadKey();

          
        }
    }
}
