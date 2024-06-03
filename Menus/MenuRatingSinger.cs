using Rodfy.Models;

namespace Rodfy.Menus;

public class MenuRatingSinger : Menu
{
    public void RateSinger(Dictionary<string, Singer> singersList)
    {
        Console.Clear();
        ShowOptionsTitle("Rating the singer");

        Console.Write("Please, enter with the singer's names: ");
        string singer = Console.ReadLine()!;
    
        if (singersList.ContainsKey(singer))
        {
            Singer singer1 = singersList[singer];
            Console.Write($"\nRate the singer {singer}: ");
            Assessment score = Assessment.Parse(Console.ReadLine()!);
        
            singer1.AddScore(score);
            Console.WriteLine($"\nSinger {singer}'s note was successfully registered");
            Thread.Sleep(3000);
            Console.Clear();
        }
        else
        {
            SingerNotCreated(singersList);
        }

    }
}