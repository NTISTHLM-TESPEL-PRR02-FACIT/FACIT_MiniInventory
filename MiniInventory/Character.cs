public class Character
{
  public int Hp;
  public string Name;
  public Inventory Backpack;

  public Character()
  {
    Backpack = new();
    
    Weapon w = new () { Name = "Axe", Weight = 10f };
    Consumable p = new() { Name = "Health potion", Weight = 2f };

    Backpack.Items.Add(w);
    Backpack.Items.Add(p);

    Hp = 100;
    Name = "";
  }
}
