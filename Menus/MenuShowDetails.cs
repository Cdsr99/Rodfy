using Rodfy.Models;

namespace Rodfy.Menus;

public class MenuShowDetails : Menu
{
    public void ShowDetails(Dictionary<string, Singer> singersList)
    {
        Console.Clear();
        ShowOptionsTitle("Showing Singers Details");
        Console.Write("Enter with the name of the singer you want to know better: ");
        string singer = Console.ReadLine()!;
        if (singersList.ContainsKey(singer))
        {
            Singer singer1 = singersList[singer];
        
            singer1.ShowDetails();
        
            Console.WriteLine("Press any key to go to the menu again");
            Console.ReadKey();
            Console.Clear();

        }
    }
}