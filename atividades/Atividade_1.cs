using System;

namespace atividades
{
    public class Atividade1
    {
        public static void VerificadorNumero()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }
    }
}