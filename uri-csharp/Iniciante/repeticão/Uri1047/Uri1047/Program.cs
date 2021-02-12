using System;

namespace Uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial = 0;
            int horaFinal = 0;
            int minutoInicial = 0;
            int minutoFinal = 0;
            int hora, minuto;

            String[] vet = Console.ReadLine().Split(" ");
            for (int i = 0; i < 4; i++)
            {
                horaInicial = int.Parse(vet[0]);
                minutoInicial = int.Parse(vet[1]);
                horaFinal = int.Parse(vet[2]);
                minutoFinal = int.Parse(vet[3]);
            }
            int duracao = horaFinal * 60 + minutoFinal - (horaInicial * 60 + minutoInicial);

            if (horaInicial == horaFinal && minutoInicial == minutoFinal)
            {
                hora = 24;
            }
            else
            {
                hora = duracao / 60;
            }
            minuto = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + minuto + " MINUTO(S)");

        }
    }
}
