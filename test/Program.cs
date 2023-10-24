List<string> ListFood = new List<string>() 
{"Apple Pie", "Pizza", "Cinnamon Rolls", 
"Lasagna", "Donuts", "Chocolate Cake", "Burritos"};

foreach (string entry in ListFood)
{
    if ((char)entry[0] == 'C')
    {
        Console.WriteLine("match");
    }
}