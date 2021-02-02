using System;

namespace uri1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int quadrado = (int)Math.Pow(i, 2);
                int cubo = (int)Math.Pow(i, 3);
                Console.WriteLine(i + " " + quadrado + " " + cubo);
                Console.WriteLine(i + " " + (quadrado + 1) + " " + (cubo + 1));
            }
        }
    }
}
