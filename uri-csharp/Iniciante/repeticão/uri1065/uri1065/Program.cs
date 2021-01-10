using System;

namespace uri1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            for (int i = 0; i < 5; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    par += 1;
                }
            }
            Console.WriteLine(par + " valores pares");
        }
    }
}
