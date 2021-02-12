using System;
using System.Globalization;

namespace uri1098
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal k;
            decimal j = 1;
            decimal n = 0;

            while (n <= (decimal)2.0)
            {
                for (k = 1; k <= 3; k++)
                {
                    if (n.ToString("F1", CultureInfo.InvariantCulture).Contains(".0"))
                    {
                        Console.WriteLine("I=" + (int)n + " J=" + (int)j);
                    }

                    else
                    {
                        Console.WriteLine("I=" + n.ToString("F1", CultureInfo.InvariantCulture) + " J=" + j.ToString("F1", CultureInfo.InvariantCulture));
                    }
                    j++;
                }
                n += (decimal)0.2;
                j -= 3;
                j += (decimal)0.2;
            }
        }
    }
}