using System;

namespace uri1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int valor = 0;
            int position = 0;

            while (count < 100)
            {
                int input = int.Parse(Console.ReadLine());

                if (input > valor)
                {
                    valor = input;
                    position = count + 1;
                }

                count++;
            }

            Console.WriteLine(valor);
            Console.WriteLine(position);
        }
    }
}
