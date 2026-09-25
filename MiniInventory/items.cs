public class Item
{
    public string Name;
    public float Weight;
}

public class Weapon : Item
{
    int MinDamage;
    int MaxDamage;


    public int Attack()
    {
        return Random.Shared.Next(MinDamage, MaxDamage);
    }
    public void setDamage(int min, int max)
    {
        MinDamage = min;
        MaxDamage = max;
    }
}

public class Armor : Item
{
    float Protection;
}

public class Consumable : Item
{
    int UsesMax;
    int UsesCurrent;
    int healAmmount;
    string name;

    public void setStats(string chosenName, int chosenUses, int chosenHealAmmount)
    {
        name = chosenName;
        UsesMax = chosenUses;
        healAmmount = chosenHealAmmount;
    }

    public void Use(Character target)
    {
        target.Heal(10);
        UsesCurrent += 1;
    }
}