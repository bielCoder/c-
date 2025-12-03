using System;

namespace Aula27
{
    class Program
    {
        static void Main(string[] args)
        {
           try {
            
                LinkedList<string> transport = new LinkedList<string>();
                transport.AddLast("Carro");
                transport.AddFirst("Avião");
                transport.AddAfter(transport.First!, "Bicicleta");
                transport.AddBefore(transport.Last!, "Barco");
                
                foreach (var item in transport)
                {
                    Console.WriteLine(item);
                }
            } catch (Exception ex) {
                Console.WriteLine($"Erro: {ex.Message}");   
        } finally {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Programa finalizado.");
           }
        }
    }
}