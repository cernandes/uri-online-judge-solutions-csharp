using System;

namespace uri1114
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int senha = int.Parse(Console.ReadLine());
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}
