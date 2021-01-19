using System;

namespace uri1115
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
                if (a == 0 || b == 0)
                {
                    break;
                }
                else
                {
                    if (a > 0 && b > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else if (a > 0 && b < 0)
                    {
                        Console.WriteLine("quarto");
                    }
                    else if (a < 0 && b < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                    else if (a < 0 && b > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                }
            }
        }
    }
}
