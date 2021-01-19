using System;

namespace uri1113
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] vet = Console.ReadLine().Split();
                int a = int.Parse(vet[0]);
                int b = int.Parse(vet[1]);
                if (a == b)
                {
                    break;
                }
                else if (a > b)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
            }
        }
    }
}
