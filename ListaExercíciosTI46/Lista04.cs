using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosTI46
{
    internal class Lista04
    {
        public void at01()
        {
            int numero;

            Console.WriteLine("Escolha um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é ímpar!");
            }

            Console.ReadKey();
        }

        public void at02()
        {
            double idade;

            Console.WriteLine("Qual a sua idade? ");
            idade = double.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 12)
            {
                Console.WriteLine("Você é uma Criança");
            }
            else
            {
                if (idade >= 13 && idade <= 17)
                {
                    Console.WriteLine("Você é um Adolescente");
                }
                else
                {
                    if (idade >= 18 && idade <= 64)
                    {
                        Console.WriteLine("Você é um Adulto");
                    }
                    else
                    {
                        if (idade >= 65)
                        {
                            Console.WriteLine("Você é um Idoso");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
