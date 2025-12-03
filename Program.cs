using System;

namespace Aula29
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] vehicles = new string["Carro", "Moto", "Caminhão"];
            Queue<string> vehicle = new Queue<string>();
            vehicle.Enqueue("Carro");
            vehicle.Enqueue("Moto");
            vehicle.Enqueue("Caminhão");
            vehicle.Enqueue("Bicicleta");

            while (vehicle.Count() > 0)
            {
             
                    Console.WriteLine("Removendo veículo: " + vehicle.Dequeue());
                    
              

            }
           
            Console.WriteLine("Qtd de veículos: " + vehicle.Count());
            if(vehicle.Count() != 0)
            {
                Console.WriteLine("Primeiro veículo: " + vehicle.Peek());
            }
            Console.WriteLine("Há o veículo Moto: " + (vehicle.Contains("Moto") == true ? "Sim" : "Não"));

            foreach (var item in vehicle)
            {
                Console.WriteLine("Vehicle:" + item);
              
            }
        }
    }
}