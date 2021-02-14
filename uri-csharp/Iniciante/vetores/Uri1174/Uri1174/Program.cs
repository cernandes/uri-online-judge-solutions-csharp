using System;
using System.Globalization;
namespace Uri1174
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = new string[10];
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = Console.ReadLine();
            }
            for (int j = 0; j < vet.Length; j++)
            {
                double x = double.Parse(vet[j], CultureInfo.InvariantCulture);
                if (x <= 10)
                {
                    Console.WriteLine("A[" + j + "] = " + x.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
