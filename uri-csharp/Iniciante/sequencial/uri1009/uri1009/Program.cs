using System;
using System.Globalization;
namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valueSalesAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalSalary = baseSalary + (valueSalesAmount * 0.15);

            Console.WriteLine("TOTAL = R$ " + totalSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
