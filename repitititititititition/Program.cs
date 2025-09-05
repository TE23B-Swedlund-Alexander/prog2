
string pokemon = "w";
string YesNo = "w";
string move1 = "tackle";
string move2 = "tackle";
int hp1 = 100;
int hp2 = 100;
int dmg1;
int dmg2;
Console.WriteLine("Hello there! Welcome to the world of POKErMON! My name is OAK! People call me the POKErMON PROF! Discussion This world is inhabited by creatures called POKEMON!");
Console.ReadLine();
Console.WriteLine(" For some people, POKErMON are pets. Others use them for fights. Myself... I study POKErMON as a profession.");
Console.ReadLine();
Console.WriteLine("first, what is your name?");
string name1 = Console.ReadLine();
Console.WriteLine($"Right! so your name is {name1}");
Console.ReadLine();
Console.WriteLine("This is my grandson. He's been your rival since you were a baby.");
Console.ReadLine();
Console.WriteLine("...Erm, what is his name again?");
string name2 = Console.ReadLine();
Console.WriteLine($"That's right! I remember now! His name is {name2}!");
Console.ReadLine();
Console.WriteLine($"{name1}! Your very own POKErMON legend is about to unfold! A world of dreams and adventures with POKEMON awaits! Let's go!");
Console.ReadLine();
Console.WriteLine("Gramps! I'm fed up with waiting!");
Console.ReadLine();
Console.WriteLine($"{name2}? Let me think... Oh, that's right, I told you to come! Just wait!");
Console.ReadLine();
Console.WriteLine($"Here, {name1}! There are 3 POKErMON here! Haha! They are inside the POKEr BALLS. When I was young, I was a serious POKEMON trainer. In my old age, I have only 3 left, but you can have one! Choose!");
Console.ReadLine();
Console.WriteLine("Hey! Gramps! What about me?");
Console.ReadLine();
Console.WriteLine($"Be patient! {name2}, you can have one too!");
Console.ReadLine();
Console.WriteLine($"Now, {name1}, which POKErMON do you want?");
Console.ReadLine();
Console.WriteLine("Heh, I don't need to be greedy like you! Go ahead and choose, RED!");
Console.ReadLine();

while (pokemon != "bulbasaur" || pokemon != "charmander" || pokemon != "squirtle")
{
    Console.WriteLine("choose charmander, bulbasaur or squirtle");
    pokemon = Console.ReadLine();
    if (pokemon == "bulbasaur" || pokemon == "charmander" || pokemon == "squirtle")
    {

        while (YesNo != "yes" || YesNo != "no")
        {
            Console.WriteLine($"are you shure you want to choose {pokemon} yes/no");
            YesNo = Console.ReadLine();
            if (YesNo == "no") pokemon = "w";
        }


    }

}
if (pokemon == "bulbasaur") move1 = "tackle"; move2 = "scratch";
if(pokemon == "squirtle")move1 = "tackle"; move2 = "tackle";
if(pokemon == "charmander")move1 = "scratch"; move2 = "tackle";
Console.WriteLine("I'll take this one, then!");
Console.ReadLine();
Console.WriteLine("My POKErMON looks a lot stronger.");
Console.ReadLine();
Console.WriteLine($"Wait {name1}! Let's check out our POKErMON! Come on, I'll take you on!");
Console.ReadLine();
Console.WriteLine($"Rival {name2} would like to battle");

while (hp1 > 0 && hp2 > 0)
{

    Console.WriteLine($"{name1} hp:{hp1}");
    Console.WriteLine($"{name2} hp:{hp2}");
    dmg1 = Random.Shared.Next(10, 25);
    dmg2 = Random.Shared.Next(10, 25);
    hp2 -= dmg1;
    hp1 -= dmg2;
    Console.WriteLine($"{name1}s {pokemon} used move1");
    Console.WriteLine($"{name2}s {pokemon} used move2");
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
    Console.WriteLine("tie");
}
    Console.ReadLine();
