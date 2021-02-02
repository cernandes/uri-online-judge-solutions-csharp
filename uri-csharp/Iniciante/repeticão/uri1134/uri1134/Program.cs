using System;

namespace uri1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    alcool++;
                }
                else if (n == 2)
                {
                    gasolina++;
                }
                else if (n == 3)
                {
                    diesel++;
                }
                else if (n == 4)
                {
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine("Alcool: " + alcool);
                    Console.WriteLine("Gasolina: " + gasolina);
                    Console.WriteLine("Diesel: " + diesel);
                    break;
                }
            }
        }
    }
}
