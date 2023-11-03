List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 
// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

Eruption chileFirst = eruptions.FirstOrDefault(e => e.Location == "Chile");
Console.WriteLine(chileFirst);


Eruption hawaiiFirst = eruptions.FirstOrDefault(e => e.Location == "Hawaiian Is");
Console.WriteLine(hawaiiFirst);


Eruption greenlandFirst = eruptions.FirstOrDefault(e => e.Location == "Greenland");
if (greenlandFirst != null) 
{
Console.WriteLine(greenlandFirst);
}
else 
{
Console.WriteLine("No Greenland Eruption found.");
}


Eruption nzAfter1900 = eruptions.FirstOrDefault(e => e.Location == "New Zealand" || e.Year > 1900);
Console.WriteLine(nzAfter1900);


IEnumerable<Eruption> elevationOver2000 = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(elevationOver2000, "Eruptions with elevation over 2000");


IEnumerable<Eruption> startsWithL = eruptions.Where(e => (char)e.Volcano[0] == 'L');
Console.WriteLine(startsWithL.Count());
PrintEach(startsWithL);


int highestElevation = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine(highestElevation);


IEnumerable<string> volcanoNames = eruptions.OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
foreach (string name in volcanoNames)
{
    Console.WriteLine(name);
}


int elevationSum = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine(elevationSum);


bool year200Eruption = eruptions.Any(e => e.Year == 2000);
Console.WriteLine(year200Eruption);


IEnumerable<Eruption> stratoVolcanoes = eruptions.Where(e => e.Type == "Stratovolcano").Take(3);
PrintEach(stratoVolcanoes, "Stratovolcanoes");


IEnumerable<Eruption> alphabeticalBefore1000 = eruptions.OrderBy(e => e.Volcano).Where(e => e.Year < 1000);
PrintEach(alphabeticalBefore1000, "Eruptions before 1000 CE (alphabetical)");


IEnumerable<string> alphabeticalNamesBefore1000 = eruptions.OrderBy(e => e.Volcano).Where(e => e.Year < 1000).Select(e => e.Volcano);
foreach (string volcano in alphabeticalNamesBefore1000)
{
    Console.WriteLine(volcano);
}