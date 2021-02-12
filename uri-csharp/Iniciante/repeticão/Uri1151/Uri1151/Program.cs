using System;

namespace Uri1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cont = 0;
            int a = 0;
            int b = 1;
            int soma = a + b;


            for (int i = 0; i < n; i++)
            {
                if (cont == n - 1)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.Write(a + " ");
                }
                a = b;
                b = soma;
                soma = a + b;
                cont++;
            }
        }
    }
}
