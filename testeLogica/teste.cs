using System;

namespace testeLogica
{
    internal class teste
    {
        public void Teste()
        {
            string texto = "renan@ribeiro@";
            string[] partes = texto.Substring(0).Split('@');
            partes[0] = partes[0];
            foreach (string parte in partes)
            {
                Console.WriteLine(parte);
            }
        }
    }
}