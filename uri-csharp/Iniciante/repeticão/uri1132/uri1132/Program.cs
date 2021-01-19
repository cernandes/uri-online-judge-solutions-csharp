using System;

namespace uri1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma, min, max;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
            soma = 0;
            for (int i = min; i <= max; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
