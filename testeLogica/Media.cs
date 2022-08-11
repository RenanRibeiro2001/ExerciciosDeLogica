using System;

namespace testeLogica
{
    internal class Media
    {
        private double notaA, notaB, notaC, rec, media;
        private bool x = false;
        private bool y = false;

        public void calculaMedia()
        {
            while (!x)
            {
                Console.Write("Digite a NotaA: ");
                while (!double.TryParse(Console.ReadLine(), out notaA) || notaA > 10 || notaA < 0)
                {
                    Console.WriteLine("Nota A invalida");
                    Console.Write("Digite a NotaA: ");
                }
                Console.Write("Digite a NotaB: ");
                while (!double.TryParse(Console.ReadLine(), out notaB) || notaB > 10 || notaB < 0)
                {
                    Console.WriteLine("Nota B invalida");
                    Console.Write("Digite a NotaB: ");
                }
                Console.Write("Digite a NotaC: ");
                while (!double.TryParse(Console.ReadLine(), out notaC) || notaC > 10 || notaC < 0)
                {
                    Console.WriteLine("INota C invalida");
                    Console.Write("Digite a NotaC: ");
                }

                media = (notaA + notaB + notaC) / 3.0;

                if (media >= 6)
                {
                    Console.WriteLine("Aprovado com media: " + media);
                    x = true;
                }
                else
                {
                    while (!y)
                    {
                        Console.WriteLine("Ficou de recupercao");
                        Console.Write("digite a nota da recuperacao: ");
                        while (!double.TryParse(Console.ReadLine(), out rec))
                        {
                            Console.WriteLine("Insira apenas números inteiros");
                            Console.Write("Digite a nota da recuperacao: ");
                        }

                        if (rec < 0 || rec > 10)
                        {
                            Console.WriteLine("Nota invalida!!");
                        }
                        else
                        {
                            if (rec >= 6)
                            {
                                Console.WriteLine("Aprovado com media: " + rec);
                                x = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("voce reprovou de ano!");
                                x = true;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
