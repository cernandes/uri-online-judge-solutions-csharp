using System;

namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(valores[0]);
            int minutoInicio = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);

            int instanteInicial = horaInicio * 60 + minutoInicio;
            int instanteFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoEmHoras = duracao / 60;
            int duracaoEmMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoEmHoras + " HORA(S) E " + duracaoEmMinutos + " MINUTO(S)");
        }
    }
}