using System;

namespace uri1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, menor, maior;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                menor = X;
                maior = Y;
            }
            else
            {
                menor = Y;
                maior = X;
            }

            int soma = 0;
            for (int i = menor + 1; i < maior; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
