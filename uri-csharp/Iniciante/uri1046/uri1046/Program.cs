using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, duracao;
            string[] intervalos = Console.ReadLine().Split();
            inicio = int.Parse(intervalos[0]);
            fim = int.Parse(intervalos[1]);

            if (inicio >= fim)
            {
                duracao = (24 - inicio) + fim;
            }
            else
            {
                duracao = fim - inicio;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
