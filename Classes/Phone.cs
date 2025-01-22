namespace cs_console_phone.Classes;

public class Phone
{
    public long number { get; set; }
    public string model { get; set; }
    public double weight { get; set; }

    public Phone(int number, string model, double weight) : this(number, model)
    {
        this.weight = weight;
    }

    public Phone(int number, string model)
    {
        this.number = number;
        this.model = model;
    }

    public Phone()
    {
        this.number = 88005553555;
        this.model = "PotatoPhone";
    }

    public void receiveCall(string name)
    {
        Console.WriteLine($"Звонит {name}");
    }

    public void receiveCall(string name, long number)
    {
        Console.WriteLine($"Звонит {name} по номеру {number}");
    }

    public void sendMessage(params long[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }

    public long getNumber()
    {
        return number;
    }
}