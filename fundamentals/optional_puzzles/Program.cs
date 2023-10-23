/* -------------------------------------------------------------------------- */
/*                                  coin flip                                 */
/* -------------------------------------------------------------------------- */
static bool coinFlip() {
    Random rand = new Random();
    int coin = rand.Next(1, 3);
    if (coin == 1) return true;
    else return false;
}

Console.Write(coinFlip());

/* -------------------------------------------------------------------------- */
/*                                  dice roll                                 */
/* -------------------------------------------------------------------------- */
static int diceRoll() {
    Random rand = new Random();
    return rand.Next(1, 7);
}

Console.Write(diceRoll());

/* -------------------------------------------------------------------------- */
/*                                  stat roll                                 */
/* -------------------------------------------------------------------------- */
static List<int> statRoll(int rollTimes) {
    List<int> output = new List<int>();
    Random rand = new Random();
    int max = 0;

    for (int i = 1; i <= rollTimes; i++) {
        int temp = rand.Next(1, 7);
        output.Add(temp);
        if (temp > max) {
            max = temp;
        }
    }

    Console.WriteLine($"Highest roll: {max}");
    return output;
}

List<int> result = statRoll(4);

foreach (int entry in result) {
    Console.WriteLine(entry);
}

/* -------------------------------------------------------------------------- */
/*                                 roll until                                 */
/* -------------------------------------------------------------------------- */
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