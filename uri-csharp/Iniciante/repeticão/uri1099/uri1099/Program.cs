using System;

namespace uri1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a, b;
            int max = 0;
            int min = 0;
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split();
                a = int.Parse(vet[0]);
                b = int.Parse(vet[1]);

                if (a > b)
                {
                    max = a;
                    min = b;
                }
                else
                {
                    max = b;
                    min = a;
                }
                int soma = 0;
                for (int j = min + 1; j < max; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}