using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TempuratureChangeEventArgs : EventArgs
{
    public int OldTemperature { get; set; }
    public int CurrentTemperature { get; set; }
    public int DiffTemp { get; set; }

    public TempuratureChangeEventArgs(int oldTemperature, int currentTemperature)
    {
        this.OldTemperature = oldTemperature;
        this.CurrentTemperature = currentTemperature;
        this.DiffTemp = oldTemperature - currentTemperature;
    }
}

public class Thermostas
{
    // definition of delegate abstract
    //public delegate void EventHandler <TeventArgs> (object sender, TeventArgs e);
    public event EventHandler<TempuratureChangeEventArgs> TemperatureChanged;

    public int oldtemperature;
    public int currenttemperature;
    public void SetTemperature(int NewTemperature)
    {
        if (currenttemperature != NewTemperature)
        {
            oldtemperature = currenttemperature;
            currenttemperature = NewTemperature;
            OnTemperatureChange(oldtemperature, currenttemperature);
        }
    }

    protected void OnTemperatureChange(int oldtemperature, int currenttemperature)
    {
        OnTemperatureChange(new TempuratureChangeEventArgs(oldtemperature, currenttemperature));
    }

    protected void OnTemperatureChange(TempuratureChangeEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
}

public class Display
{
    public void Subscribe(Thermostas thermostas)
    {
        thermostas.TemperatureChanged += HandleTemperatureChanged;
    }

    protected void HandleTemperatureChanged(object sender, TempuratureChangeEventArgs e)
    {
        Console.WriteLine("Temperature change:");
        Console.WriteLine($"Old Temperature :{e.OldTemperature}");
        Console.WriteLine($"Current Temperature :{e.CurrentTemperature}");
        Console.WriteLine($"Temperature change:{e.DiffTemp}");
    }
}


public class Program
{
    static void Main(string[] args)
    {
        Thermostas thermostas = new Thermostas();
        Display display = new Display();
        display.Subscribe(thermostas);

        thermostas.SetTemperature(20);

        Console.ReadKey();

    }
}

