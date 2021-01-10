using System;
using System.Globalization;

namespace uri1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, qtdeCobaias, cobaias, qtdeCoelhos, qtdeRatos, qtdeSapos;
            double percentualC, percentualR, percentualS;
            char tipo;
            N = int.Parse(Console.ReadLine());

            qtdeCobaias = 0;
            qtdeCoelhos = 0;
            qtdeRatos = 0;
            qtdeSapos = 0;

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                cobaias = int.Parse(vet[0]);
                tipo = char.Parse(vet[1].ToUpper());


                if (tipo == 'C')
                {
                    qtdeCoelhos += cobaias;
                }
                else if (tipo == 'R')
                {
                    qtdeRatos += cobaias;
                }
                else
                {
                    qtdeSapos += cobaias;
                }

                qtdeCobaias += cobaias;
            }

            percentualC = (double)qtdeCoelhos / qtdeCobaias * 100;
            percentualR = (double)qtdeRatos / qtdeCobaias * 100;
            percentualS = (double)qtdeSapos / qtdeCobaias * 100;

            Console.WriteLine("Total: " + qtdeCobaias + " cobaias");
            Console.WriteLine("Total de coelhos: " + qtdeCoelhos);
            Console.WriteLine("Total de ratos: " + qtdeRatos);
            Console.WriteLine("Total de sapos: " + qtdeSapos);
            Console.WriteLine("Percentual de coelhos: " + percentualC.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentualR.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentualS.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
