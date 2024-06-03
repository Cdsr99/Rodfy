using Rodfy.Models;

namespace Rodfy.Menus;

public class MenuShowSingers: Menu
{
    #region #2 Showing all the Singers
    public void ShowSingers(Dictionary<string, Singer> singersList)
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
        
    }
    #endregion
}