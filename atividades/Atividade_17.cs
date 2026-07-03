using System;

namespace atividades
{
    public class Atividade17
    {
        public static void DiferencaAbsoluta()
        {
            Console.WriteLine("Cálculo do Valor Absoluto da Diferença entre Dois Números");

            int numero1 = 10;
            int numero2 = 5;

            int diferenca = numero1 - numero2;
            int valorAbsoluto = Math.Abs(diferenca);

            Console.WriteLine($"Número 1: {numero1}");
            Console.WriteLine($"Número 2: {numero2}");
            Console.WriteLine($"O valor absoluto da diferença é: {valorAbsoluto}");
        }
    }
}
