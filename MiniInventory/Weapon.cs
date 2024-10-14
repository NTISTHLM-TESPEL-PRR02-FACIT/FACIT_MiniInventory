public class Weapon : Item
{
  public int MinDamage = 10;
  public int MaxDamage = 20;

  public int Attack()
  {
    return Random.Shared.Next(MinDamage, MaxDamage);
  }
}
