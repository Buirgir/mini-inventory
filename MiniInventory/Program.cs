using System.Runtime.CompilerServices;

Character mainCharacter = new Character();
mainCharacter.Backpack.Items = starterInventory();

mainCharacter.ReName();




static List<Item> starterInventory()
{
    Weapon defaultWeapon = new Weapon();
    defaultWeapon.Name = "Wooden Stick";
    defaultWeapon.setDamage(1, 3);

    Consumable smallheal = new Consumable();
    smallheal.setStats("smallheal", 3, 10);


    List<Item> items = [defaultWeapon, smallheal];
    return items;
}