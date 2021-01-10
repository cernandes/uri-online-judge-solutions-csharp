using System;

namespace uri1074
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = null;
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
            int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    valor = "NULL";
                }
                else if (x % 2 == 0)
                {
                    if (x > 0)
                    {
                        valor = "EVEN POSITIVE";
                    }
                    else
                    {
                        valor = "EVEN NEGATIVE";
                    }
                }
                else
                {
                    if (x > 0)
                    {
                        valor = "ODD POSITIVE";
                    }
                    else
                    {
                        valor = "ODD NEGATIVE";
                    }
                }
                Console.WriteLine(valor);
            }
        }
    }
}
