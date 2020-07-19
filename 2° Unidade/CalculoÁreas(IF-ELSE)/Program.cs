using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoÁreas_IF_ELSE_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculo de Áreas (Padrão IF)
            int opcao = 0;
            while (true)
            {
                // Exibe o menu
                #region    
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("*** MENU - CALCULO DE ÁREAS ***");
                Console.WriteLine();
                Console.WriteLine("1 - RETÂNGULO");
                Console.WriteLine("2 - TRIÂNGULO");
                Console.WriteLine("3 - CÍRCULO");
                Console.WriteLine("0 - FIM");
                Console.WriteLine();
                #endregion
                Console.Write("Digite a opção desejada: ");
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção Inválida. Digite uma tecla para continuar.");
                    Console.ReadKey();
                    continue;
                }

                if (opcao == 1)
                {
                    // Calculo da área de um retangulo
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("*** CALCULO DA ÁREA DE RETÂNGULO ***");
                    Console.WriteLine();
                    double BaseRet, AlturaRet, AreaRet;
                    Console.Write("Base: ");
                    BaseRet = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Altura: ");
                    AlturaRet = Convert.ToDouble(Console.ReadLine());
                    AreaRet = BaseRet * AlturaRet;
                    Console.WriteLine();
                    Console.WriteLine("Área do retângulo: {0}", AreaRet);
                    Console.WriteLine();
                    Console.WriteLine("Digite uma tecla para continuar.");
                    Console.ReadKey();
                    continue;
                }
                else if (opcao == 2)
                {
                    // Calculo da área de um triangulo
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("*** CALCULO DA ÁREA DE TRIÂNGULO ***");
                    Console.WriteLine();
                    double BaseTri, AlturaTri, AreaTri;
                    Console.Write("Base: ");
                    BaseTri = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Altura: ");
                    AlturaTri = Convert.ToDouble(Console.ReadLine());
                    AreaTri = BaseTri * AlturaTri / 2;
                    Console.WriteLine();
                    Console.WriteLine("Área do triângulo: {0}", AreaTri);
                    Console.WriteLine();
                    Console.WriteLine("Digite uma tecla para continuar.");
                    Console.ReadKey();
                    continue;
                }
                else if (opcao == 3)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("*** CALCULO DA ÁREA DO CÍRCULO ***");
                    Console.WriteLine();
                    double RaioCirc, AreaCirc;
                    Console.Write("Raio: ");
                    RaioCirc = Convert.ToDouble(Console.ReadLine());
                    AreaCirc = Math.PI * Math.Pow(RaioCirc, 2);
                    Console.WriteLine();
                    Console.WriteLine("Área do círculo: {0}", AreaCirc);
                    Console.WriteLine();
                    Console.WriteLine("Digite uma tecla para continuar.");
                    Console.ReadKey();
                    continue;
                }
                else if (opcao == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção Inválida. Digite uma tecla para continuar.");
                    Console.ReadKey();
                    continue;
                }
            }
        }

    }
}