using System;

namespace testeLogica
{
    class Program
    {
        public static void Main(String[] args)
        {
            int num;
            bool y = true;

            while (y)
            {
                Console.WriteLine();
                Console.WriteLine("Escolha o exercicio de 1 a 7: ");
                Console.WriteLine("1 - Media");
                Console.WriteLine("2 - Vetor");
                Console.WriteLine("3 - Matrix");
                Console.WriteLine("4 - Maior idade");
                Console.WriteLine("5 - Troca de letras");
                Console.WriteLine("6 - Informacoes");
                Console.WriteLine("7 - Ims");
                Console.WriteLine("8 - sair");

                while (!int.TryParse(Console.ReadLine(), out num) || num <= 0 || num > 8)
                {
                    Console.WriteLine("Insira apenas números inteiros");
                    Console.Write("Escolha o exercicio de 1 a 7: ");
                }

                if(num == 1)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Exercicio1 - ");
                    Console.WriteLine("-----------------------------");
                    Media media = new Media();
                    media.calculaMedia();
                }
                else if(num == 2)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Exercicio2 - ");
                    Console.WriteLine("-----------------------------");
                    Vetor vet = new Vetor();
                    vet.percorreVetor();
                }
                else if(num == 3)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Exercicio3 - ");
                    Console.WriteLine("-----------------------------");
                    Matriz mat = new Matriz();
                    mat.matrix();
                }
                else if(num == 4)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Exercicio4 - ");
                    Console.WriteLine("-----------------------------");
                    MaiorIdade x = new MaiorIdade();
                    x.maiorIdade();
                }
                else if(num == 5)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Exercicio5 - ");
                    Console.WriteLine("-----------------------------");
                    TrocaLetra troca = new TrocaLetra();
                    troca.trocaDeLetra();
                }
                else if(num == 6)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Exercicio6 - ");
                    Console.WriteLine("-----------------------------");
                    Informacoes inf = new Informacoes();
                    inf.dados();
                }
                else if(num == 7)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Exercicio7 - ");
                    Console.WriteLine("-----------------------------");
                    Ims ims = new Ims();
                    ims.consultaIms();
                }
                else
                {
                    y = false;
                }
            }
        }
    }
}