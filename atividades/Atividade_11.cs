using System;
namespace atividades
{
    public class Atividade11
    {
        public static void ConversorTemperatura()
        {
            Console.WriteLine("Conversor de Temperatura");
            Console.WriteLine("1. Celsius para Fahrenheit");
            Console.WriteLine("2. Fahrenheit para Celsius");
            Console.WriteLine("3. Celsius para Kelvin");
            Console.WriteLine("4. Kelvin para Celsius");
            Console.WriteLine("5. Fahrenheit para Kelvin");
            Console.WriteLine("6. Kelvin para Fahrenheit");
            Console.Write("Escolha uma opção (1-6): ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            double temperatura, resultado;

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a temperatura em Celsius: ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = (temperatura * 9 / 5) + 32;
                    Console.WriteLine($"{temperatura}°C é igual a {resultado}°F.");
                    break;
                case 2:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = (temperatura - 32) * 5 / 9;
                    Console.WriteLine($"{temperatura}°F é igual a {resultado}°C.");
                    break;
                case 3:
                    Console.Write("Digite a temperatura em Celsius: ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = temperatura + 273.15;
                    Console.WriteLine($"{temperatura}°C é igual a {resultado}K.");
                    break;
                case 4:
                    Console.Write("Digite a temperatura em Kelvin: ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = temperatura - 273.15;
                    Console.WriteLine($"{temperatura}K é igual a {resultado}°C.");
                    break;
                case 5:
                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = (temperatura - 32) * 5 / 9 + 273.15;
                    Console.WriteLine($"{temperatura}°F é igual a {resultado}K.");
                    break;
                case 6:
                    Console.Write("Digite a temperatura em Kelvin: ");
                    temperatura = Convert.ToDouble(Console.ReadLine());
                    resultado = (temperatura - 273.15) * 9 / 5 + 32;
                    Console.WriteLine($"{temperatura}K é igual a {resultado}°F.");
                    break;
            }
        }
    }
}