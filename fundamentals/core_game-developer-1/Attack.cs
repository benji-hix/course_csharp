class Attack {
    string Name;
    public string _Name {
        get {return Name;}
    }
    int DamageAmount;
    public int _DamageAmount{
        get {return DamageAmount;}
    }

    public Attack(string name, int damageAmount) {
        Name = name;
        DamageAmount = damageAmount;
    }
}