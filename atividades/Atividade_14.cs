using System;

namespace atividades
{
    public class Atividade14
    {
        public static void VolumeEsfera()
        {
            Console.WriteLine("Cálculo do Volume de uma Esfera");

            double raio = 5.0;

            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);

            Console.WriteLine($"Raio: {raio}");
            Console.WriteLine($"O volume da esfera é: {volume:F2}");
        }
    }
}
