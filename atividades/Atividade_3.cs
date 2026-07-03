using System;

namespace atividades
{
    public class Atividade3
    {
        public static void Tabuada()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tabuada do {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
    }