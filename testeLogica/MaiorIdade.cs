using System;
using System.Text.RegularExpressions;

namespace testeLogica
{
    internal class MaiorIdade
    {
        private int idade = 0;
        private string nome;
        private int num;
        private bool x = true;
        private bool y = true;
        private bool z = true;
        private bool l = true;

        public void maiorIdade()
        {
            while (z)
            {
                while (y)
                {
                    Console.Write("Digite seu nome: ");
                    nome = Console.ReadLine();


                    if (!Regex.IsMatch(nome, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Só podem existir caracteres na string");
                    }
                    else if (nome.Length > 200)
                    {
                        Console.WriteLine("Insira em ate 200 caracteres");
                        nome = Console.ReadLine();
                    }
                    else
                    {
                        y = false;
                        break;
                    }
                }

                Console.Write("Digite sua idade: ");
                while (!int.TryParse(Console.ReadLine(), out idade) || idade > 110 || idade <= 0)
                {
                    Console.WriteLine("Informe um numero entre 1 a 110 e apenas um numero inteiro");
                    Console.Write("Digite sua idade: ");
                }

                if (idade > 0 && idade >= 18 && idade <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Permissao Concedida");
                    Console.ResetColor();
                }
                else if (idade > 0 && idade < 18)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Permissao negada");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("idade invalida");
                }

                Console.WriteLine("Tentar de novo??");
                Console.WriteLine("1 - sim / 2 - nao");

                while (!int.TryParse(Console.ReadLine(), out num) || num <= 0 || num > 2)
                {
                    Console.WriteLine("1 - sim / 2 - nao");
                }

                if (num == 1)
                {
                    z = true;
                    y = true;
                }
                else if (num == 2)
                {
                    z = false;
                }
            }
        }
    }
}
