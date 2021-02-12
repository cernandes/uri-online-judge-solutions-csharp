using System;

namespace Uri1146
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero == 0)
                {
                    break;
                }
                else
                {
                    for (int i = 1; i <= numero; i++)
                    {
                        if (i == numero)
                        {
                            Console.Write(i);
                        }
                        else
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
