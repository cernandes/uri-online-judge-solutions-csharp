using System;
using System.Globalization;
namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = horas * valuePerHour;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
