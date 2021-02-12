using System;
using System.Globalization;

namespace Uri1156
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1.0;
            double cont = 2;
            for (int i = 3; i <= 39; i += 2)
            {
                s += i / cont;
                cont = cont * 2;
            }
            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
