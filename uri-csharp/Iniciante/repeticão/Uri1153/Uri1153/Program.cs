using System;

namespace Uri1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fatorial = n;
            for (int i = n - 1; i > 0; i--)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
