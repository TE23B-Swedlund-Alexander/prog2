
int hp1 = 100;
int hp2 = 100;
int dmg1;
int dmg2;
Console.WriteLine("what is your name?");
string name1 = Console.ReadLine();
string name2 = "bAlex";

while (hp1 > 0 && hp2 > 0)
{

    Console.WriteLine($"{name1} hp:{hp1}");
    Console.WriteLine($"{name2} hp:{hp2}");
    dmg1 = Random.Shared.Next(10, 25);
    dmg2 = Random.Shared.Next(10, 25);
    hp2 -= dmg1
    hp1 -= dmg2
    Console.WriteLine($"{name1} did {dmg1} damage");
    Console.WriteLine($"{name2} did {dmg2} damage");
    Console.ReadLine();
    Console.WriteLine("mega victreebel is Awesome");
    Console.ReadLine();
}
if (hp1 > 0 && hp2 < 1)
{
    Console.WriteLine("you win");

}
else if (hp1 < 1 && hp2 > 0)
{
    Console.WriteLine("you lose");
}
else
{
    Console.WriteLine("fly");
}
    Console.ReadLine();
