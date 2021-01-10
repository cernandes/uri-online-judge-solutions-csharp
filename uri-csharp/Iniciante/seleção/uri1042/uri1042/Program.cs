using System;

namespace uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, menor, medio, maior;

            string[] vet = Console.ReadLine().Split(' ');
            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);
            n3 = int.Parse(vet[2]);


            if (n1 < n2 && n1 < n3)
            {
                menor = n1;
                if (n2 < n3)
                {
                    medio = n2;
                    maior = n3;
                }
                else
                {
                    medio = n3;
                    maior = n2;
                }
            }
            else if (n2 < n3)
            {
                menor = n2;
                if (n1 < n3)
                {
                    medio = n1;
                    maior = n3;
                }
                else
                {
                    medio = n3;
                    maior = n1;
                }
            }
            else
            {
                menor = n3;
                if (n1 < n2)
                {
                    medio = n1;
                    maior = n2;
                }
                else
                {
                    medio = n2;
                    maior = n1;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);
            Console.WriteLine();

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}
