// Screen Sound
using Rodfy.Models;
string welcome = "Welcome to RodFy";

Singer Eminem = new("Eminem");
Eminem.AddScore(10);
Eminem.AddScore(10);
Eminem.AddScore(10);
Eminem.AddScore(10);
Eminem.AddScore(10);
Eminem.AddScore(10);
Eminem.AddScore(9);

Singer LuisaSouza = new("LuisaSouza");
LuisaSouza.AddScore(0);
LuisaSouza.AddScore(0);
LuisaSouza.AddScore(0);
LuisaSouza.AddScore(0);
LuisaSouza.AddScore(0);
LuisaSouza.AddScore(0);
LuisaSouza.AddScore(0);


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

#region Menu
void ShowMenu()
{
    Console.Clear();
    ShowLogo();
    Console.WriteLine("\nEnter 1 to register a singer");
    Console.WriteLine("Enter 2 to show all singers");
    Console.WriteLine("Enter 3 to rate a singer");
    Console.WriteLine("Enter 4 to display the average of a singer");
    Console.WriteLine("Enter 5 to show singers details");
    Console.WriteLine("Type -1 to exit");

    Console.Write("\nEnter your option: ");
    string chosenOption = Console.ReadLine()!;
    int chosenOptionNumeric = int.Parse(chosenOption);
    
    switch (chosenOptionNumeric)
    {
        case 1: RegisterSingers();
            break;
        case 2:
            ShowSingers();
            break;
        case 3:
            RateSinger();
            break;
        case 4:
            SingerAverage();
            break;
        case 5:
            ShowDetails();
            break;
        case -1: Console.WriteLine("Bye bye :)");
            break;
        default: Console.WriteLine("Incorrect option");
            break;
    }
}
#endregion

#region #1 - Register a Singer
void RegisterSingers()
{
    Console.Clear();
    ShowOptionsTitle("Register singer");
    Console.Write("\nEnter the name of the singer: ");
    string? singersName = Console.ReadLine();
    if (singersName != null)
    {
        Singer singer = new(singersName);
        singersList.Add(singer.Name, singer);
        Console.Write($"The singer {singersName} has been create with success!");
    }

    Thread.Sleep(2000);
    ShowMenu();
}
#endregion

#region #2 Showing all the Singers
void ShowSingers()
{
    Console.Clear();
    
    ShowOptionsTitle("Show all the singers");
    
    int i = 0;
    foreach (var singer in singersList.Keys)
    {
        Console.WriteLine($"{i} - Singer {singer}");
        i++;
    }
    
    Console.WriteLine("\nPress any key to go back to the menu");
    Console.ReadKey();
    ShowMenu();
}
#endregion

#region #3 - Rate the singer
void RateSinger()
{
    Console.Clear();
    ShowOptionsTitle("Rating the singer");

    Console.Write("Please, enter with the singer's names: ");
    string singer = Console.ReadLine()!;
    
    if (singersList.ContainsKey(singer))
    {
        Singer singer1 = singersList[singer];
        Console.Write($"\nRate the singer {singer}: ");
        int score = int.Parse(Console.ReadLine()!);
        
        singer1.AddScore(score);
        Console.WriteLine($"\nSinger {singer}'s note was successfully registered");
        Thread.Sleep(3000);
        Console.Clear();
        ShowMenu();
    }
    else
    {
        Console.WriteLine($"\nThe singer has not been registered, do you want to create?");
        Console.WriteLine($"\ny - yes and n - no");
        string choseOption = Console.ReadLine()!;

        if (choseOption == "y")
        {
            RegisterSingers();
        }
        else if (choseOption == "n")
        {
            ShowMenu();
        }
        else
        {
            ShowMenu();
        }
    }
}
#endregion

#region #4 - Showing the singer's average
void SingerAverage()
{
    Console.Clear();
    ShowOptionsTitle("Singer's average");

    Console.Write("Please, enter with the singer's names: ");
    string singer = Console.ReadLine()!;
    
    if (singersList.ContainsKey(singer))
    {
        Singer singer1 = singersList[singer];
        
        Console.Write($"\nThe singer's rating is {singer1.Average}");
        Thread.Sleep(3000);
        Console.Clear();
        ShowMenu();
    }
    else
    {
        Console.WriteLine($"\nThe singer has not been registered, do you want to create?");
        Console.WriteLine($"\ny - yes and n - no");
        string choseOption = Console.ReadLine()!;

        if (choseOption == "y")
        {
            RegisterSingers();
        }
        else if (choseOption == "n")
        {
            ShowMenu();
        }
        else
        {
            ShowMenu();
        }
    }
}
#endregion

#region #5 - Showing singers details
void ShowDetails()
{
    Console.Clear();
    ShowOptionsTitle("Showing Singers Details");
    Console.Write("Enter with the name of the singer you want to know better: ");
    string singer = Console.ReadLine()!;
    if (singersList.ContainsKey(singer))
    {
        Singer singer1 = singersList[singer];
        
        Console.WriteLine($"\nThe {singer1.Name} score is {singer1.Average}.");

        Console.WriteLine("Press any key to go to the menu again");
        Console.ReadKey();
        Console.Clear();
        ShowMenu();

    }
    else
    {
        Console.WriteLine($"\n{singer} has not found!");
        Console.WriteLine("Press any key to go to the menu again");
        Console.ReadKey();
        Console.Clear();
        ShowMenu();
    }
}


#endregion

#region Showing titles
void ShowOptionsTitle(string title)
{
    int titlesLength = title.Length;
    string asterisk = string.Empty.PadLeft(titlesLength, '*');
    Console.WriteLine(asterisk);
    Console.WriteLine(title);
    Console.WriteLine(asterisk);
}
#endregion



ShowMenu();
