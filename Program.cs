// Screen Sound

using Rodfy.Menus;
using Rodfy.Models;
string welcome = "Welcome to RodFy";

Singer Eminem = new("Eminem");
Eminem.AddScore(new Assessment(10));
Eminem.AddScore(new Assessment(10));
Eminem.AddScore(new Assessment(10));
Eminem.AddScore(new Assessment(10));
Eminem.AddScore(new Assessment(10));
Eminem.AddScore(new Assessment(10));
Eminem.AddScore(new Assessment(9));


Dictionary<string, Singer> singersList = new Dictionary<string, Singer>();

singersList.Add(Eminem.Name, Eminem);

#region Showing the logo
void ShowLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(welcome);
}
#endregion

void ShowMenu()
{
    Console.Clear();
    ShowLogo();
    Console.WriteLine("\nEnter 1 to register a singer");
    Console.WriteLine("Enter 2 to show all singers");
    Console.WriteLine("Enter 3 to rate a singer");
    Console.WriteLine("Enter 4 to display the average of a singer");
    Console.WriteLine("Enter 5 to show singers details");
    Console.WriteLine("Enter 6 to create an album");
    Console.WriteLine("Type -1 to exit");

    Console.Write("\nEnter your option: ");
    string chosenOption = Console.ReadLine()!;
    int chosenOptionNumeric = int.Parse(chosenOption);

    if (string.IsNullOrEmpty(chosenOption))
    {
        Console.WriteLine("Incorrect option");
        Thread.Sleep(2000);
        ShowMenu();
    }
    else
    {
        switch (chosenOptionNumeric)
        {
            case 1:
                MenuRegisterSinger menu1 = new();
                menu1.RegisterSingers(singersList);
                ShowMenu();
                break;
            case 2:
                MenuShowSingers menu2 = new();
                menu2.ShowSingers(singersList);
                ShowMenu();
                break;
            case 3:
                MenuRatingSinger menu3 = new();
                menu3.RateSinger(singersList);
                ShowMenu();
                break;
            case 4:
                MenuSingersAverage menu4 = new();
                menu4.SingerAverage(singersList);
                ShowMenu();
                break;
            case 5:
                MenuShowDetails menu5 = new();
                menu5.ShowDetails(singersList);
                ShowMenu();
                break;
            case 6:
                MenuCreateAlbum menu6 = new();
                menu6.CreateAlbum(singersList);
                ShowMenu();
                break;
            case -1: Console.WriteLine("Bye bye :)");
                break;
            default: Console.WriteLine("Incorrect option");
                break;
        }
    }

}
ShowMenu();
