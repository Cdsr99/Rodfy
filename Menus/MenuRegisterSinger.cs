using Rodfy.Models;

namespace Rodfy.Menus;

public class MenuRegisterSinger: Menu
{
    public void RegisterSingers(Dictionary<string, Singer> singersList)
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
    }
}