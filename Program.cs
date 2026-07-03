using System;
using atividades;

class Program
{
    static void Main(string[] args)
    {
       Console.Clear();

Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
Console.WriteLine("║              ATIVIDADES DE PROGRAMAÇÃO EM C#                ║");
Console.WriteLine("╠═════════════════════════════════════════════════════════════╣");
Console.WriteLine("║  1  - Verificador de Número Positivo, Negativo ou Zero      ║");
Console.WriteLine("║  2  - Calculadora de Média com Aprovação                    ║");
Console.WriteLine("║  3  - Tabuada com Laço de Repetição                         ║");
Console.WriteLine("║  4  - Contador de Números Pares e Ímpares                   ║");
Console.WriteLine("║  5  - Calculadora de Fatorial com Validação                 ║");
Console.WriteLine("║  6  - Sequência de Fibonacci                                ║");
Console.WriteLine("║  7  - Sistema de Login com Tentativas                       ║");
Console.WriteLine("║  8  - Calculadora de Potência Sem Operador Nativo           ║");
Console.WriteLine("║  9  - Validador de Número Primo                             ║");
Console.WriteLine("║ 10  - Menu de Operações com Laço Repetitivo                 ║");
Console.WriteLine("║ 11  - Conversor de Temperatura Completo                     ║");
Console.WriteLine("║ 12  - Área de um Triângulo                                  ║");
Console.WriteLine("║ 13  - Hipotenusa de um Triângulo Retângulo                  ║");
Console.WriteLine("║ 14  - Volume de uma Esfera                                  ║");
Console.WriteLine("║ 15  - Distância entre Dois Pontos                           ║");
Console.WriteLine("║ 16  - Número Aleatório entre 1 e 100                        ║");
Console.WriteLine("║ 17  - Valor Absoluto da Diferença entre Dois Números        ║");
Console.WriteLine("╠═════════════════════════════════════════════════════════════╣");
Console.Write(" Digite a opção desejada: ");

        Console.Write("Escolha uma atividade (1-17): ");
        int escolha = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (escolha)
        {
            case 1:
                Atividade1.VerificadorNumero();
                break;
            case 2:
                Atividade2.CalculadoraMedia();
                break;
            case 3:
                Atividade3.Tabuada();
                break;
            case 4:
                Atividade4.ContadorParesImpares();
                break;
            case 5:
                Atividade5.CalculadoraFatorial();
                break;
            case 6:
                Atividade6.SequenciaFibonacci();
                break;
            case 7:
                Atividade7.SistemaLogin();
                break;
            case 8:
                Atividade8.CalculadoraPotencia();
                break;
            case 9:
                Atividade9.ValidadorPrimo();
                break;
            case 10:
                Atividade10.MenuOperacoes();
                break;
            case 11:
                Atividade11.ConversorTemperatura();
                break;
            case 12:
                Atividade12.AreaTriangulo();
                break;
            case 13:
                Atividade13.CalculadoraHipotenusa();
                break;
            case 14:
                Atividade14.VolumeEsfera();
                break;
            case 15:
                Atividade15.DistanciaEntrePontos();
                break;
            case 16:
                Atividade16.NumeroAleatorio();
                break;
            case 17:
                Atividade17.DiferencaAbsoluta();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

    }
}
