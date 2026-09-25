using System.Runtime.CompilerServices;

Character mainCharacter = new Character();
mainCharacter.Backpack.Items = starterInventory();

mainCharacter.ReName();

mainCharacter.Backpack.Display();
Console.ReadLine();


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