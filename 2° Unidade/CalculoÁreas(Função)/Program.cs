using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoÁreas_Função_
{
    class Program
    {
        static void Main(string[] args)
        {// Calculo de Áreas (Sub rotina FUNÇÃO com passagem de parametro)
            int opcao = 0;
            while (true)
            {
                // Exibe o menu
                #region    
                Console.Clear();
                Mensagem("*** MENU - CALCULO DE ÁREAS ***", false);
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
                    Mensagem("Opção Inválida. Digite uma tecla para continuar.", true);
                    continue;
                }


                switch (opcao)
                {
                    case 1:
                        // Calculo da área de um retangulo
                        Console.WriteLine();
                        Console.WriteLine("A área do Retangulo é: {0}", AreaRetangulo());
                        Mensagem("Digite uma tecla para continuar.", true);
                        continue;
                    case 2:
                        // Calculo da área de um triangulo
                        Console.WriteLine();
                        Console.WriteLine("A área do Triangulo é: {0}", AreaTriangulo());
                        Mensagem("Digite uma tecla para continuar.", true);
                        continue;
                    case 3:
                        // Calculo da área de um círculo
                        Console.WriteLine();
                        Console.WriteLine("A área do Circulo é: {0}", AreaCirculo());
                        Mensagem("Digite uma tecla para continuar.", true);
                        continue;
                    case 0:
                        return;

                    default:
                        Mensagem("Opção Inválida. Digite uma tecla para continuar.", true);
                        continue;
                }
            }
        }

        static double AreaRetangulo()
        {
            Console.Clear();
            Mensagem("*** CALCULO DA ÁREA DE RETÂNGULO ***", false);
            double BaseRet, AlturaRet, AreaRet;
            Console.Write("Base: ");
            BaseRet = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura: ");
            AlturaRet = Convert.ToDouble(Console.ReadLine());
            AreaRet = BaseRet * AlturaRet;
            return AreaRet;
        }

        static double AreaTriangulo()
        {
            Console.Clear();

            Mensagem("*** CALCULO DA ÁREA DE TRIÂNGULO ***", false);
            double BaseTri, AlturaTri, AreaTri;
            Console.Write("Base: ");
            BaseTri = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura: ");
            AlturaTri = Convert.ToDouble(Console.ReadLine());
            AreaTri = BaseTri * AlturaTri / 2;
            return AreaTri;
        }

        static double AreaCirculo()
        {
            Console.Clear();
            Mensagem("*** CALCULO DA ÁREA DO CÍRCULO ***", false);
            double RaioCirc, AreaCirc;
            Console.Write("Raio: ");
            RaioCirc = Convert.ToDouble(Console.ReadLine());
            AreaCirc = Math.PI * Math.Pow(RaioCirc, 2);
            return AreaCirc;
        }

        /*
         * Nome: Mensagem
         * Descrição: Mostrar uma mensagem, podendo solicitar para apertar uma tecla para continuar
         * Parametros:
         * - texto (string): Mensagem a ser exigida
         * - pausa (bool): Indicador para efetuar uma pausa ou não
         *   - true: efetua pausa e solicita que seja apertada uma tecla para continuar
         *   - false: não efetua pausa
         * Retorno: Não tem
        */
        static void Mensagem(string texto, bool pausa)
        {
            Console.WriteLine();
            Console.WriteLine(texto);
            Console.WriteLine();

            if (pausa == true)
            {
                Console.ReadKey();
            }
        }
    }
    
}
