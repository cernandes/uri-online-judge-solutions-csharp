using System;

namespace Uri1173
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] vet = new int[10];
            int cont = x;
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = cont;
                cont *= 2;
            }
            for (int j = 0; j < vet.Length; j++)
            {
                Console.WriteLine("N[" + j + "] = " + vet[j]);
            }
        }
    }
}
