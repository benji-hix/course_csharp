class Enemy {
    string Name;
    int Health;
    public int _Health {
        get {return Health;}
    }
    List<Attack> AttackList;

    public Enemy(string name, int health = 100) {
        Name = name;
        Health = health;
        AttackList = new List<Attack>();
    }

    public void RandomAttack() {
        Random rand = new Random();
        Attack attack = AttackList[rand.Next(0, AttackList.Count)];
        Console.WriteLine($"{Name} performs {attack._Name}. It deals {attack._DamageAmount} damage.");
    }

    public void addAttack(Attack attack) {
        AttackList.Add(attack);
    }
}