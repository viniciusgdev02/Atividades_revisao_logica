using System;
 
namespace atividades
{
    public class Atividade10
    {
        public static void MenuOperacoes()
        {
            int opcao;
            do
            {
                Console.WriteLine("Menu de Operações");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma operação (1-5): ");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao >= 1 && opcao <= 4)
                {
                    Console.Write("Digite o primeiro número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine($"Resultado da soma: {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine($"Resultado da subtração: {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine($"Resultado da multiplicação: {num1 * num2}");
                            break;
                        case 4:
                            if (num2 != 0)
                                Console.WriteLine($"Resultado da divisão: {num1 / num2}");
                            else
                                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                            break;
                    }
                }
                else if (opcao != 5)
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }

            } while (opcao != 5);

            Console.WriteLine("Programa encerrado.");
        }
    }
}

