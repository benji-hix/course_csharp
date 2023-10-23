Coffee catpuccino = new Coffee("Catpuccino", 137, false, "Medium", "Oat");
Cocktail gimlet = new Cocktail("Gimlet", 45, false, "Cloudy Green", false);
Soda peachCoke = new Soda("Peach Coke", 45, 260);

List<Drink> allDrinks = new List<Drink>();
allDrinks.Add(catpuccino);
allDrinks.Add(gimlet);
allDrinks.Add(peachCoke);

foreach (Drink entry in allDrinks)
{
    entry.ShowInfo();
}