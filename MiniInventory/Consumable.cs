public class Consumable : Item
{
  public int UsesMax = 3;
  public int UsesCurrent = 3;

  public void Use(Character target)
  {
    if (UsesCurrent > 0)
    {
      target.Hp += 10;
      UsesCurrent--;
    }
  }
}
