using System;

namespace uri1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int jInicio = 7;
            int jFim = 5;

            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = jInicio; j >= jFim; j--)
                {
                    Console.WriteLine("I=" + i + " " + "J=" + j);
                }
                jInicio += 2;
                jFim += 2;
            }
        }
    }
}
