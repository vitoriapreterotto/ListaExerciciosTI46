using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosTI46
{
    internal class Lista03
    {
        public void atividade01()
        {
            decimal n1, n2, n3, res;

            Console.WriteLine("Escolha 3 números: ");
            n1 = decimal.Parse(Console.ReadLine());
            n2 = decimal.Parse(Console.ReadLine());
            n3 = decimal.Parse(Console.ReadLine());

            res = n1 + n2 + n3;

            Console.WriteLine("A soma desses números é: " + res);

            Console.ReadKey();
        }

        public void atividade02()
        {
            double n1, n2, n3, n4, media;

            Console.WriteLine("Insira as 4 notas do aluno: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("A média do aluno é: " + media);

            Console.ReadKey();
        }

        public void atividade03()
        {
            string nome;

            do
            {
                Console.WriteLine("Digite o nome correto: ");
                nome = Console.ReadLine().ToLower();
            } while (nome == "João");

            Console.WriteLine("Parabéns, você digitou o nome correto!");

            Console.ReadKey();
        }

        public void atividade04()
        {
            double cont, inicio, fim, i;

            cont = 0;
            inicio = 35;
            fim = 98111;

            for (i = inicio; i <= fim; i++)
            {
                if (i % 2 == 0)
                {
                    cont++;
                }
            }

            Console.WriteLine("A quantidade de números pares entre 35 e 98.111 é: " + cont);

            Console.ReadKey();
        }

        public void atividade05()
        {
            int soma = 0, i;

            for (i = 1; i <= 5000; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("A soma dos números ímpares entre 1 e 5000 é de: " + soma);

            Console.ReadKey();
        }

        public void atividade06()
        {
            int tab, res, i;

            Console.WriteLine("Escolha um número para ver sua tabuada: ");
            tab = int.Parse(Console.ReadLine());

            res = 0;
            for (i = 1; i <= 10; i++)
            {
                res = tab * i;
                Console.WriteLine(tab + " * " + i + " = " + res);
            }

            Console.ReadKey();
        }
    }
}
