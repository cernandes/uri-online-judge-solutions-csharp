﻿using System;

namespace uri1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    int quadrado = (int)Math.Pow(i, 2);

                    Console.WriteLine(i + "^2 = " + quadrado);
                }
            }
        }
    }
}