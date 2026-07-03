using System;
using System.Threading;

namespace atividades
{
    public class Atividade7{
        public static void SistemaLogin()
        {
            string usuarioCorreto = "admin";
            string senhaCorreta = "1234";
            
            Console.Write("Digite o nome de usuário: ");
            string usuario = Console.ReadLine();

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            Console.WriteLine("Validando credenciais...");

            Thread.Sleep(2000); // Simula um atraso na validação

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                Console.WriteLine("Login bem-sucedido!");
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretos.");
            }
        }
        }
        }
