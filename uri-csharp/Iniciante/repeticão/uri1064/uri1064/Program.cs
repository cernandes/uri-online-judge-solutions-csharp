using System;
using System.Globalization;

namespace uri1064
{
    class Program
    {
        static void Main(string[] args)
        {
            float soma = 0;
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                float x = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (x > 0)
                {
                    count += 1;
                    soma += x;
                }
            }

            float media = soma / count;

            Console.WriteLine(count + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
