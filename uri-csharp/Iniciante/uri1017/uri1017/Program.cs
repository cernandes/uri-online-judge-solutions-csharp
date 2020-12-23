using System;
using System.Globalization;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int trip = int.Parse(Console.ReadLine());
            int averageSpeed = int.Parse(Console.ReadLine());

            double fuelToTrip = (double)averageSpeed / 12 * trip;

            Console.WriteLine(fuelToTrip.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}
