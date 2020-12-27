using System;

namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            //float valor = float.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < 6; i++)
            {
              float  valor = float.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine(count + " valores positivos");
        }
    }
}
