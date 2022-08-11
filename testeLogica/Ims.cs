using System;
using System.IO;

namespace testeLogica
{
    internal class Ims
    {
        int escolha;
        int x = 1;
        int consulta;
        int idade;
        string nome;
        double peso = 0, altura = 0;
        double IMS;
        string dados;
        bool loop = true;
        bool verificacao = true;
        bool y = true;

        public void consultaIms()
        {
            while (loop)
            {
                Console.WriteLine("Bem-Vindo a Consulta do IMS!!");
                Console.WriteLine("1 - Novo Cadastro");
                Console.WriteLine("2 - Consultar algum IMS");
                Console.WriteLine("3 - Sair");

                while (!int.TryParse(Console.ReadLine(), out escolha) || escolha <= 0 || escolha > 3)
                {
                    Console.WriteLine("Opcao invalida!!");
                    Console.WriteLine("1 - Novo Cadastro");
                    Console.WriteLine("2 - Consultar algum IMS");
                    Console.WriteLine("3 - Sair");
                }

                if (escolha == 1)
                {

                    Console.WriteLine("Novo Cadastro");
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    while (y)
                    {
                        if(nome.Length > 200)
                        {
                            Console.WriteLine("Insira em ate 200 caracteres");
                            Console.Write("Nome: ");
                            nome = Console.ReadLine();
                        }
                        else
                        {
                            y = false;
                            break;
                        }
                    }
                    Console.Write("Idade: ");
                    while (!int.TryParse(Console.ReadLine(), out idade))
                    {
                        Console.WriteLine("Insira apenas números inteiros");
                        Console.Write("Idade: ");
                    }
                    Console.Write("Peso: ");
                    while (!double.TryParse(Console.ReadLine(), out peso))
                    {
                        Console.WriteLine("Insira apenas números");
                        Console.Write("Peso: ");
                    }
                    Console.Write("Altura: ");
                    while (!double.TryParse(Console.ReadLine(), out altura))
                    {
                        Console.WriteLine("Insira apenas números");
                        Console.Write("Altura: ");
                    }

                    IMS = peso / (altura * altura);
                    dados = "nome: " + nome + ", idade: " + idade + ", peso: " + peso + ", altura: " + altura + ", IMS: " + IMS;

                    while (verificacao)
                    {
                        if (!File.Exists("texto" + x + ".txt"))
                        {
                            File.WriteAllText("texto" + x + ".txt", dados);
                            verificacao = false;
                        }
                        else
                        {
                            x++;
                        }
                    }
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Consultar algum IMS");
                    Console.Write("Digite o numero do arquivo: ");
                    consulta = int.Parse(Console.ReadLine());

                    if (consulta < 0 || !File.Exists("texto" + consulta + ".txt"))
                    {
                        Console.WriteLine("Numero da consulta consulta nao existe!!");
                    }
                    else
                    {
                        String[] linhas = File.ReadAllLines("texto" + consulta + ".txt");
                        Console.WriteLine("Lendo Arquivo: ");

                        foreach (var linha in linhas)
                        {
                            Console.WriteLine(linha);
                        }
                    }

                }
                else if (escolha == 3)
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Escolha invalida, tente de novo");
                }
            }
        }
    }
}