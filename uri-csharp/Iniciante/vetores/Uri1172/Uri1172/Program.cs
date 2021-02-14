using System;

namespace Uri1172
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            for (int i = 0; i < vet.Length; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x <= 0)
                {
                    x = 1;
                }
                vet[i] = x;
            }

            for (int j = 0; j < vet.Length; j++)
            {
                Console.WriteLine("X[" + j + "] = " + vet[j]);
            }
        }
    }
}
