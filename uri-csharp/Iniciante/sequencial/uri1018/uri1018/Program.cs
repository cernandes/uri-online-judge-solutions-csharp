using System;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int nota = 0;

            Console.WriteLine(valor);
            nota = Math.Abs(valor / 100);
            Console.WriteLine(nota + " nota(s) de R$ 100,00");
            valor = valor % 100;

            nota = Math.Abs(valor / 50);
            Console.WriteLine(nota + " nota(s) de R$ 50,00");
            valor = valor % 50;

            nota = Math.Abs(valor / 20);
            Console.WriteLine(nota + " nota(s) de R$ 20,00");
            valor = valor % 20;

            nota = Math.Abs(valor / 10);
            Console.WriteLine(nota + " nota(s) de R$ 10,00");
            valor = valor % 10;

            nota = Math.Abs(valor / 5);
            Console.WriteLine(nota + " nota(s) de R$ 5,00");
            valor = valor % 5;

            nota = Math.Abs(valor / 2);
            Console.WriteLine(nota + " nota(s) de R$ 2,00");
            valor = valor % 2;

            nota = valor;
            Console.WriteLine(nota + " nota(s) de R$ 1,00");
        }
    }
}
