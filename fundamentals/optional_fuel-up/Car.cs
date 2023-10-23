public class Car : Vehicle, INeedFuel
{
    public string FuelType {get;set;}
    public int FuelTotal {get;set;}
    public Car(string name, int passengers, string color, string fuelType) :
    base(name, passengers, color, true)
    {
        FuelType = fuelType;
        FuelTotal = 10;
    }

    public void GiveFuel(int amount)
    {
        FuelTotal += amount;
    }
}