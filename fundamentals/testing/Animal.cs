public class Animal
{
    public string Name;
    protected string Diet;
    public bool IsMammal;
    public Animal(string name, string diet, bool ismammal){
        Name = name;
        Diet = diet;
        IsMammal = ismammal;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Diet: {Diet}");
        Console.WriteLine($"Mammal: {IsMammal}");
    }
}

public class Cat : Animal
{
    public string FurType;

    public Cat(string ft, string diet) : base("Cat", diet, true)
    {
        FurType = ft;
    }
    
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Fur Type: {FurType}");
    }
}

