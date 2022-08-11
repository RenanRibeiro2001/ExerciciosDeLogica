using System;

namespace testeLogica
{
    internal class Matriz
    {
        private int[,] mat = new int[3, 3];
        private int[,] vet = new int[3, 3];
        private int[] vetv = new int[9];
        private int[] vetp = new int[10];
        private int aux = 0, aux1 = 0, num = 100, resultado;
        private int numEscolha;
        private int tentativas = 0;
        private int chances = 10;
        private bool achou = false;
        private bool x = false;
        private bool y = false;
        private bool z = false;
        private bool l = false;
        private bool m = false;
        private Random rand = new Random();

        public void matrix()
        {
            Console.WriteLine("Hora de jogar!!");

            while (achou == false)
            {
                if (chances > 0)
                {
                    //preenche matrix
                    if (!x)
                    {
                        for (int i = 0; mat.GetLength(0) > i; i++)
                        {
                            for (int j = 0; mat.GetLength(1) > j; j++)
                            {
                                mat[i, j] = rand.Next(1, 100);
                                x = true;
                            }
                        }
                    }

                    Console.WriteLine();
                    Console.Write("chances: " + (chances--));
                    Console.WriteLine();
                    //jogando
                    while (!y)
                    {
                        Console.Write("Digite um numero: ");
                        numEscolha = 0;
                        while (!int.TryParse(Console.ReadLine(), out numEscolha) || numEscolha > 100 || numEscolha <= 0)
                        {
                            Console.WriteLine("Informe um numero entre 0 a 100 e apenas um numero inteiro");
                            Console.Write("Digite um numero: ");
                        }

                        while (!l)
                        {
                            if (vetp[0] == numEscolha)
                            {
                                Console.WriteLine("Nao pode colocar numero repetido!!");
                                break;
                            }
                            else if (vetp[1] == numEscolha)
                            {
                                Console.WriteLine("Nao pode colocar numero repetido!!");
                                break;
                            }
                            else if (vetp[2] == numEscolha)
                            {
                                Console.WriteLine("Nao pode colocar numero repetido!!");
                                break;
                            }
                            else if (vetp[3] == numEscolha)
                            {
                                Console.WriteLine("Nao pode colocar numero repetido!!");
                                aux1 = 0;
                                break;
                            }
                            else if (vetp[4] == numEscolha)
                            {
                                Console.WriteLine("Nao pode colocar numero repetido!!");
                                break;
                            }
                            else if (vetp[5] == numEscolha)
                            {
                                Console.WriteLine("Nao pode colocar numero repetido!!");
                                break;
                            }
                            else if (vetp[6] == numEscolha)
                            {
                                Console.WriteLine("Nao pode colocar numero repetido!!");
                                break;
                            }
                            else if (vetp[7] == numEscolha)
                            {
                                Console.WriteLine("Nao pode colocar numero repetido!!");
                                break;
                            }
                            else if (vetp[8] == numEscolha)
                            {
                                Console.WriteLine("Nao pode colocar numero repetido!!");
                                break;
                            }
                            else if (vetp[9] == numEscolha)
                            {
                                Console.WriteLine("Nao pode colocar numero repetido!!");
                                break;
                            }
                            else
                            {
                                l = true;
                                y = true;
                                vetp[aux1] = numEscolha;
                                aux1++;
                                break;
                            }
                        }
                    }

                    //percorre a matriz e subtrai o numero dentro da matriz com o numero digitado
                    for (int i = 0; mat.GetLength(0) > i; i++)
                    {
                        for (int j = 0; mat.GetLength(1) > j; j++)
                        {
                            if (mat[i, j] == numEscolha)
                            {
                                Console.WriteLine("voce achou o numero: " + mat[i, j]);
                                Console.WriteLine("voce venceu!!");
                                achou = true;
                                break;
                            }
                            else if (numEscolha > mat[i, j])
                            {
                                resultado = 0;
                                resultado = numEscolha - mat[i, j];
                                vet[i, j] = resultado;
                            }
                            else if (numEscolha < mat[i, j])
                            {
                                resultado = 0;
                                resultado = mat[i, j] - numEscolha;
                                vet[i, j] = resultado;
                            }
                        }
                        if (achou)
                        {
                            break;
                        }
                    }

                    if (!achou)
                    {
                        //tranfere os dados da matriz pro vetor
                        for (int i = 0; i < vet.GetLength(0); i++)
                        {
                            for (int j = 0; j < vet.GetLength(1); j++)
                            {
                                vetv[aux] = vet[i, j];
                                aux++;
                            }
                        }

                        //acha o menor numero
                        for (int i = 0; i < 9; i++)
                        {
                            if (vetv[i] < num)
                            {
                                num = vetv[i];
                                z = true;
                            }
                        }

                        if (z = true)
                        {
                            Console.WriteLine("voce esta a " + num + " do numero mais proximo!!");
                            Console.WriteLine();
                            z = false;
                            y = false;
                            l = false;
                            aux = 0;
                            num = 100;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("voce nao tem mais chances!!");
                    Console.WriteLine("voce perdeu!!");
                    achou = true;
                }
            }
        }
    }
}