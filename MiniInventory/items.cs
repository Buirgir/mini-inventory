public class Item
{
    public string Name;
    public float Weight;
}

public class Weapon : Item
{
    public int MinDamage;
    public int MaxDamage;

    public int Attack()
    {
        return Random.Shared.Next(MinDamage, MaxDamage);
    }
}

public class Armor : Item
{
    public float Protection;
}

public class Consumable : Item
{
    public int UsesMax;
    public int UsesCurrent;

    public  void Use(Character target)
    {
        target.Hp += 10;
        UsesCurrent -= 1;
    }
}