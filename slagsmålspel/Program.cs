// UPPGIFT :)

Fighter Player = new Fighter();
Fighter Enemy = new Fighter();

Random rnd = new Random();

var list = new List<string>{"Bob", "Steve", "Jeff"};

Player.name = "Player";
Player.weapon = new Weapon();
Player.weapon.name = "Void Sword";

Enemy.name = list[rnd.Next(3)];
Enemy.weapon = new Weapon();
Enemy.weapon.name = "Light Blade";

int r = 0;

Console.WriteLine($"{Player.name} vs {Enemy.name}");
Console.WriteLine("Press any button to start");
Console.ReadKey();
while (Player.hp > 0 && Enemy.hp > 0) {
    Console.WriteLine("\nRound " + r);
    Console.WriteLine($"{Player.name}: {Player.hp} hp\n{Enemy.name}: {Enemy.hp} hp\n");
    r++;

    Console.WriteLine("What would you like to do?\n(Type appropiate number and press Enter)\n");
    Console.WriteLine("(1) Attack\n(2) Heal");
    string? choice = Console.ReadLine();
    Console.Clear();
    if (choice == "1") {
        Console.WriteLine("You chose to attack");
        Player.Attack(Enemy);
    }
    else if (choice == "2") {
        Console.WriteLine("You chose to heal yourself");
        Player.Heal();
    }
    else {
        Console.WriteLine("You chose to do nothing\nThe AI play for you");
        int AIchoice = rnd.Next(2);
        if (AIchoice == 0) {
            Player.Attack(Enemy);
        }
        else if (AIchoice == 1) {

            Player.Heal();
        }
    }
    Enemy.Attack(Player);
}
Console.WriteLine("\nFight: Over\n");
if (Player.hp == 0 && Enemy.hp == 0) {
    Console.WriteLine("It's a draw!");
}
else if (Player.hp == 0) {
    Console.WriteLine($"Enemy won with {Enemy.hp} hp left"); 
}
else {
    Console.WriteLine($"Player won with {Player.hp} hp left"); 
}

Console.WriteLine("Press any key to quit");
Console.ReadKey();