using System;

namespace atividades
{
    public class Atividade15
    {
        public static void DistanciaEntrePontos()
        {
            Console.WriteLine("Cálculo da Distância entre Dois Pontos");

            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = 4.0;
            double y2 = 6.0;

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Ponto 1: ({x1}, {y1})");
            Console.WriteLine($"Ponto 2: ({x2}, {y2})");
            Console.WriteLine($"A distância entre os pontos é: {distancia}");
        }
    }
}
