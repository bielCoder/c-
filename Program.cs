using System;

interface IVehicle
{
    void DisplayInfo();
    String GetMake();
    String GetModel();  
    int GetYear();
    void SetMake(string make);
    void SetModel(string model);
    void SetYear(int year);
}

class Car(string make, string model, int year) : IVehicle
{
    protected string Make { get; set; } = make;
    protected string Model { get; set; } = model;
    protected int Year { get; set; } = year;

    public String GetMake()
    {
        return this.Make;
    }

    public String GetModel()
    {
        return this.Model;
    }

    public int GetYear()
    {
        return this.Year;
    }

    public void SetMake(string make)
    {
        this.Make = make;
    }

    public void SetModel(string model)
    {
        this.Model = model;
    }

    public void SetYear(int year)
    {
        this.Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {this.GetMake()}, Model: {this.GetModel()}, Year: {this.GetYear()}");
        Console.WriteLine("----------------------------------------------");
    }
}

class Program
{
    static void Main()
    {

        IVehicle[] vehicles = new IVehicle[3];
        vehicles[0] = new Car("Toyota", "Corolla", 2020);
        vehicles[1] = new Car("Honda", "Civic", 2019);        
        vehicles[2] = new Car("Ford", "Mustang", 2021);
        for (int i = 0; i < vehicles.Length; i++)
        {
            vehicles[i].DisplayInfo();
        }
    }
}
