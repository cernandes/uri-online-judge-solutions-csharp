using System;
using System.Globalization;

namespace Uri1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1.0; Console.WriteLine(s);
            for (int i = 2; i <= 100; i++)
            {
                s += (double)1 / i;
                Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
