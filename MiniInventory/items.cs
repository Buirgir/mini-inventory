public abstract class Item
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

public class Armour : Item
{
    private float Protection;

    public void setProtection(int P)
    {
        Protection = P;
    }
}

public class Consumable : Item
{
    int UsesMax;
    int UsesCurrent;
    int healAmmount;

    public void setStats(string chosenName, int chosenUses, int chosenHealAmmount)
    {
        Name = chosenName;
        UsesMax = chosenUses;
        healAmmount = chosenHealAmmount;
    }

    public void Use(Character target)
    {
        target.Heal(10);
        UsesCurrent += 1;
    }
}