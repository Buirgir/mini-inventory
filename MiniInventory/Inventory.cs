using System.Runtime.CompilerServices;

public class Inventory
{
    public List<Item> Items;

    public void Display()
    {
        for (int i = 0; i < Items.Count; i++)
        {
            Console.WriteLine(@$"{i}.{Items[i].Name}");
        }
    }
}