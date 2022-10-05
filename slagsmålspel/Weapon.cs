public class Weapon
{
    public string name;
    Random rnd;

    public Weapon() {
        rnd = new Random();
    }

    public int GetDamage() {
        return rnd.Next(5, 21);
    }
}
