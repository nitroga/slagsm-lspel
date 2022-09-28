public class Fighter
{
    public string name;
    public int hp = 100;
    public Weapon weapon;

    public void Attack(Fighter target) {
        int dmg = weapon.GetDamage();
        target.hp -= dmg;
        target.hp = Math.Max(0, target.hp);
        Console.WriteLine($"{target.name} loses {dmg} hp");
    }
}
