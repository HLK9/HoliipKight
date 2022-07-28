Console.WriteLine("Welcome to Dark World!");
Console.WriteLine("Hello please select mode with number below!\n1: New Game\n2: Load Game\n3: Credit\n4: Exit");
Console.Write("Select>: ");
string sel = Console.ReadLine();

//initlize Character for player
Character Player = new Character();

//For new game
if(sel=="1")
{
    
    Console.WriteLine("Select Class of your Hero!");
    Console.WriteLine("1: Knight");
    Console.WriteLine("2: Wizard");
    Console.WriteLine("3: Elf");
    Console.WriteLine("4: Warrior");
    Console.WriteLine("Select>: ");
    string classHero_Selector = Console.ReadLine();
    //For Knight
    if (classHero_Selector=="1")
    {
         Character Hero = new Character();
        Hero.Health=40;
        Hero.Damage=5;
        Hero.Defend=5;
        Hero.Mana=0;
        Hero.Level=1;
        Hero.EXP=0;
        Hero.Class="Knight";
        Player = Hero;
    }
    //For Wizard
    if(classHero_Selector=="2")
    {
        Character Hero = new Character();
        Hero.Health=20;
        Hero.Damage=2;
        Hero.Defend=3;
        Hero.Mana=20;
        Hero.Level=1;
        Hero.EXP=0;
        Hero.Class="Wizard";
        Player = Hero;
        
    }
    //
   
    
}