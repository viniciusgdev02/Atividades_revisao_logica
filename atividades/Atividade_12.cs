using System;

namespace atividades
{
    public class Atividade12
    {
        public static void AreaTriangulo()
        {
            Console.WriteLine("Cálculo da Área de um Triângulo");

            double baseTriangulo = 10.5;
            double altura = 5.2;

            double area = Math.Round((baseTriangulo * altura) / 2);

            Console.WriteLine($"Base: {baseTriangulo}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"A área do triângulo é: {area}");
        }
    }
}
