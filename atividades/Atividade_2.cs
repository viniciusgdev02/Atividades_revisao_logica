using System;

namespace atividades
{
    public class Atividade2
    {
        public static void CalculadoraMedia()
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A média é: {media:F2}");

            if (media >= 7)
            {
                Console.WriteLine("O aluno está aprovado.");
            }
            else
            {
                Console.WriteLine("O aluno está reprovado.");
            }
        }
    }
}