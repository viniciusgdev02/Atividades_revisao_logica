using System;

namespace atividades
{
    public class Atividade16
    {
        public static void NumeroAleatorio()
        {
            Console.WriteLine("Gerador de Número Aleatório entre 1 e 100");

            // Em C# não existe Math.random() como no Java, então uso a classe Random
            // para gerar um número double entre 0.0 e 1.0, seguindo a mesma lógica.
            Random random = new Random();
            double valorAleatorio = random.NextDouble(); // valor entre 0.0 e 1.0

            int numeroSorteado = (int)(valorAleatorio * 100) + 1;

            Console.WriteLine($"O número aleatório gerado é: {numeroSorteado}");
        }
    }
}
