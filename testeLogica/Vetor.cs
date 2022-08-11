using System;

namespace testeLogica
{
    internal class Vetor
    {
        int[] vet = new int[15];
        int temp = 0;


        public void percorreVetor()
        {
            for(int i = 0; i < vet.Length; i++)
            {
                Console.Write("Numero " + (i+1) + ":");
                while (!int.TryParse(Console.ReadLine(), out vet[i]))
                {
                    Console.WriteLine("Insira apenas números inteiros");
                    Console.Write("Numero " + (i + 1) + ":");
                }
            }

            for (int i = 1; i < vet.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vet[i] > vet[j])
                    {
                        temp = vet[i];
                        vet[i] = vet[j];
                        vet[j] = temp;
                    }
                }
            }
            Console.WriteLine("--------------------------------------------------------");

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Numero " + (i + 1) + ":" + vet[i]);
            }    
        }
    }
}
