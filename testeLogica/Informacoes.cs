using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace testeLogica
{
    internal class Informacoes
    {
        private String frase;
        private String nome;
        private String email;
        private String[] partes;
        private long telefone;
        private long rg;
        private int num;
        private int cont;
        private bool y = true;
        private bool z = true;
        private bool x = true;
        private bool x1 = true;
        private bool x2 = true;
        private bool x3 = true;

        public void dados()
        {
            while (y)
            {
                while (x)
                {
                    Console.Write("Escreva seu nome: ");
                    nome = Console.ReadLine();

                    if (nome.Length > 200)
                    {
                        Console.WriteLine("Insira em ate 200 caracteres");
                    }
                    else if (!Regex.IsMatch(nome, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Só podem existir caracteres na string");
                    }
                    else
                    {
                        x = false;
                        break;
                    }
                }

                while (x1)
                {
                    Console.Write("Escreva seu email: ");
                    email = Console.ReadLine();

                    if (email.Length > 200)
                    {
                        Console.WriteLine("Insira em ate 200 caracteres");
                    }
                    else if (!email.Contains("@") || !email.Contains(".")) 
                    {
                        Console.WriteLine("O email precisa de um @ e um ponto ");
                    }
                    else  
                    {
                        partes = email.Substring(0).Split('@');
                        foreach (string parte in partes)
                        {
                            cont++;
                        }
                        if (cont > 2)
                        {
                            Console.WriteLine("email invalido");
                            cont = 0;
                        }
                        else
                        {
                            x1 = false;
                            break;
                        }
                    }
                }

                while (x2)
                {
                    Console.Write("Escreva seu telefone: ");
                    while (!long.TryParse(Console.ReadLine(), out telefone))
                    {
                        Console.WriteLine("Informe apenas numeros inteiros");
                        Console.Write("Escreva seu telefone: ");
                    }
                    if (telefone > 99999999999 || telefone < 10000000000)
                    {
                        Console.WriteLine("Insira apenas 11 caracteres");
                    }
                    else
                    {
                        x2 = false;
                        break;
                    }
                }

                while (x3)
                {
                    Console.Write("Escreva seu Rg: ");
                    while (!long.TryParse(Console.ReadLine(), out rg))
                    {
                        Console.WriteLine("Informe apenas numeros inteiros");
                        Console.Write("Escreva seu Rg: ");
                    }
                    if (rg > 9999999999 || rg < 1000000000)
                    {
                        Console.WriteLine("Insira apenas 10 caracteres");
                    }
                    else
                    {
                        x3 = false;
                        break;
                    }
                }

                frase = "nome: " + nome + ", email: " + email + ", telefone: " + telefone + ", Rg: " + rg;

                File.WriteAllText("infos.txt", frase);

                //imprime os dados
                String[] linhas = File.ReadAllLines("infos.txt");

                Console.WriteLine();
                Console.WriteLine("Lendo Arquivo: ");

                foreach (var linha in linhas)
                {
                    Console.WriteLine(linha);
                }


                Console.WriteLine("Tentar de novo??");
                Console.WriteLine("1 - sim / 2 - nao");

                while (!int.TryParse(Console.ReadLine(), out num) || num <= 0 || num > 2)
                {
                    Console.WriteLine("1 - sim / 2 - nao");
                }

                if (num == 1)
                {
                    y = true;
                    x = true;
                    x1 = true;
                    x2 = true;
                    x3 = true;
                }
                else if (num == 2)
                {
                    y = false;
                }
            }
        }
    }
}