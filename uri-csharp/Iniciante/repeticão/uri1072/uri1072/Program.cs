using System;

namespace uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int somaIn = 0;
            int somaOut = 0;

            for (int i = 0; i < N; i++)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 10 && numero <= 20)
                {
                    somaIn += 1;
                }
                else
                {
                    somaOut += 1;
                }
            }
            Console.WriteLine(somaIn + " in");
            Console.WriteLine(somaOut + " out");
        }
    }
}
