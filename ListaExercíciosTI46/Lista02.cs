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
    }
}
