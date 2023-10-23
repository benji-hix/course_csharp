// Adding an interface looks just like adding inheritance
public class Bird : Animal, ILayEggs
{
    public bool CanFly;
    // Our EggsPerBatch from our interface
    public int EggsPerBatch {get;set;}
    public Bird(bool canfly, string diet, int epb) : base("Bird", diet, false)
    {
        CanFly = canfly;
        EggsPerBatch = epb;
    }
    // Filling out the LayEggs method from our interface
    public void LayEggs()
    {
        Console.WriteLine($"{Name} laid {EggsPerBatch} egg(s)!");
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Can Fly: {CanFly}");
    }
}

