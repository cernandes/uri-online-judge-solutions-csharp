using System;

namespace uri1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 2;
            int c = 3;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a + " " + b + " " + c + " PUM");
                a += 4;
                b += 4;
                c += 4;
            }
        }
    }
}
