using System;
using System.Globalization;

namespace uri1021
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota, valor,quociente,moeda;
          
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valor = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = valor / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            valor = valor % (nota * 100);

            nota = 50;
            quociente = valor / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            valor = valor % (nota * 100);

            nota = 20;
            quociente = valor / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            valor = valor % (nota * 100);

            nota = 10;
            quociente = valor / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            valor = valor % (nota * 100);

            nota = 5;
            quociente = valor / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            valor = valor % (nota * 100);

            nota = 2;
            quociente = valor / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            valor = valor % (nota * 100);

            Console.WriteLine("MOEDAS:");

            moeda = 100;
            quociente = valor / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + "1.00");
            valor = valor % moeda;

            moeda = 50;
            quociente = valor / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + "0.50");
            valor = valor % moeda;

            moeda = 25;
            quociente = valor / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + "0.25");
            valor = valor % moeda;

            moeda = 10;
            quociente = valor / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + "0.10");
            valor = valor % moeda;

            moeda = 5;
            quociente = valor / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + "0.05");
            valor = valor % moeda;

            moeda = 1;
            quociente = valor / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ " + "0.01");
            valor = valor % moeda;
        }
    }
}
