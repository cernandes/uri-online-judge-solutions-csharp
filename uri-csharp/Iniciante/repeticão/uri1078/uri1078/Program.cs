﻿using System;

namespace uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int resultado = 0;
            for (int i = 1; i <= 10; i++)
            {
                resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }
        }
    }
}
