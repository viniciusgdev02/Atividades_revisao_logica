using System;

namespace atividades
{
    public class Atividade5
    {
        public static void CalculadoraFatorial()
        {
            Console.Write("Digite um número inteiro não negativo para calcular o fatorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Número inválido. Por favor, digite um número inteiro não negativo.");
                return;
            }

            long fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
    }
}