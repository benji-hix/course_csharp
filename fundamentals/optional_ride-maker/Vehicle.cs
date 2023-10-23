class Vehicle {
    string Name;
    int Passengers;
    string Color;
    public string _Color {
        get {return Color;}
    }
    bool Engine;
    int Miles;

    public Vehicle(string name, int passengers, string color, bool engine){
        Name = name;
        Passengers = passengers;
        Color = color;
        Engine = engine;
        Miles = 0;
    }

    public Vehicle(string name, string color) {
        Name = name;
        Color = color;
        Passengers = 1;
        Engine = true;
        Miles = 0;
    }

    public void ShowInfo() {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Passenger Count: {Passengers}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Engine: {Engine}");
        Console.WriteLine($"Distance traveled: {Miles}");
    }

    public void Travel(int distance) {
        Miles += distance;
        Console.WriteLine($"Distance traveled: {Miles}");
    }
}