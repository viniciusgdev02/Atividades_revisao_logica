using System;

namespace atividades
{
    public class Atividade6
    {
        public static void SequenciaFibonacci()
        {
            Console.Write("Digite a quantidade de termos da sequência de Fibonacci: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            int primeiroTermo = 0;
            int segundoTermo = 1;

            Console.WriteLine("Sequência de Fibonacci:");

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(primeiroTermo + " ");

                int proximoTermo = primeiroTermo + segundoTermo;
                primeiroTermo = segundoTermo;
                segundoTermo = proximoTermo;
            }
        }
    }
}