using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosTI46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            Lista01 lista01 = new Lista01();
            Lista02 lista02 = new Lista02();
            Lista03 lista03 = new Lista03();
            Lista04 lista04 = new Lista04();

            do
            {

                Console.WriteLine("1 - Exercício 1 da Lista 01");
                Console.WriteLine("2 - Exercício 2 da Lista 01");
                Console.WriteLine("3 - Exercício 3 da Lista 01");
                Console.WriteLine("4 - Exercício 4 da Lista 01");
                Console.WriteLine("5 - Exercício 5 da Lista 01");
                Console.WriteLine("6 - Exercício 6 da Lista 01");
                Console.WriteLine("7 - Exercício 7 da Lista 01");
                Console.WriteLine("8 - Exercício 8 da Lista 01");
                Console.WriteLine("9 - Exercício 9 da Lista 01");
                Console.WriteLine("10 - Exercício 10 da Lista 01");
                Console.WriteLine("11 - Exercício 01 da Lista 02");
                Console.WriteLine("12 - Exercício 02 da Lista 02");
                Console.WriteLine("13 - Exercício 03 da Lista 02");
                Console.WriteLine("14 - Exercício 04 da Lista 02");
                Console.WriteLine("15 - Exercício 05 da Lista 02");
                Console.WriteLine("16 - Exercício 06 da Lista 02");
                Console.WriteLine("17 - Exercício 07 da Lista 02");
                Console.WriteLine("18 - Exercício 08 da Lista 02");
                Console.WriteLine("19 - Exercício 09 da Lista 02");
                Console.WriteLine("20 - Exercício 10 da Lista 02");
                Console.WriteLine("21 - Exercício 11 da Lista 02");
                Console.WriteLine("22 - Exercício 01 da Lista 03");
                Console.WriteLine("23 - Exercício 02 da Lista 03");
                Console.WriteLine("24 - Exercício 03 da Lista 03");
                Console.WriteLine("25 - Exercício 04 da Lista 03");
                Console.WriteLine("26 - Exercício 05 da Lista 03");
                Console.WriteLine("27 - Exercício 06 da Lista 03");
                Console.WriteLine("28 - Exercício 01 da Lista 03");
                Console.WriteLine("29 - Exercício 02 da Lista 03");


                int escolha = Convert.ToInt32(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        lista01.exercicio01();
                        break;

                    case 2:
                        lista01.execicio02();
                        break;

                    case 3:
                        lista01.exercicio03();
                        break;

                    case 4:
                        lista01.exercicio04();
                        break;

                    case 5:
                        lista01.exercicio05();
                        break;

                    case 6:
                       lista01.exercicio06();
                        break;

                    case 7:
                        lista01.exercicio07();
                        break;

                    case 8:
                        lista01.exercicio08();
                        break;

                    case 9:
                        lista01.exercicio09();
                        break;

                    case 10:
                        lista01.exercicio10();
                        break;

                    case 11:
                        lista02.ex01();
                        break;

                    case 12:
                        lista02.ex02();
                        break;

                    case 13:
                        lista02.ex03();
                        break;

                    case 14:
                        lista02.ex04();
                    break;

                    case 15:
                        lista02.ex05();
                        break;

                    case 16:
                        lista02.ex06();
                        break;

                    case 17:
                        lista02.ex07();
                        break;

                    case 18:
                        lista02.ex08();
                        break;

                    case 19:
                        lista02.ex09();
                        break;

                    case 20:
                        lista02.ex10();
                        break;

                    case 21:
                        lista02.ex11();
                        break;

                    case 22:
                        lista03.atividade01();
                        break;

                    case 23:
                        lista03.atividade02();
                        break;

                    case 24:
                        lista03.atividade03();
                        break;

                    case 25:
                        lista03.atividade04();
                        break;

                    case 26:
                        lista03.atividade05();
                        break;

                    case 27:
                        lista03.atividade06();
                        break;

                    case 28:
                        lista04.at01();
                        break;

                    case 29:
                        lista04.at02();
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }

                Console.WriteLine("Deseja continuar no programa? (S/N)");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao == "S"); 

        }
    }
}
