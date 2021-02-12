using System;

namespace Uri1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);
                int soma = 0;

                if (x % 2 == 0)
                {
                    x += 1;
                }
                for (int i = 0; i < y; i++)
                {
                    soma += x;
                    x += 2;
                }
                n--;
                Console.WriteLine(soma);
            }
        }
    }
}
