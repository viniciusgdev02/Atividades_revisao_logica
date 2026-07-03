using System;

namespace atividades
{
    public class Atividade8
    {
        public static void CalculadoraPotencia()
        {
            Console.WriteLine("Calculadora de Potência Sem Operador Nativo");
            Console.Write("Digite a base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            int expoente = Convert.ToInt32(Console.ReadLine());

            double resultado = CalcularPotencia(baseNum, expoente);
            Console.WriteLine($"{baseNum} elevado a {expoente} é igual a {resultado}");
        }

        private static double CalcularPotencia(double baseNum, int expoente)
        {
            if (expoente == 0)
                return 1;

            double resultado = 1;
            for (int i = 0; i < Math.Abs(expoente); i++)
            {
                resultado *= baseNum;
            }

            return expoente < 0 ? 1 / resultado : resultado;
        }
    }
}