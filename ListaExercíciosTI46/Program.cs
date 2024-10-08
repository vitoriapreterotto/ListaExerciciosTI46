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
                        ex05();
                        break;

                    case 16:
                        ex06();
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }

                Console.WriteLine("Deseja continuar no programa? (S/N)");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao == "S"); 

        }

        private static void ex06()
        {
            throw new NotImplementedException();
        }

        private static void ex05()
        {
            string nome, sexo, civil;
            decimal anos;

            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual seu sexo, feminino ou masculino? ");
            sexo = Console.ReadLine().ToUpper();

            Console.WriteLine("Estado civil? ");
            civil = Console.ReadLine().ToUpper();

            if (civil == "Casada")
            {
                Console.WriteLine("Qual o seu tempo de casado(a) em anos? ");
                anos = decimal.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
