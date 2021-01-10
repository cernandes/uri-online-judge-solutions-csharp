using System;
using System.Globalization;

namespace uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, area, perimetro;
            string[] valores = Console.ReadLine().Split();
            a = float.Parse(valores[0], CultureInfo.InvariantCulture);
            b = float.Parse(valores[1], CultureInfo.InvariantCulture);
            c = float.Parse(valores[2], CultureInfo.InvariantCulture);

            if (a + b > c && a + c > b && b + c > a)
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = (a + b) * c / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
