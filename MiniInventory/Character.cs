public class Character
{
    int Hp = 100;
    string Name = "Egil";
    public Inventory Backpack = new Inventory();

    public void ReName()
    {
        Console.WriteLine("What do you wish to name your character?");
        Name = Console.ReadLine();
        if(Name == null)
            Name = "Egil";
    }
    public void Heal(int ammount)
    {
        Hp += ammount;
    }
}
