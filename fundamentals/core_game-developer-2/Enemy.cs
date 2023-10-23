public class Enemy {
    public string Name;
    int Health;
    
    public int _Health {
        get {return Health;}
        set {Health = value;}
    }
    protected List<Attack> AttackList;

    public Enemy(string name, int health = 100) {
        Name = name;
        Health = health;
        AttackList = new List<Attack>();
    }

    public void addAttack(Attack attack) {
        AttackList.Add(attack);
    }

    public virtual void RandomAttack(Enemy target) {
        Random rand = new Random();
        Attack attack = AttackList[rand.Next(0, AttackList.Count)];
        target._Health = target._Health - attack._DamageAmount;
        Console.WriteLine($"{Name} attacks {target.Name} with {attack._Name}, dealing {attack._DamageAmount} damage.");
        Console.WriteLine($"{target.Name}'s health is now {target._Health}!");
    }

    public virtual void PerformAttack(Enemy target, Attack chosenAttack) {
        target._Health = target._Health - chosenAttack._DamageAmount;
        Console.WriteLine($"{Name} attacks {target.Name} with {chosenAttack._Name}, dealing {chosenAttack._DamageAmount} damage.");
        Console.WriteLine($"{target.Name}'s health is now {target._Health}!");
    }
}

public class Melee : Enemy
{
    public Attack punch = new Attack("Punch", 20);
    public Attack kick = new Attack("Kick", 15);
    public Attack tackle = new Attack("Tackle", 25);

    public Melee(string name, int health = 120) :
    base(name, health)
    {
        AttackList.Add(punch);
        AttackList.Add(kick);
        AttackList.Add(tackle);
    }

    public void Rage(Enemy target)
    {
        Random rand = new Random();
        Attack attack = AttackList[rand.Next(0, AttackList.Count)];
        target._Health = target._Health - (attack._DamageAmount + 10);
        Console.WriteLine($"{Name} attacks {target.Name} with {attack._Name}, dealing {attack._DamageAmount + 10} damage.");
        Console.WriteLine($"{target.Name}'s health is now {target._Health}!");
    }
}

public class Ranged : Enemy
{
    public Attack shootArrow = new Attack("Shoot an Arrow", 20);
    public Attack throwKnife = new Attack("Throw a knife", 15);
    int Distance;

    public Ranged(string name, int health = 100, int distance = 5) :
    base(name, health)
    {
        Distance = distance;
        AttackList.Add(shootArrow);
        AttackList.Add(throwKnife);
    }

    public void Dash()
    {
        Distance = 20;
        Console.WriteLine("Distance is now 20");
    }

    public override void RandomAttack(Enemy target)
    {
        if (Distance <= 10) {
            Console.WriteLine($"Attack failed -- {Name} is too close!");
        }
        else {
            base.RandomAttack(target);
        }
    }
    public override void PerformAttack(Enemy target, Attack chosenAttack)
    {
        if (Distance <= 10) {
            Console.WriteLine($"Attack failed -- {Name} is too close!");
        }
        else {
            base.PerformAttack(target, chosenAttack);
        }
    }
}

public class Magic : Enemy
{
    public Attack fireball = new Attack("Fireball", 25);
    public Attack lightning = new Attack("Lightning Bolt", 20);
    public Attack staffStrike = new Attack("Staff Strike", 10);
    
    public Magic(string name, int health = 80) :
    base(name, health)
    {
        AttackList.Add(fireball);
        AttackList.Add(lightning);
        AttackList.Add(staffStrike);
    }

    public void Heal(Enemy target)
    {
        target._Health += 40;
        Console.WriteLine($"{Name} heals {target.Name} for 40 hp.");
        Console.WriteLine($"{target.Name}'s health is now {target._Health}.");
    }
}