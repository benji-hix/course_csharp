public class Drink
{
    public string Name;
    public double Temperature;
    public bool IsCarbonated;
    
    // We need a basic constructor that takes all these features in
    public Drink(string name, double temp, bool isCarb)
    {
    	Name = name;
    	Temperature = temp;
    	IsCarbonated = isCarb;
    }
    public virtual void ShowInfo() 
    {
        Console.WriteLine();
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Temp: {Temperature}");
        Console.WriteLine($"Carbonated: {IsCarbonated}");
    }
}

public class Coffee : Drink
{
    public string Roast;
    public string Milk;

    public Coffee(string name, double temp, bool isCarb, string roast, string milk) : 
    base(name, temp, isCarb)
    {
        Roast = roast;
        Milk = milk;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Roast: {Roast}");
        Console.WriteLine($"Milk Type: {Milk}");
    }
}

public class Cocktail : Drink
{
    public string Color;
    public bool Strong;

    public Cocktail(string name, double temp, bool isCarb, string color, bool strong) :
    base(name, temp, isCarb)
    {
        Color = color;
        Strong = strong;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Strong: {Strong}");
    }
}

public class Soda : Drink
{
    public int Calories;

    public Soda(string name, double temp, int calories) :
    base(name, temp, true)
    {
        Calories = calories;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Calories: {Calories}");
    }
}