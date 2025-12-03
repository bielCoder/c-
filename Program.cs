using System;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula sobre tratamento de exceções
            try
            {
                Console.WriteLine("Digite um número inteiro:");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Você digitou o número: {numero}");
                if(true)
                {
                    throw new Exception("Erro genérico lançado propositalmente.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Formato inválido. Por favor, digite um número inteiro.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Obrigado por usar o programa. (Idependentemente de erros ou sucessos, esta mensagem sempre será exibida. )");
            }
        }
    }
}