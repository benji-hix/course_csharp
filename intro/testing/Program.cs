static string rollUntil(int target) {
    int count = 0;
    Random rand = new Random();

    while (true) {
        count ++;
        if (rand.Next(1, 7) == target) {
            return $"Rolled a {target} after {count} tries";
        }
    }
}

Console.Write(rollUntil(6));