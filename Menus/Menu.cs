using Rodfy.Models;

namespace Rodfy.Menus;

public class Menu 
{
    #region Showing titles
    public void ShowOptionsTitle(string title)
    {
        int titlesLength = title.Length;
        string asterisk = string.Empty.PadLeft(titlesLength, '*');
        Console.WriteLine(asterisk);
        Console.WriteLine(title);
        Console.WriteLine(asterisk);
    }
    #endregion
    
    #region Wanna create a singer?

    public void SingerNotCreated(Dictionary<string, Singer> singersList)
    {
        Console.WriteLine($"\nThe singer has not been registered, do you want to create?");
        Console.Write($"\ny - yes and n - no: ");
        string choseOption = Console.ReadLine()!;

        if (choseOption == "y")
        {
            MenuRegisterSinger menu1 = new();
            menu1.RegisterSingers(singersList);
        }
    }

    #endregion
}