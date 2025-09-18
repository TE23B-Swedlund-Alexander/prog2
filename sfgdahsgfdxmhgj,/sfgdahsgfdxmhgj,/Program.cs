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
string[] word = ["H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d"];
int a = 11;
void TypeWriter ()
{
    for (int i = 0; i < a; i++)
    {
        Console.Write(word[i]);
        Console.ReadLine();
    }
}
Window();
TypeWriter();