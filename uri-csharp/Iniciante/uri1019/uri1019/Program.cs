using System;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());

            int hour = time / 3600;
            int minute = (time % 3600) / 60;
            int second = time % 60;

            Console.WriteLine(hour + ":" + minute + ":" + second);
        }
    }
}
