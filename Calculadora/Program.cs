using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1,Subtracao,  Raiz, Multiplicacao, Divisao, Potencia, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo ao Calc!");
                Console.WriteLine("Escolha umas das opções a seguir: ");
                Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Raiz\n4 - Multiplicação\n5 - Divisão\n6 - Potência\n7 - Sair");
               
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Sair:
                        escolheuSair |= true;
                        break;
                }
                Console.Clear();
            }
        }
        static void Soma()
        {
            Console.WriteLine("Soma entre dois números!");
            int a = 0;
            int b = 0;
            Console.Write("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            int resultado = (a + b);

            Console.WriteLine($"A soma de {a} + {b} é: {resultado}");
            Console.WriteLine("Precione ENTER para voltar ao menu.");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            Console.WriteLine("Subtração entre dois números: ");
            int a = 0;
            int b = 0;
            Console.Write("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            int resultado = (a - b);

            Console.WriteLine($"O resultado de {a} - {b} é: {resultado}");
            Console.WriteLine("Precione ENTER para voltar ao menu.");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um número!");
            Console.Write("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"A raiz de {a} é: {resultado}");
            Console.WriteLine("Precione ENTER para voltar ao menu.");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números! ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o segundo número: ");
            int b = (int.Parse(Console.ReadLine()));
            double resultado = a * b;
            Console.WriteLine($"O resultado de {a} * {b} é: {resultado}");
            Console.WriteLine("Precione ENTER para voltar ao menu.");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números! ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o segundo número: ");
            int b = (int.Parse(Console.ReadLine()));
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado de {a} / {b} é: {resultado}");
            Console.WriteLine("Precione ENTER para voltar ao menu.");
            Console.ReadLine();

        }
        static void Potencia()
        {
            Console.WriteLine("Potência de um número!");
            Console.Write("Digite a base: ");
            int baseNum = (int.Parse(Console.ReadLine()));
            Console.Write("Digite o expoente: ");
            int expo = (int.Parse(Console.ReadLine()));
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Precione ENTER para voltar ao menu.");
            Console.ReadLine();
        }
    }
}

