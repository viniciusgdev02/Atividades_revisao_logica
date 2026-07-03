using System;

namespace atividades
{
    public class Atividade9
    {
        public static void ValidadorPrimo()
        {
            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine($"{numero} não é um número primo.");
                return;
            }

            bool isPrimo = true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    isPrimo = false;
                    break;
                }
            }

            if (isPrimo)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        }
    }
}