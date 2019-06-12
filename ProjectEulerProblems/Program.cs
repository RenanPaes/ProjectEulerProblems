using ProjectEulerProblems.Problems;
using ProjectEulerProblems.uteis;
using System;

namespace ProjectEulerProblems
{
    class Program
    {
        public static int option = 0;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("=========================================================================");
            Console.WriteLine("\n  Olá! Seja bem-vindo(a) à minha maratona de desafios do ProjectEuler.net!\n");
            Console.WriteLine("=========================================================================");

            Console.WriteLine("\nDesafios Disponíveis:");
            Console.WriteLine("\n(1) Multiples of 3 and 5");

            Console.Write("\nDigite o número do desafio ou 0 para sair: ");
            option = int.Parse(Console.ReadLine());

            Validacao validar = new Validacao();

            while (!validar.ValidaOption(option))
            {
                Console.WriteLine("Por favor, digite apenas números válidos (Até 663)");
                Console.Write("\nDigite o número do desafio: ");
                option = int.Parse(Console.ReadLine());
            }

            switch (option)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Problem1: If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9." +
                        "The sum of these multiples is 23." +
                        "Find the sum of all the multiples of 3 or 5 below 1000.\n\n");

                    Problem1 desafio1 = new Problem1();
                    Console.WriteLine("Answer:");
                    Console.WriteLine(desafio1.MultiplesOf3and5());

                    Console.WriteLine("\nObrigado!");
                    Console.ReadKey();

                    break;
            }

        }
    }
}
