using System;

namespace Uri1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int cont = 0;
                int x = int.Parse(Console.ReadLine());
                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont > 2)
                {
                    Console.WriteLine(x + " nao eh primo");
                }
                else
                {
                    Console.WriteLine(x + " eh primo");
                }
               
                n--;
            }
        }
    }
}
