using System.Linq.Expressions;

void Window()
{


    Console.WriteLine("""
            _.-;;-._
      '-..-'|   ||   |
      '-..-'|_.-;;-._|
      '-..-'|   ||   |
      '-..-'|_.-''-._|
""");
    Console.ReadLine();
}
void TypeWriter()
{
string[] word = ["H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d"];
    int a = 11;
    for (int i = a; i < a; i++)
    {
        Console.Write(word[i]);
        Thread.Sleep(200);
    }
}
static void Star()
{
    Console.SetCursorPosition(Random.Shared.Next(120), Random.Shared.Next(29));
    Console.WriteLine("*");
}

static void Stars(int a)
{
    for (int i = a; i > 0; i--)
    {
        Star();
    }
}
bool gotNumber = false;
int numberYay;
Console.WriteLine("give number");
while (gotNumber == false)
{

    string numberMabye = Console.ReadLine();
    bool isNumber = int.TryParse(numberMabye, out numberYay);
    if (numberYay < -1 && isNumber == true)
    {
        
     gotNumber = true;
    }
    
}

//Window();
TypeWriter();
Console.ReadLine();
Stars(3232);
Console.ReadLine();
