using System;

namespace uri1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = 0;

            while (z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }

            int soma = x;
            int contador = 2;
            for (int i = x; i < z; i++)
            {
                soma += i + 1;
                if (soma > z)
                {
                    Console.WriteLine(contador);
                    break;
                }
                else
                {
                    contador++;
                }
            }
        }
    }
}
