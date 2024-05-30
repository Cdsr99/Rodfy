// Screen Sound
string welcome = "Welcome to RodFy";

List<string> singersList = new List<string>{"Justin Bieber","Eminem", "Ice Cube"};  

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

void CleanScreen()
{
    Console.Clear();
}

void ShowMenu()
{
    CleanScreen();
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
            Console.WriteLine("You chose option number: " + chosenOptionNumeric);
            break;
        case 4: 
            Console.WriteLine("You chose option number: " + chosenOptionNumeric);
            break;
        case -1: Console.WriteLine("Bye bye :)");
            break;
        default: Console.WriteLine("Incorrect option");
            break;
    }
}

ShowMenu();


void RegisterSongs()
{
    Console.Clear();
    Console.Write("Register Singer");
    Console.Write("\nEnter the name of the singer: ");
    string? singersName = Console.ReadLine();
    singersList.Add(singersName);
    Console.Write($"The singer {singersName} has been create with success!");
    Thread.Sleep(3000);
    ShowMenu();
}

void ShowSingers()
{
    Console.Clear();

    Console.WriteLine("*************************************");
    Console.WriteLine("Showing all the singers");
    Console.WriteLine("*************************************\n");

    for (int i = 0; i < singersList.Count(); i++)
    {
        Console.WriteLine($"{i} - Singer {singersList[i]}");
    }

    Console.WriteLine("\nPress any key to go back to the menu");
    Console.ReadKey();
    ShowMenu();
}