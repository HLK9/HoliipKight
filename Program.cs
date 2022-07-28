Console.WriteLine("Welcome to Dark World!");
Console.WriteLine("Hello please select mode with number below!\n1: New Game\n2: Load Game\n3: Credit\n4: Exit");
Console.Write("Select>: ");
string sel = Console.ReadLine();

//For new game
if(sel=="1")
{
    Console.WriteLine("Select Class of your Hero!");
    Console.WriteLine("1: Knight");
    Console.WriteLine("2: Wizard");
    Console.WriteLine("3: Elf");
    Console.WriteLine("4: Warrior");
     Console.WriteLine("Select>: ");
    string classHero = Console.ReadLine();
}