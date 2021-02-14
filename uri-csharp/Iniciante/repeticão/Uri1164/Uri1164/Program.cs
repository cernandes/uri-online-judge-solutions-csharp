using System;

namespace Uri1164
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            while (x > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int cont = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        cont += i;
                    }
                }
                if (cont == n)
                {
                    Console.WriteLine(n + " eh perfeito");
                }
                else
                {
                    Console.WriteLine(n + " nao eh perfeito");
                }
                x--;
            }
        }
    }
}
