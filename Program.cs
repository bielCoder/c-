using System;

public interface Veiculo
{
    bool On();
    bool Off();

    void info()
    {
        Console.WriteLine("Informações do veículo.");
    }
}

class VeiculoBase : Veiculo
{
    protected bool powerStatus;

    public VeiculoBase()
    {
        powerStatus = false;
    }

    public bool On()
    {
        powerStatus = true;
        Console.WriteLine("Veículo ligado.");
        return powerStatus;
    }

    public bool Off()
    {
        powerStatus = false;
        Console.WriteLine("Veículo desligado.");
        return powerStatus;
    }
}

class Program
{
    static void Main()
    {
        Veiculo meuVeiculo = new VeiculoBase();
        meuVeiculo.On();  
        meuVeiculo.Off();
    }
}
