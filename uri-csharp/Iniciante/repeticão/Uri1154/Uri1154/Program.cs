using System;
using System.Globalization;

namespace Uri1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int soma = 0;
            int qtde = 0;
            while (n > 0)
            {
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    soma += n;
                    qtde++;
                }
            }
            double media = (double)soma / qtde;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
