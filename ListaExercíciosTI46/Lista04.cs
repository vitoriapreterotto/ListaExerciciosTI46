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

        public void at03()
        {
            int nota;

            Console.WriteLine("Insira a nota do aluno: ");
            nota = int.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                if (nota >= 4 || nota >= 5.9)
                {
                    Console.WriteLine("Recuperação.");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }

            }

            Console.ReadKey();
        }

        public void at04()
        {
            double peso, altura, imc;

            Console.WriteLine("Qual é o seu peso? ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura? ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc <= 18.5)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else
            {
                if (imc > 18.5 || imc <= 24.9)
                {
                    Console.WriteLine("Peso Normal.");
                }
                else
                {
                    if (imc >= 25 || imc >= 29.9)
                    {
                        Console.WriteLine("Sobrepeso");
                    }
                    else
                    {
                        Console.WriteLine("Obesidade");
                    }
                }
            }

            Console.ReadKey();
        }

        public void at05()
        {
            int numero1, numero2;

            Console.WriteLine("Digite 2 números: ");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O maior número é: " + numero1);
            }
            else
            {
                if (numero1 < numero2)
                {
                    Console.WriteLine("O maior número é: " + numero2);
                }
                else
                {
                    Console.WriteLine("Os números são iguais!");
                }
            }

            Console.ReadKey();
        }

        public void at06()
        {
            int idade;

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18 && idade <= 70)
            {
                Console.WriteLine("Você é obrigado a votar!");
            }
            else
            {
                if (idade >= 16 || idade <= 17 && idade >= 70)
                {
                    Console.WriteLine("O seu voto é facultativo!");
                }
                else
                {
                    Console.WriteLine("Você ainda não pode votar!");
                }
            }

            Console.ReadKey();
        }

        public void at07()
        {
            double valor, desconto;

            Console.WriteLine("Digite o valor da sua compra: ");
            valor = double.Parse(Console.ReadLine());

            if (valor > 100)
            {
                desconto = (valor) - (valor * 0.1);
                Console.WriteLine("Parabéns! Você ganhou desconto de 10%! Seu valor final é de: " + desconto);
            }

            Console.ReadKey();
        }

        public void at08()
        {
            int temperatura;

            Console.WriteLine("Informe a temperatura atual: ");
            temperatura = int.Parse(Console.ReadLine());

            if (temperatura < 15)
            {
                Console.WriteLine("O clima está frio!");
            }
            else
            {
                if (temperatura >= 15 && temperatura <= 25)
                {
                    Console.WriteLine("A temperatura está agradável!");
                }
                else
                {
                    Console.WriteLine("O clima está quente!");
                }
            }

            Console.ReadKey();
        }

        public void at09()
        {
            double n1, n2, n3, media;

            Console.WriteLine("Digite as 3 notas do aluno: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }

            Console.ReadKey();
        }

        public void at10()
        {
            double ano;
            bool bissexto;

            Console.WriteLine("Digite um ano para descobrir se ele é bissexto: ");
            ano = double.Parse(Console.ReadLine());

            bissexto = (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0);

            if (bissexto)
            {
                Console.WriteLine("O ano " + ano + " é bissexto!");
            }
            else
            {
                Console.WriteLine("O ano " + ano + " não é bissexto!");
            }

            Console.ReadKey();
        }

    }
}
