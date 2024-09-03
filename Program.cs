using System;
using System.ComponentModel.Design;
using System.Net;
using System.Security.Authentication.ExtendedProtection;

namespace Calculadora
{
    class Program
    {
        public static void Main()
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("\t- - - Menu - - -");
            Console.WriteLine("");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("");
            Console.Write("Escolhar uma opção: ");
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        public static void Soma()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Primeiro valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float soma = valor1 + valor2;

            Console.WriteLine($"A soma entre {valor1} e {valor2} é {soma}");

            Console.ReadKey();

            Menu();
        }

        public static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float subtracao = valor1 - valor2;

            Console.WriteLine($"A subratação entre {valor1} e {valor2} é {subtracao}");

            Console.ReadKey();

            Menu();
        }

        public static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float multiplicacao = valor1 * valor2;

            Console.WriteLine($"A multiplicaco entre {valor1} e {valor2} é {multiplicacao}");

            Console.ReadKey();

            Menu();
        }

        public static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float divisao = valor1 / valor2;

            Console.WriteLine($"A divisão entre {valor1} e {valor2} é {divisao}");

            Console.ReadKey();

            Menu();
        }
    }
}
