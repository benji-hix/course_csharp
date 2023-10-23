Vehicle kiaSoul = new Vehicle("kiaSoul", 5, "cream", true);
Vehicle minivan = new Vehicle("minivan", 5, "blue", true);
Vehicle tesla = new Vehicle("tesla", "white");
Vehicle truck = new Vehicle("truck", "black");

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(kiaSoul);
vehicles.Add(minivan);
vehicles.Add(tesla);
vehicles.Add(truck);

truck.Travel(100);

foreach (Vehicle entry in vehicles) {
    entry.ShowInfo();
}