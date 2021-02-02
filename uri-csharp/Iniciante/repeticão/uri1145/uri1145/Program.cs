using System;

namespace uri1145
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split();

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            int soma = 1;

            for (int i = 1; i <= y / x; i++)
            {
                for (int j = soma; j < soma + x; j++)
                {
                    if (j == soma + x - 1)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
                soma += x;
            }
        }
    }
}
