using System;

namespace uri1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int grenal = 0;
            int gremio = 0;
            int inter = 0;
            int empate = 0;
            int x, interInput, gremioInput;
            while (true)
            {
                string[] partida = Console.ReadLine().Split();
                interInput = int.Parse(partida[0]);
                gremioInput = int.Parse(partida[1]);
                grenal++;
                if (interInput > gremioInput)
                {
                    inter++;
                }
                else if (interInput == gremioInput)
                {
                    empate++;
                }
                else gremio++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");

                x = int.Parse(Console.ReadLine());

                if (x == 2)
                {
                    Console.WriteLine(grenal + " grenais");
                    Console.WriteLine("Inter:" + inter);
                    Console.WriteLine("Gremio:" + gremio);
                    Console.WriteLine("Empates:" + empate);
                    if (inter == gremio)
                    {
                        Console.WriteLine("Nao houve vencedor");
                    }
                    else if (inter > gremio)
                    {
                        Console.WriteLine("Inter venceu mais");
                    }
                    else
                    {
                        Console.WriteLine("Gremio venceu mais");
                    }
                    break;
                }

                else if (x == 1)
                {
                    continue;
                }
            }
        }
    }
}