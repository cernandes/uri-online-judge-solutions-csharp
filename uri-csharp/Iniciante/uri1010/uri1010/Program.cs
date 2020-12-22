using System;
using System.Globalization;
namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codP1 = int.Parse(Console.ReadLine());
            int p1Amount = int.Parse(Console.ReadLine());
            double priceP1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int codP2 = int.Parse(Console.ReadLine());
            int p2Amount = int.Parse(Console.ReadLine());
            double priceP2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalPrice = p1Amount * priceP1 + p2Amount * priceP2;

            Console.WriteLine("VALOR A PAGAR: R$ " + totalPrice.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
