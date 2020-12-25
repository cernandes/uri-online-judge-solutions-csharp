using System;
using System.Globalization;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int code, qtde;
            double preco = 0;

            string[] vet = Console.ReadLine().Split(' ');

            code = int.Parse(vet[0]);
            qtde = int.Parse(vet[1]);

            switch (code)
            {
                case 1:
                    preco = 4.00;
                    break;
                case 2:
                    preco = 4.50;
                    break;
                case 3:
                    preco = 5.00;
                    break;
                case 4:
                    preco = 2.00;
                    break;
                case 5:
                    preco = 1.50;
                    break;
            }
            double total = qtde * preco;
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
