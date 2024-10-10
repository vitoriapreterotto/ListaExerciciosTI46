using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosTI46
{
    internal class Lista02
    {
        public void ex01()
        {
            decimal n1;

            Console.WriteLine("Escolha um número: ");
            n1 = decimal.Parse(Console.ReadLine());

            if (n1 > 20)
            {
                Console.WriteLine(n1);
            }

            Console.ReadKey();
        }

        public void ex02()
        {
            decimal n1;

            Console.WriteLine("Digite um número: ");
            n1 = decimal.Parse(Console.ReadLine());

            if (n1 > 10)
            {
                Console.WriteLine("É maior que 10!");
            }
            else
            {
                Console.WriteLine("Não é maior que 10!");
            }

            Console.ReadKey();
        }

        public void ex03()
        {
            decimal a, b, c, res;

            Console.WriteLine("Digite valores para A, B e C, respectivamente: ");
            a = decimal.Parse(Console.ReadLine());
            b = decimal.Parse(Console.ReadLine());
            c = decimal.Parse(Console.ReadLine());

            res = a + b;

            if (res < c)
            {
                Console.WriteLine("A + B é menor que C: " + res);
            }

            Console.ReadKey();
        }

        public void ex04()
        {
            decimal a, b, res;

            Console.WriteLine("Escolha 2 números: ");
            a = decimal.Parse(Console.ReadLine());
            b = decimal.Parse(Console.ReadLine());

            res = a + b;

            if (res > 10)
            {
                Console.WriteLine("A adição dos 2 números é: " + res);
            }

            Console.ReadKey();

        }

        public void ex05()
        {
            string nome, sexo, civil;
            decimal anos;

            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual seu sexo, feminino ou masculino? (F ou M) ");
            sexo = Console.ReadLine();

            Console.WriteLine("Estado civil?");
            civil = Console.ReadLine().ToLower();

            if (civil == "casada" && sexo == "F")
            {
                Console.WriteLine("Qual o seu tempo de casado(a) em anos? ");
                anos = decimal.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }

        public void ex06()
        {
            decimal numero;

            Console.WriteLine("Escolha um número: ");
            numero = decimal.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número escolhido é par!");
            }
            else
            {
                Console.WriteLine("O número escolhido é ímpar!");
            }

            Console.ReadKey();
        }

        public void ex07()
        {
            double a, b, c;

            Console.WriteLine("Digite dois valores inteiros: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
                Console.WriteLine(c);
            }
            else
            {
                c = a * b;
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }

        public void ex08()
        {
            double a, b;

            Console.WriteLine("Escolha um número, seja ele negativo ou positivo: ");
            a = double.Parse(Console.ReadLine());

            if (a >= 0)
            {
                b = a * 2;
                Console.WriteLine("O dobro desse número é: " + b);
            }
            else
            {
                b = a * 3;
                Console.WriteLine("O triplo desse número é : " + b);
            }

            Console.ReadKey();
        }

        public void ex09()
        {
            double n1, n2, n3;

            Console.WriteLine("Vamos ordernar os números em ordem crescente!");
            Console.WriteLine("Escolha 3 números: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            if (n1 == n2 || n1 == n3)
            {
                Console.WriteLine("Os valores são iguais!");
            }
            else
            {
                if (n1 > n2)
                {
                    if (n2 > n3)
                    {
                        Console.WriteLine("Números ordenados: " + n3 + " - " + n2 + " - " + n1);
                    }
                    else
                    {
                        if (n1 > n3)
                        {
                            Console.WriteLine("Números ordenados: " + n2 + " - " + n3 + " - " + n1);
                        }
                        else
                        {
                            Console.WriteLine("Números ordenados: " + n2 + " - " + n1 + " - " + n3);
                        }
                    }
                }
                else
                {
                    if (n2 > n3)
                    {
                        if (n1 > n3)
                        {
                            Console.WriteLine("Números ordenados: " + n3 + " - " + n1 + " - " + n2);
                        }
                        else
                        {
                            Console.WriteLine("Números ordenados: " + n1 + " - " + n3 + " - " + n2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Números ordenados: " + n1 + " - " + n2 + " - " + n3);
                    }
                }
            }

            Console.ReadKey();
        }

        public void ex10()
        {
            double n1, n2, n3;

            Console.WriteLine("Vamos ordernar os números em ordem decrescente!");
            Console.WriteLine("Escolha 3 números: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            if (n1 == n2 || n1 == n3)
            {
                Console.WriteLine("Os valores são iguais!");
            }
            else
            {
                if (n1 < n2)
                {
                    if (n2 < n3)
                    {
                        Console.WriteLine("Números ordenados: " + n3 + " - " + n2 + " - " + n1);
                    }
                    else
                    {
                        if (n1 < n3)
                        {
                            Console.WriteLine("Números ordenados: " + n2 + " - " + n3 + " - " + n1);
                        }
                        else
                        {
                            Console.WriteLine("Números ordenados: " + n2 + " - " + n1 + " - " + n3);
                        }
                    }
                }
                else
                {
                    if (n2 < n3)
                    {
                        if (n1 < n3)
                        {
                            Console.WriteLine("Números ordenados: " + n3 + " - " + n1 + " - " + n2);
                        }
                        else
                        {
                            Console.WriteLine("Números ordenados: " + n1 + " - " + n3 + " - " + n2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Números ordenados: " + n1 + " - " + n2 + " - " + n3);
                    }
                }
            }

            Console.ReadKey();
        }

        public void ex11()
        {
            decimal inicio, fim, duracao;

            Console.WriteLine("Digite a hora do início do jogo de xadrez (entre 0-23): ");
            inicio = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora de fim do jogo (entre 0-23): ");
            fim = decimal.Parse(Console.ReadLine());

            if (inicio < 0 || inicio > 23 || fim < 0 || fim > 23)
            {
                Console.WriteLine("Hora inválida!");
            }
            if (fim >= inicio)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = 24 - inicio + fim;
            }

            if (duracao > 24)
            {
                Console.WriteLine("O jogo passou de 24 horas em " + (duracao - 24) + " horas!");
            }
            else if (duracao < 24)
            {
                Console.WriteLine("O jogo durou " + duracao + " horas e restam " + (24 - duracao) +
                                    " horas para completar 24 horas");
            }
            else
            {
                Console.WriteLine("O jogo durou exatamente 24 horas!");
            }

            Console.ReadKey();
        }
    }
 }
