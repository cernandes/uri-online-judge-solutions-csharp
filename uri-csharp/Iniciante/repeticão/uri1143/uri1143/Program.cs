using System;

namespace uri1143
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
            }
        }
    }
}
