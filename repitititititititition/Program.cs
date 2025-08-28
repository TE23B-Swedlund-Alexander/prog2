
int hp1 = 100;
int hp2 = 100;

string name1 = "sAlex";
string name2 = "bAlex";

while (hp1 > 0 && hp2 > 0)
{

    Console.WriteLine($"{name1} hp:{hp1}");
    Console.WriteLine($"{name2} hp:{hp2}");
    hp2 -= Random.Shared.Next(10, 25);
    hp1 -= Random.Shared.Next(10, 25);
    Console.ReadLine();
Console.WriteLine("mega victreebel is Awesome");
}
Console.ReadLine();