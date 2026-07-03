using System;

namespace atividades
{
    public class Atividade4
    {
        public static void ContadorParesImpares()
        {
            Console.WriteLine("Contador de Números Pares e Ímpares");
            Console.Write("Digite a quantidade de números que deseja verificar: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            int contadorPares = 0;
            int contadorImpares = 0;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {contadorPares}");
            Console.WriteLine($"Quantidade de números ímpares: {contadorImpares}");
        }
    }
}