using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testeLogica
{
    internal class TrocaLetra
    {
        int num;
        private string frase;
        private bool x = true;
        private bool y = true;

        public void trocaDeLetra()
        {
            while (x)
            {
                while (y)
                {
                    Console.Write("Digite uma frase: ");
                    frase = Console.ReadLine();

                    if (!Regex.IsMatch(frase, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Só podem existir caracteres na string");
                    }
                    else
                    {
                        y = false;
                        break;
                    }
                }

                Console.WriteLine(Alterar(frase));

                Console.WriteLine("Tentar de novo??");
                Console.WriteLine("1 - sim / 2 - nao");

                while (!int.TryParse(Console.ReadLine(), out num) || num <= 0 || num > 2)
                {
                    Console.WriteLine("1 - sim / 2 - nao");
                }

                if (num == 1)
                {
                    x = true;
                    y = true;
                }
                else if (num == 2)
                {
                    x = false;
                }
            }
            
        }

        private string Alterar(string frase)
        {
            if (frase.Trim().Length > 0)
            {
                int tamanoFrase = frase.Length;
                int num = 0;

                var StringBuilder = new StringBuilder(frase);

                while (num < tamanoFrase)
                {
                    if (StringBuilder[num] == 'a' || StringBuilder[num] == 'A')
                    {
                        StringBuilder[num] = '&';
                    }
                    num++;
                }

                frase = StringBuilder.ToString();

                return frase;
            }
            else
            {
                return null;
            }

        }
    }
}
