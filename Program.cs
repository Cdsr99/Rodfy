// Screen Sound
string welcome = "Welcome to RodFy";
//List<string> singersList = new List<string>{"Justin Bieber","Eminem", "Ice Cube"};  
Dictionary<string, List<int>> singersList = new Dictionary<string, List<int>>();

singersList.Add("Eminem", new List<int>{10, 10, 9, 8, 7});
singersList.Add("50 Cent", new List<int>{6, 3, 9, 7, 8});
singersList.Add("Dr Dre", new List<int>{7, 1, 4, 7, 3});

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
    Console.WriteLine("Type -1 to exit");

    Console.Write("\nEnter your option: ");
    string chosenOption = Console.ReadLine()!;
    int chosenOptionNumeric = int.Parse(chosenOption);
    
    switch (chosenOptionNumeric)
    {
        case 1: RegisterSongs();
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
        case -1: Console.WriteLine("Bye bye :)");
            break;
        default: Console.WriteLine("Incorrect option");
            break;
    }
}
#endregion

#region #1 - Register a Singer
void RegisterSongs()
{
    Console.Clear();
    ShowOptionsTitle("Register singer");
    Console.Write("\nEnter the name of the singer: ");
    string? singersName = Console.ReadLine();
    if (singersName != null)
    {
        singersList.Add(singersName, new List<int>());
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
        Console.Write($"\nRate the singer {singer}: ");
        int score = int.Parse(Console.ReadLine()!);
        singersList[singer].Add(score);
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
            RegisterSongs();
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
        Double average = singersList[singer].Average();
        
        Console.Write($"\nThe singer's rating is {average}");
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
            RegisterSongs();
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