using Rodfy.Models;

namespace Rodfy.Menus;

public class MenuSingersAverage : Menu
{
    public void SingerAverage(Dictionary<string, Singer> singersList)
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
            
        }
    }
}