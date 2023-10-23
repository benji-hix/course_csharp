Car tesla = new Car("Tesla", 5, "White", "Gasoline");
Horse chariot = new Horse("Chariot", 1, "Gold", "Hay");
Bicycle streetBike = new Bicycle("Street Bike", "Black");

List<Vehicle> ListVehicle = new List<Vehicle>();
List<INeedFuel> ListNeedFuel = new List<INeedFuel>();

ListVehicle.Add(tesla);
ListVehicle.Add(chariot);
ListVehicle.Add(streetBike);

foreach (Vehicle Entry in ListVehicle) 
{
    if (Entry is INeedFuel) 
    {
        ListNeedFuel.Add((INeedFuel)Entry);
    }
}

foreach (INeedFuel Entry in ListNeedFuel)
{
    Entry.GiveFuel(10);
}


foreach (Vehicle Entry in ListVehicle) 
{
    Console.WriteLine($"Name: {Entry.Name}");
    if (Entry is INeedFuel) 
    {
        INeedFuel FormattedEntry = (INeedFuel)Entry;
        Console.WriteLine($"Fuel: {FormattedEntry.FuelTotal}");
    }
}