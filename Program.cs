using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Dictionary<int, string> vehicles = new Dictionary<int, string>();
        
        vehicles.Add(1, "Car");
        vehicles.Add(2, "Motorcycle");
        vehicles.Add(3, "Truck");
        vehicles.Add(4, "Bicycle");
        vehicles.Add(5, "Bus");

        if(vehicles.ContainsKey(3))
        {
            vehicles.Remove(3);
            Console.WriteLine($"The dictionary contains the key 3.({vehicles[3]})");
        }
        else
        {
            Console.WriteLine("The dictionary does not contain the key 3.");
        }

        foreach (KeyValuePair<int, string> vehicle in vehicles)
        {

            Console.WriteLine($" Vehicle {vehicle.Key}: {vehicle.Value}");
        }
    }
}