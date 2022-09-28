Fighter FighterZero = new Fighter();
Fighter FighterOne = new Fighter();

FighterZero.name = "FighterZero";
FighterZero.weapon = new Weapon();
FighterZero.weapon.name = "Void Sword";

FighterOne.name = "FighterOne";
FighterOne.weapon = new Weapon();
FighterOne.weapon.name = "Light Blade";

int r = 0;

Console.WriteLine($"{FighterZero.name} vs {FighterOne.name}");
while (FighterZero.hp > 0 && FighterOne.hp > 0) {
    Console.WriteLine("\nRound " + r);
    Console.WriteLine($"{FighterZero.name}: {FighterZero.hp} hp\n{FighterOne.name}: {FighterOne.hp} hp\n");
    r++;

    FighterZero.Attack(FighterOne);
    FighterOne.Attack(FighterZero);
}
Console.WriteLine("\nFight: Over\n");
if (FighterZero.hp == 0 && FighterOne.hp == 0) {
    Console.WriteLine("It's a draw!");
}
else if (FighterZero.hp == 0) {
    Console.WriteLine($"FighterOne won with {FighterOne.hp} hp left"); 
}
else {
    Console.WriteLine($"FighterZero won with {FighterZero.hp} hp left"); 
}

Console.WriteLine("Press any key to quit");
Console.ReadKey();