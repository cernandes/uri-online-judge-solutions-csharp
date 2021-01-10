using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int years, months;

            years = days / 365;            
            days -= years * 365;
            months = days / 30;
            days -= months * 30;

            Console.WriteLine(years + " ano(s)");
            Console.WriteLine(months + " mes(es)");
            Console.WriteLine(days + " dia(s)");
        }
    }
}
