using System;
using System.Globalization;

namespace Uri1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int PA = int.Parse(vet[0]);
                int PB = int.Parse(vet[1]);
                double G1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                double G2 = double.Parse(vet[3], CultureInfo.InvariantCulture);
                int cont = 0;
                while (PA <= PB)
                {
                    PA += (int)(PA * G1 / 100);
                    PB += (int)(PB * G2 / 100);

                    cont++;
                }
                if (cont > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine(cont + " anos.");
                }
                n--;
            }
        }
    }
}
