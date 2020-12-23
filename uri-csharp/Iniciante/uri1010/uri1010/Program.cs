using System;
using System.Globalization;
namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor1 = Console.ReadLine().Split(' ');

            int codP1 = int.Parse(vetor1[0]);
            int p1Amount = int.Parse(vetor1[1]);
            double priceP1 = double.Parse(vetor1[2], CultureInfo.InvariantCulture);

           string[] vetor2 = Console.ReadLine().Split(' ');

            int codP2 = int.Parse(vetor2[0]);
            int p2Amount = int.Parse(vetor2[1]);
            double priceP2 = double.Parse(vetor2[2], CultureInfo.InvariantCulture);

            double totalPrice = (double) p1Amount * priceP1 + p2Amount * priceP2;

            Console.WriteLine("VALOR A PAGAR: R$ " + totalPrice.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
