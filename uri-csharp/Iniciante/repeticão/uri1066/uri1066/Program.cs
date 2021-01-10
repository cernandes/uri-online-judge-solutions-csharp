using System;

namespace uri1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;

            for (int i = 0; i < 5; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    par++;
                }
                if (numero % 2 != 0)
                {
                    impar++;
                }
                if (numero > 0)
                {
                    positivo++;
                }
                if (numero < 0)
                {
                    negativo++;
                }
            }
            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");
        }
    }
}
