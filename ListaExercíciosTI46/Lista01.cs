using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercíciosTI46
{
    internal class Lista01
    {
        internal object exercicio02;

        public void exercicio01()
        {
            string texto;

            Console.WriteLine("Olá, Mundo!!!");
            texto = Console.ReadLine();

            Console.ReadKey();
        }

        public void execicio02()
        {
            string texto;

            Console.WriteLine("Qual é o seu nome? ");
            texto = Console.ReadLine();

            Console.WriteLine("Olá " + texto + ", é um prazer te conhecer!");

            Console.ReadKey();
        }

        public void exercicio03()
        {
            string funcionario;
            decimal salario;

            Console.WriteLine("Nome do funcionário: ");
            funcionario = Console.ReadLine();

            Console.WriteLine("Salário: ");
            salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("O funcionário " + funcionario + " tem um salário de R$" + salario + " em Junho.");

            Console.ReadKey();

        }

        public void exercicio04()
        {
            decimal n1, n2, soma;

            Console.WriteLine("Digite um valor: ");
            n1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            n2 = decimal.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("A soma entre " + n1 + " e " + n2 + " é igual a " + soma);

            Console.ReadKey();
        }

        public void exercicio05()
        {
            double n1, n2, n3, media;

            Console.WriteLine("Digite as 3 notas: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("A média entre " + n1 + ", " + n2 + " e " + n3 + " é igual a " + media);

            Console.ReadKey();

        }

        public void exercicio06()
        {
            decimal n1, ante, sucessor;

            Console.WriteLine("Digite um número: ");
            n1 = decimal.Parse(Console.ReadLine());

            ante = n1 - 1;
            sucessor = n1 + 1;

            Console.WriteLine("O antecessor de " + n1 + " é " + ante);
            Console.WriteLine("O sucessor de " + n1 + " é " + sucessor);

            Console.ReadKey();
        }
        public void exercicio07()
        {
            double n1, dobro, terca;

            Console.WriteLine("Digite um número: ");
            n1 = double.Parse(Console.ReadLine());

            dobro = n1 * 2;
            terca = n1 / 3;

            Console.WriteLine("O dobro de " + n1 + " é " + dobro);
            Console.WriteLine("A terça parte de " + n1 + " é " + terca);

            Console.ReadKey();
        }

        public void exercicio08()
        {
            double numero, km, hm, dam, dm, cm, mm;

            Console.WriteLine("Digite uma distância em metros: ");
            numero = double.Parse(Console.ReadLine());

            km = numero / 1000;
            hm = numero / 100;
            dam = numero / 10;
            dm = numero * 10;
            cm = numero * 100;
            mm = numero * 1000;

            Console.WriteLine("A distância de " + numero + "m corresponde a: ");
            Console.WriteLine(km + "Km");
            Console.WriteLine(hm + "Hm");
            Console.WriteLine(dam + "Dam");
            Console.WriteLine(dm + "Dm");
            Console.WriteLine(cm + "cm");
            Console.WriteLine(mm + "mm");

            Console.ReadKey();
        }

        public void exercicio09()
        {
            double real, dolar;

            Console.WriteLine("Digite o valor em Real (R$): ");
            real = double.Parse(Console.ReadLine());

            dolar = real / 5.50;

            Console.WriteLine("Você pode comprar U$$ " + dolar);

            Console.ReadKey();

        }

        public void exercicio10()
        {
            double largura, altura, area, tinta;

            Console.WriteLine("Digite a largura da parede: ");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da parede: ");
            altura = double.Parse(Console.ReadLine());

            area = largura * altura;
            tinta = area / 2;

            Console.WriteLine("Para pintar uma área de " + area + "m², é necessário " + tinta + "L de tinta.");

            Console.ReadKey();
        }


    }
}
