using System.Runtime.CompilerServices;

Character mainCharacter = new Character();
mainCharacter.Backpack.Items = starterInventory();

mainCharacter.ReName();

while(true)
{
    Console.WriteLine("What action do you wish to take?");
    Console.WriteLine(@"
1. Proceed forward
2. Check inventory");
int choiceInt = Choice(1, 2);


if(choiceInt == 1)
{
    Item foundItem = GetRadomItemFromLootPool();
    Console.WriteLine($"You found {foundItem.Name} on the ground!");
    Console.WriteLine("Do you wish to pick it up?");
    Console.WriteLine("1. Yes 2. No");
    choiceInt = Choice(1, 2);
    if(choiceInt == 1) mainCharacter.Backpack.Items.Add(foundItem);
}
if(choiceInt == 2)
{
    mainCharacter.Backpack.Display();
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
}
Console.Clear();
}











static List<Item> starterInventory()
{
    Weapon defaultWeapon = new Weapon();
    defaultWeapon.Name = "Wooden Stick";
    defaultWeapon.setDamage(1, 3);

    Consumable smallHeal = new Consumable();
    smallHeal.setStats("smallHeal", 3, 10);


    List<Item> items = [defaultWeapon, smallHeal];

    return items;
}

static void CheckItemType(List<Item> items, int slot)
{
    foreach(Item item in items)
    {
        if (item is Weapon)
        {
            //((Weapon)item)
        }
    }
}
static Item GetRadomItemFromLootPool()
{
    
    Weapon ironWeapon = new();
    ironWeapon.Name = "IronBattleAxe";
    ironWeapon.setDamage(3, 6);
    Weapon diamondWeapon = new();
    diamondWeapon.Name = "DiamondSword";

    Armour ironArmour = new();
    ironArmour.Name = "IronArmour";
    ironArmour.setProtection(1);
    Armour diamondArmour = new();
    diamondArmour.Name = "DiamondArmour";
    diamondArmour.setProtection(5);

    
    List<Item> items = [ironWeapon, diamondWeapon, ironArmour, diamondArmour];
    return items[Random.Shared.Next(items.Count)];
}

static int Choice(int min, int max)
{
    int choiceInt;
    string choice = Console.ReadLine();
    while(!int.TryParse(choice, out choiceInt) || choiceInt > max || choiceInt < min) 
    {
    Console.WriteLine("Invalid choice, try again"); 
    choice = Console.ReadLine();
    }
    return choiceInt;
}