using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


Console.Clear();
messageWithColor(ConsoleColor.Red,"Welcome to Dark World!",true);
Console.ResetColor();
Console.WriteLine("Hello please select mode with number below!\n1: New Game\n2: Load Game\n3: Credit\n4: Exit");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Select>: ");
Console.ResetColor();
string sel = Console.ReadLine();

//initlize Character for player
Character Player = new Character();
//For new game
if(sel=="1")
{
    
    messageWithColor(ConsoleColor.DarkMagenta,"Select Class of your Hero!",true);
    Console.WriteLine("1: Knight");
    Console.WriteLine("2: Wizard");
    Console.WriteLine("3: Elf");
    Console.WriteLine("4: Warrior");
    messageWithColor(ConsoleColor.Green,"Select>: ",false);
    string classHero_Selector = Console.ReadLine();
    //For Knight
    if (classHero_Selector=="1")
    {
        messageWithColor(ConsoleColor.Green,"You has selected Knight, Please type user name: ",false);
        string userName = Console.ReadLine();
        Character Hero = new Character();
        Hero.Health=40;
        Hero.Damage=5;
        Hero.Defend=3;
        Hero.Mana=0;
        Hero.Level=1;
        Hero.EXP=0;
        Hero.Class="Knight";
        Hero.UserName = userName;
        Player = Hero;
       
    }
    //For Wizard
    if(classHero_Selector=="2")
    {
        messageWithColor(ConsoleColor.Green,"You has selected Wizard, Please type user name: ",false);
        string userName = Console.ReadLine();
        Character Hero = new Character();
        Hero.Health=20;
        Hero.Damage=2;
        Hero.Defend=2;
        Hero.Mana=20;
        Hero.Level=1;
        Hero.EXP=0;
        Hero.Class="Wizard";
        Hero.UserName = userName;
        Player = Hero;
        
    }
    //For Elf
    if(classHero_Selector=="3")
    {
        messageWithColor(ConsoleColor.Green,"You has selected Elf, Please type user name: ",false);
        string userName = Console.ReadLine();
        Character Hero = new Character();
        Hero.Health=30;
        Hero.Damage=4;
        Hero.Defend=3;
        Hero.Mana=20;
        Hero.Level=1;
        Hero.EXP=0;
        Hero.Class="Elf";
        Hero.UserName = userName;
        Player = Hero;
        
    }
    //For Warrior
    if(classHero_Selector=="4")
    {
        messageWithColor(ConsoleColor.Green,"You has selected Warrior, Please type user name: ",false);
        string userName = Console.ReadLine();
        Character Hero = new Character();
        Hero.Health=50;
        Hero.Damage=4;
        Hero.Defend=6;
        Hero.Mana=20;
        Hero.Level=1;
        Hero.EXP=0;
        Hero.UserName = userName;
        Hero.Class="Warrior";
        Player = Hero;
        
    }
    
   
    
}
if(sel=="2")
{
    messageWithColor(ConsoleColor.Green,"Please type User name here: ",false);
    string userName = Console.ReadLine();
}
//For print message with color
 void messageWithColor(ConsoleColor color,string message,bool brline)
    {
        Console.ForegroundColor = color;
        if(brline)
        Console.WriteLine(message);
        else
        Console.Write(message);
        Console.ResetColor();
    }