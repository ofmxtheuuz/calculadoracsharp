using System;

namespace MyApp 
{
    class Program
    {
        static void Main(string[] args)
        {   
            try { 
                // configs
                Console.Title = "Calculadora Simples do hx";

                // auth
                Console.WriteLine("Insira o seu nome abaixo:");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Olá, {name} seja muito bem-vindo(a) a calculadora!");
                Console.WriteLine("");
                Console.WriteLine("");

                // calculator
                Console.WriteLine("Qual seu primeiro número selecionado?");
                decimal number = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Ótimo, {name}! O Seu primeiro número é {number}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Qual será o seu segundo número?");
                decimal number2 = decimal.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Otímo! Quase lá, o que você deseja fazer?");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("1. Multiplicação");
                Console.WriteLine("2. Adição");
                Console.WriteLine("3. Subtração");"
                Console.WriteLine("4. Divisão");

                // user choose
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    // *
                    Console.Clear();
                    decimal result = number * number2;
                    Console.WriteLine($"Seu resultado é: {result}");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                if (choose == 2)
                {
                    // +
                    Console.Clear();
                    decimal result = number + number2;
                    Console.WriteLine($"Seu resultado é: {result}");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                if (choose == 3)
                {
                    // -
                    Console.Clear();
                    decimal result = number - number2;
                    Console.WriteLine($"Seu resultado é: {result}");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                if (choose == 4) 
                {
                    Console.Clear();
                    decimal result = number / number2;
                    decimal r = number % number2;
                    Console.WriteLine($"Seu resultado é: {result} ({r} de resto)");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            } catch(e) {
                // an error ocurred
                Console.WriteLine("Ocorreu um erro!")
                // exit with error code zero
                Environment.Exit(0)
            }
        }
    }
}
