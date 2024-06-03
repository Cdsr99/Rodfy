using Rodfy.Models;

namespace Rodfy.Menus;

public class MenuCreateAlbum : Menu
{
    public void CreateAlbum(Dictionary<string, Singer> singersList)
    {
        Console.Clear();
        ShowOptionsTitle("Create an Album");
        Console.Write("Enter with the name of the singer of the album: ");
        string singerName = Console.ReadLine()!;

        if (singersList.ContainsKey(singerName))
        {
            Console.Write("Now enter with the name of the album: ");
            string albumsName = Console.ReadLine()!;

            Singer singer1 = singersList[singerName];
            Album album1 = new Album(albumsName);
            singer1.AddAlbum(album1);

            Console.WriteLine($"The album {albumsName} of {singerName} has been registered successfully!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        
    }
    
}