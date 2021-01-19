using System;
using System.Globalization;

namespace uri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            double notaValida = 0;

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
                        break;
                    }
                }
            }
        }
    }
}