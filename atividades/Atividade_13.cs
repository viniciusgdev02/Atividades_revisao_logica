using System;

namespace atividades
{
    public class Atividade13
    {
        public static void CalculadoraHipotenusa()
        {
            Console.WriteLine("Cálculo da Hipotenusa de um Triângulo Retângulo");

            double cateto1 = 3.0;
            double cateto2 = 4.0;

            double hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            Console.WriteLine($"Cateto 1: {cateto1}");
            Console.WriteLine($"Cateto 2: {cateto2}");
            Console.WriteLine($"A hipotenusa é: {hipotenusa}");
        }
    }
}
