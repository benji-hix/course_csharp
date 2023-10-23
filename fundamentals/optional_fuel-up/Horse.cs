public class Horse : Vehicle, INeedFuel
{
    public string FuelType {get;set;}
    public int FuelTotal {get;set;}
    public Horse(string name, int passengers, string color, string fuelType) :
    base(name, passengers, color, false) 
    {
        FuelType = fuelType;
        FuelTotal = 10;
    }
        public void GiveFuel(int amount)
    {
        FuelTotal += amount;
    }
}