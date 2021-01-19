using System;
using System.Globalization;

namespace uri1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double notaValida = 0;
            int n;

            while (true)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");

                }
                else
                {
                    if (notaValida == 0)
                    {
                        notaValida = nota;
                    }
                    else
                    {
                        double media = (notaValida + nota) / 2;
                        Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        while (true)
                        {
                            n = int.Parse(Console.ReadLine());
                            if (n != 1 && n != 2)
                            {
                                Console.WriteLine("novo calculo (1-sim 2-nao)");
                            }
                            else break;
                        }
                        if (n == 1)
                        {
                            notaValida = 0;
                        }
                        else if (n == 2) break;
                    }
                }
            }
        }
    }
}