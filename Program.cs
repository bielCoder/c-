using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        List<string> vehicles = new List<string> { "Carro", "Avião", "Barco" };
        List<string> moreVehicles = new List<string> { "Bicicleta", "Moto" };

        vehicles.AddRange(moreVehicles);

        vehicles.Insert(1, "Patins");
        vehicles.Sort();

        // ------ EXEMPLO DE CopyTo ------
        // Criando um array com o mesmo tamanho da lista
        string[] vehiclesArray = new string[8];

        // Copiando os elementos da lista para o array
        vehicles.CopyTo(vehiclesArray,1);

        Console.WriteLine("===== LISTA ORDENADA =====");
        foreach (string vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }

        Console.WriteLine("\n===== ARRAY COPIADO (CopyTo) =====");
        foreach (string v in vehiclesArray)
        {
            Console.WriteLine(v);
        }
        Console.WriteLine("\n===== BUSCA POR ELEMENTO =====");
        Console.WriteLine("Search for 'vehicle'");
        string? find = vehicles.Find(x => x == "Barco");
        Console.WriteLine("Found: " + find);
        Console.WriteLine("\n===== BUSCA POR POSICIONAMENTO ELEMENTO =====");
        Console.WriteLine("index of 'vehicle'");
        int pos = vehicles.IndexOf("Barco");
        Console.WriteLine("Found at position: " + pos);
    }
}
