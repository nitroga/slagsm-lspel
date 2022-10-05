public class Fighter
{
    public string name;
    public int hp = 100;
    public Weapon weapon;
    Random rnd = new Random();

    public void Attack(Fighter target) {
        int dmg = weapon.GetDamage();
        target.hp -= dmg;
        target.hp = Math.Max(0, target.hp);
        Console.WriteLine($"{target.name} loses {dmg} hp");
    }

    public void Heal() {
        hp += rnd.Next(10, 16);
    }
}
