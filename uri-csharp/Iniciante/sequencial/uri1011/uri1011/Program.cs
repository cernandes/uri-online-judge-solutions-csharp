using System;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, menor, maior, soma;        
            while (true)
            {
                string[] vet = Console.ReadLine().Split();
                a = int.Parse(vet[0]);
                b = int.Parse(vet[1]);
                if (a <= 0 || b <= 0)
                {
                   break;
                }

                if (a > b)
                {
                    maior = a;
                    menor = b;
                }
                else
                {
                    maior = b;
                    menor = a;
                }
                soma = 0;
                for (int i = menor; i <= maior; i++)
                {

                    Console.Write(i + " ");
                    soma += i;

                }
                Console.WriteLine("Sum=" + soma);
            }
        }
    }
}
