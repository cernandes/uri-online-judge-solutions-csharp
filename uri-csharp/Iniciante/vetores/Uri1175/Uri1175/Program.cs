using System;

namespace Uri1175
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[20];

            for (int i = 0; i < vet.Length; i++)
            {
                vet[19-i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < vet.Length; j++)
            {
                Console.WriteLine("N[" + j + "] = " + vet[j]);
            }
        }
    }
}
